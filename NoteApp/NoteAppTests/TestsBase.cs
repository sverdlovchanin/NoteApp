using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp.Classes;
using FluentAssertions;

namespace NoteAppTests;

internal class TestsBase
{
    protected const int Capacity = 200;

    protected Note TestNote => new()
    {
        Name = $"Name_{DateTime.Now.Ticks}",
        Text = $"Text_{DateTime.Now.Ticks}",
        Category = (Category)new Random().Next(0, 6)
    };

    protected Note[] GetTestNotes(int capacity) => Enumerable.Range(0, capacity).Select(_ => TestNote).ToArray();

    protected Project GetTestProject()
    {
        var project = new Project();
        var notes = GetTestNotes(Capacity).OrderBy(n => n.Name);

        foreach (var note in notes)
        {
            project.OnNoteAdded(note);
        }

        return project;
    }
}
