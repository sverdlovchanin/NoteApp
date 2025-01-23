using NoteApp.Classes;
using System.ComponentModel.DataAnnotations;

namespace NoteAppUI;

public partial class EditNoteForm : Form
{
    private readonly Note _note;

    public EditNoteForm(Note note)
    {
        InitializeComponent();
        _note = note;
        SetupFormFromNote();
    }

    #region Event handlers

    /// <summary>
    /// Click on submit button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OkButton_Click(object sender, EventArgs e)
    {
        if (!IsNoteValid()) return;
        DialogResult = DialogResult.OK;
    }

    /// <summary>
    /// Edit note name
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NoteNameTextBox_KeyDown(object sender, KeyEventArgs e) => ClearError();

    #endregion Event handlers

    /// <summary>
    /// Update UI from note model
    /// </summary>
    private void SetupFormFromNote()
    {
        noteNameTextBox.Text = _note.Name;
        noteCreateDateTimePicker.Value = _note.CreateTime;
        noteModifyDateTimePicker.Value = _note.UpdateTime;
        noteCategoryComboBox.Items.AddRange(Enum.GetNames<Category>());
        noteCategoryComboBox.SelectedIndex = (int)_note.Category;
        noteTextBox.Text = _note.Text;
    }

    /// <summary>
    /// Update note model from UI
    /// </summary>
    private void SetupNoteFromForm()
    {
        _note.Name = noteNameTextBox.Text;
        _note.Text = noteTextBox.Text;
        _note.Category = (Category)noteCategoryComboBox.SelectedIndex;
        _note.UpdateTime = DateTime.Now;
    }
    

    /// <summary>
    /// Validate note model
    /// </summary>
    /// <returns></returns>
    private bool IsNoteValid()
    {
        SetupNoteFromForm();

        var results = new List<ValidationResult>();
        var isNoteValid = Validator.TryValidateObject(_note, new ValidationContext(_note), results, false);

        if (!isNoteValid)
            SetError(results.First().ErrorMessage!);

        return isNoteValid;
    }

    /// <summary>
    /// Set error information
    /// </summary>
    /// <param name="errorMessage"></param>
    private void SetError(string errorMessage)
    {
        noteNameErrorProvider.SetError(noteNameTextBox, errorMessage);
        noteNameTextBox.BackColor = Color.LightPink;
    }   

    /// <summary>
    /// Clear error information
    /// </summary>
    private void ClearError()
    {
        noteNameErrorProvider.Clear();
        noteNameTextBox.BackColor = Color.White;
    }
}
