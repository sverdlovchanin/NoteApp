using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp.Classes;
using FluentAssertions;

namespace NoteAppTests;

internal class NoteTests : TestsBase
{
    [Test]
    public void NewNoteInitialFieldsShouldBeSetCorrectly()
    {
        var note = new Note();

        note.Name.Should().BeEquivalentTo("[No Name]");
        note.Text.Should().BeNull();
        note.CreateTime.Should().BeCloseTo(DateTime.Now, TimeSpan.FromSeconds(1));
        note.UpdateTime.Should().BeOnOrAfter(note.CreateTime);
        note.Category.Should().Be(default);
    }

    [TestCase(null!), TestCase("")]
    public void NoteShouldNotBeValidIfNameEmpty(string name)
    {
        var note = new Note { Name = name };

        var results = new List<ValidationResult>();
        var isNoteValid = Validator.TryValidateObject(note, new ValidationContext(note), results, false);

        isNoteValid.Should().BeFalse();
        results.Should().HaveCount(1);
        results[0].ErrorMessage.Should().BeEquivalentTo($"{nameof(note.Name)} is required");
    }

    [Test]
    public void NoteShouldNotBeValidIfNameGreater50Chars()
    {
        var note = new Note { Name = "ttttttttttttttttttttttttttttttttttttttttttttttttttt" };

        var results = new List<ValidationResult>();
        var isNoteValid = Validator.TryValidateObject(note, new ValidationContext(note), results, false);

        isNoteValid.Should().BeFalse();
        results.Should().HaveCount(1);
        results[0].ErrorMessage.Should().BeEquivalentTo($"{nameof(note.Name)} should be less or equal 50 chars");
    }

    [Test]
    public void NoteShouldNotBeValidIfCreateTimeEmpty()
    {
        var note = new Note { CreateTime = DateTime.MinValue };

        var results = new List<ValidationResult>();
        var isNoteValid = Validator.TryValidateObject(note, new ValidationContext(note), results, false);

        isNoteValid.Should().BeFalse();
        results.Should().HaveCount(1);
        results[0].ErrorMessage.Should().BeEquivalentTo($"{note.CreateTime} can not be empty");
    }

    [Test]
    public void NoteShouldNotBeValidIfUpdateTimeEmptyOrLessCreateTime()
    {
        var note = new Note { UpdateTime = DateTime.MinValue };

        var results = new List<ValidationResult>();
        var isNoteValid = Validator.TryValidateObject(note, new ValidationContext(note), results, false);

        isNoteValid.Should().BeFalse();
        results.Should().HaveCount(2);
        results[0].ErrorMessage.Should().BeEquivalentTo($"{note.UpdateTime} can not be empty");
        results[1].ErrorMessage.Should().BeEquivalentTo($"{note.UpdateTime} can not be less then {note.CreateTime}");
    }

    [Test]
    public void DefaultNoteShouldBeValid()
    {
        var note = new Note();

        var results = new List<ValidationResult>();
        var isNoteValid = Validator.TryValidateObject(note, new ValidationContext(note), results, false);

        isNoteValid.Should().BeTrue();
        results.Should().BeEmpty();
    }

    [Test]
    public void ClonedNoteShouldBeMembersEqualToSource()
    {
        var note = new Note { Category = Category.Other, Name = "Test", Text = "Test text" };

        var copy = note.Clone();

        copy.Should().BeEquivalentTo(note);
    }
}
