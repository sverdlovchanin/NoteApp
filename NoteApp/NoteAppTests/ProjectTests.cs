using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp.Classes;
using FluentAssertions;

namespace NoteAppTests;

internal class ProjectTests : TestsBase
{
    [Test]
    public void NoteShouldBeActiveAndInListAfterAdd()
    {
        var project = new Project();
        var note = TestNote;

        project.OnNoteAdded(note);

        project.Notes.Should().Contain(note);
        project.CurrentNote.Should().Be(note);
    }

    [Test]
    public void CurrentCategoryShouldBeChangedAfterNoteAdd()
    {
        var project = new Project() { CurrentCategory = Category.Other };
        var note = TestNote;
        note.Category = Category.Work;

        project.OnNoteAdded(note);

        project.CurrentCategory.Should().Be(note.Category);
    }

    [Test]
    public void NoteListShouldBeOrderedByUpdateTimeDescending()
    {
        Project project = GetTestProject();

        project.Notes.Should().HaveCount(Capacity);
        project.Notes.Should().BeInDescendingOrder((n1, n2) => n1.UpdateTime.CompareTo(n2.UpdateTime));
    }

    [Test]
    public void NoteListShouldChangeCurrentCategoryOnSelected()
    {
        Project project = GetTestProject();

        project.OnCategorySelected((int)Category.Work);

        project.CurrentCategory.Should().Be(Category.Work);
        project.CurrentNote?.Category.Should().Be(Category.Work);
    }

    [Test]
    public void NoteListShouldBeFilteredByCurrentCategory()
    {
        Project project = GetTestProject();

        project.OnCategorySelected((int)Category.Work);

        project.Notes.Select(n => n.Category).Should().AllSatisfy(c => c.Should().Be(Category.Work));
    }

    [Test]
    public void CurrentNoteShouldBeChangedOnNoteSelect()
    {
        Project project = GetTestProject();

        project.OnNoteSelected(10);

        project.CurrentNote.Should().BeEquivalentTo(project.Notes.ToArray()[10]);
    }

    [Test]
    public void EditedNoteShouldBeUpdatedAndBecomeActive()
    {
        Project project = GetTestProject();

        project.OnNoteSelected(10);

        var note = TestNote;
        project.OnNoteUpdated(note);

        project.CurrentNote.Should().BeEquivalentTo(note);
        project.CurrentNote.Should().BeEquivalentTo(project.Notes.ToArray()[0]);
        project.Notes.Should().HaveCount(Capacity);
    }

    [Test]
    public void NoteShouldBeRemovedFromListOnDelete()
    {
        Project project = GetTestProject();

        project.OnNoteSelected(10);
        var note = project.CurrentNote;

        project.OnNoteRemoved();

        project.Notes.Should().HaveCount(Capacity - 1);
        project.Notes.Should().NotContain(note!);
        project.CurrentNote.Should().BeEquivalentTo(project.Notes.ToArray()[0]);
    }
}
