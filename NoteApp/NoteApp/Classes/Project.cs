using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Threading.Tasks;
using JsonIgnoreAttribute = Newtonsoft.Json.JsonIgnoreAttribute;
using NoteApp.Extension;

namespace NoteApp.Classes;

/// <summary>
/// Note list project
/// </summary>
public class Project
{
    /// <summary>
    /// Selected category
    /// </summary>
    [JsonProperty]
    public Category? CurrentCategory { get; set; }

    /// <summary>
    /// Selected note
    /// </summary>
    [JsonProperty]
    public Note? CurrentNote { get; set; }

    /// <summary>
    /// Selected note index
    /// </summary>
    [JsonIgnore]
    public int CurrentNoteIndex => Notes.IndexOf(CurrentNote);

    /// <summary>
    /// Ordered notes list, filtered by selected category if it's selected
    /// </summary>
    [JsonIgnore]
    public IEnumerable<Note> Notes => CurrentCategory.HasValue
        ? NotesByCategory(CurrentCategory.Value)
        : NotesSortedList.Select(n => n.Value);

    /// <summary>
    /// Notes ordered by update time descending filtered by category
    /// </summary>
    /// <param name="category">active category</param>
    /// <returns></returns>
    private IEnumerable<Note> NotesByCategory(Category category) => NotesSortedList.Where(n => n.Value.Category == category).Select(n => n.Value);

    /// <summary>
    /// Notes ordered by update time descending
    /// </summary>
    [JsonProperty]
    private SortedList<DateTime, Note> NotesSortedList { get; set; } = new SortedList<DateTime, Note>(new DescendingComparer<DateTime>());

    /// <summary>
    /// Handle select category event
    /// </summary>
    /// <param name="category">selected category</param>
    public void OnCategorySelected(int category)
    {
        CurrentCategory = category < 0 ? null : (Category)category;
        if (CurrentNote == null || CurrentCategory != null && CurrentNote.Category != CurrentCategory)
            OnNoteSelected(0);
    }

    /// <summary>
    /// Handle select note
    /// </summary>
    /// <param name="noteIndex">selected note index</param>
    public void OnNoteSelected(int noteIndex) =>
        CurrentNote = Notes.Count() > noteIndex ? Notes.ElementAt(noteIndex) : null;

    /// <summary>
    /// Handle note added event
    /// </summary>
    /// <param name="note">new note</param>
    public void OnNoteAdded(Note note)
    {
        NotesSortedList.Add(note.UpdateTime, note);
        if (CurrentCategory != null)
            CurrentCategory = note.Category;
        CurrentNote = note;
    }

    /// <summary>
    /// Handle note updated event
    /// </summary>
    public void OnNoteUpdated(Note note)
    {
        OnNoteRemoved();
        OnNoteAdded(note);
    }

    /// <summary>
    /// Handle note deleted event
    /// </summary>
    public void OnNoteRemoved()
    {
        if (CurrentNote == null) return;
        NotesSortedList.Remove(CurrentNote.UpdateTime);
        OnNoteSelected(0);
    }
}
