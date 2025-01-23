using NoteApp.Classes;
using NoteApp;
namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        private Project _project = null!;

        public MainForm()
        {
            TryExecute(() => { _project = ProjectManager.Load(); });
            _project ??= new();
            InitializeComponent();
        }

        #region Event handlers

        /// <summary>
        /// Load main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e) => SetupFormFromProject();


        /// <summary>
        /// Handle exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Handle add new note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            Note note = new() { Category = _project.CurrentCategory ?? default };
            var dialogResult = ShowEditNoteDialog(note);

            if (dialogResult == DialogResult.OK)
            {
                _project.OnNoteAdded(note);
                SaveProject();
                SetupFormFromProject();
            }
        }

        /// <summary>
        /// Handle edit note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            Note noteCopy = (Note)_project.CurrentNote!.Clone();
            var dialogResult = ShowEditNoteDialog(noteCopy);

            if (dialogResult == DialogResult.OK)
            {
                _project.OnNoteUpdated(noteCopy);
                SaveProject();
                SetupFormFromProject();
            }
        }

        /// <summary>
        /// Handle delete note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Do you really want to remove this note: {_project.CurrentNote!.Name}?",
                "Attention",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                _project.OnNoteRemoved();
                SaveProject();
                SetupFormFromProject();
            }
        }

        /// <summary>
        /// Handle select category event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = ((ComboBox)sender).SelectedIndex - 1;
            _project.OnCategorySelected(category);
            SaveProject();
            SetupFormFromProject();
        }

        /// <summary>
        /// Handle select note event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = ((ListBox)sender).SelectedIndex;
            _project.OnNoteSelected(selectedIndex);
            SaveProject();
            SetupNoteDetails();
        }

        #endregion Event handlers

        /// <summary>
        /// Setup Form from project
        /// </summary>
        private void SetupFormFromProject()
        {
            SetupCategoriesComboBox();
            SetupNotesList();
            SetupNoteDetails();
            SetupControlsState();
        }

        /// <summary>
        /// Setup categories control
        /// </summary>
        private void SetupCategoriesComboBox()
        {
            if (categoriesComboBox.Items.Count == 0)
            {
                categoriesComboBox.Items.Add("All");
                categoriesComboBox.Items.AddRange(Enum.GetNames<Category>());
            }
            categoriesComboBox.SelectedIndex = _project.CurrentCategory is null ? 0 : ((int)_project.CurrentCategory.Value + 1);
        }

        /// <summary>
        /// Setup notes list control
        /// </summary>
        private void SetupNotesList()
        {
            notesListBox.Items.Clear();
            notesListBox.Items.AddRange(_project.Notes.Select(n => n.Name).ToArray());

            if (_project.CurrentNote is not null)
            {
                notesListBox.SelectedIndex = _project.CurrentNoteIndex;
                notesListBox.Focus();
            }
        }

        /// <summary>
        /// Setup notes details controls
        /// </summary>
        private void SetupNoteDetails()
        {
            if (_project.CurrentNote == null)
            {
                mainContainer.Panel2.Hide();
                return;
            }

            noteNameLabel.Text = _project.CurrentNote.Name;
            noteCategoryLabel.Text = _project.CurrentNote.Category.ToString();
            noteCreateDateTimePicker.Value = _project.CurrentNote.CreateTime;
            noteModifyDateTimePicker.Value = _project.CurrentNote.UpdateTime;
            NoteTextBox.Text = _project.CurrentNote.Text;
            mainContainer.Panel2.Show();
        }

        /// <summary>
        /// Setup buttons mode
        /// </summary>
        private void SetupControlsState()
        {
            if (_project.CurrentNote == null)
            {
                editNoteButton.Enabled = false;
                deleteNoteButton.Enabled = false;
                editNoteToolStripMenuItem.Enabled = false;
                deleteNoteToolStripMenuItem.Enabled = false;
            }
            else
            {
                editNoteButton.Enabled = true;
                deleteNoteButton.Enabled = true;
                editNoteToolStripMenuItem.Enabled = true;
                deleteNoteToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// Open note edit dialog
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        private static DialogResult ShowEditNoteDialog(Note note) => new EditNoteForm(note).ShowDialog();

        /// <summary>
        /// Save project changes to file
        /// </summary>
        private void SaveProject() => TryExecute(() => ProjectManager.Save(_project));

        /// <summary>
        /// Try execute action and show error if exception
        /// </summary>
        /// <param name="act"></param>
        private static void TryExecute(Action act)
        {
            try
            {
                act();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error happened: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
