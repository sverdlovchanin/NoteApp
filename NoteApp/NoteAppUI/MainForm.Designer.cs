namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addNoteToolStripMenuItem = new ToolStripMenuItem();
            editNoteToolStripMenuItem = new ToolStripMenuItem();
            deleteNoteToolStripMenuItem = new ToolStripMenuItem();
            mainContainer = new SplitContainer();
            deleteNoteButton = new Button();
            editNoteButton = new Button();
            addNoteButton = new Button();
            notesListBox = new ListBox();
            categoriesCbLabel = new Label();
            categoriesComboBox = new ComboBox();
            NoteTextBox = new TextBox();
            noteModifyDateTimePicker = new DateTimePicker();
            noteCreateDateTimePicker = new DateTimePicker();
            noteModifyLabel = new Label();
            noteCategoryLabel = new Label();
            noteCreateDateLabel = new Label();
            noteCategoryCaptionLabel = new Label();
            noteNameLabel = new Label();
            addNoteToolTip = new ToolTip(components);
            mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainContainer).BeginInit();
            mainContainer.Panel1.SuspendLayout();
            mainContainer.Panel2.SuspendLayout();
            mainContainer.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.ImageScalingSize = new Size(20, 20);
            mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Padding = new Padding(8, 2, 0, 2);
            mainMenu.Size = new Size(1478, 33);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNoteToolStripMenuItem, editNoteToolStripMenuItem, deleteNoteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            addNoteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            addNoteToolStripMenuItem.Size = new Size(260, 34);
            addNoteToolStripMenuItem.Text = "Add Note";
            addNoteToolStripMenuItem.Click += AddNoteButton_Click;
            // 
            // editNoteToolStripMenuItem
            // 
            editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            editNoteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            editNoteToolStripMenuItem.Size = new Size(260, 34);
            editNoteToolStripMenuItem.Text = "Edit Note";
            editNoteToolStripMenuItem.Click += EditNoteButton_Click;
            // 
            // deleteNoteToolStripMenuItem
            // 
            deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
            deleteNoteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            deleteNoteToolStripMenuItem.Size = new Size(260, 34);
            deleteNoteToolStripMenuItem.Text = "Remove Note";
            deleteNoteToolStripMenuItem.Click += DeleteNoteButton_Click;
            // 
            // mainContainer
            // 
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 33);
            mainContainer.Margin = new Padding(4);
            mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            mainContainer.Panel1.Controls.Add(deleteNoteButton);
            mainContainer.Panel1.Controls.Add(editNoteButton);
            mainContainer.Panel1.Controls.Add(addNoteButton);
            mainContainer.Panel1.Controls.Add(notesListBox);
            mainContainer.Panel1.Controls.Add(categoriesCbLabel);
            mainContainer.Panel1.Controls.Add(categoriesComboBox);
            mainContainer.Panel1MinSize = 350;
            // 
            // mainContainer.Panel2
            // 
            mainContainer.Panel2.Controls.Add(NoteTextBox);
            mainContainer.Panel2.Controls.Add(noteModifyDateTimePicker);
            mainContainer.Panel2.Controls.Add(noteCreateDateTimePicker);
            mainContainer.Panel2.Controls.Add(noteModifyLabel);
            mainContainer.Panel2.Controls.Add(noteCategoryLabel);
            mainContainer.Panel2.Controls.Add(noteCreateDateLabel);
            mainContainer.Panel2.Controls.Add(noteCategoryCaptionLabel);
            mainContainer.Panel2.Controls.Add(noteNameLabel);
            mainContainer.Panel2MinSize = 550;
            mainContainer.Size = new Size(1478, 868);
            mainContainer.SplitterDistance = 453;
            mainContainer.SplitterWidth = 5;
            mainContainer.TabIndex = 1;
            // 
            // deleteNoteButton
            // 
            deleteNoteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            deleteNoteButton.BackgroundImage = Properties.Resources.delete_document;
            deleteNoteButton.BackgroundImageLayout = ImageLayout.Stretch;
            deleteNoteButton.Location = new Point(162, 802);
            deleteNoteButton.Margin = new Padding(4);
            deleteNoteButton.Name = "deleteNoteButton";
            deleteNoteButton.Size = new Size(49, 51);
            deleteNoteButton.TabIndex = 5;
            deleteNoteButton.UseVisualStyleBackColor = true;
            deleteNoteButton.Click += DeleteNoteButton_Click;
            // 
            // editNoteButton
            // 
            editNoteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            editNoteButton.BackgroundImage = Properties.Resources.file_edit__1_;
            editNoteButton.BackgroundImageLayout = ImageLayout.Stretch;
            editNoteButton.Location = new Point(89, 802);
            editNoteButton.Margin = new Padding(4);
            editNoteButton.Name = "editNoteButton";
            editNoteButton.Size = new Size(49, 51);
            editNoteButton.TabIndex = 4;
            editNoteButton.UseVisualStyleBackColor = true;
            editNoteButton.Click += EditNoteButton_Click;
            // 
            // addNoteButton
            // 
            addNoteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addNoteButton.BackgroundImage = Properties.Resources.add_document;
            addNoteButton.BackgroundImageLayout = ImageLayout.Stretch;
            addNoteButton.Location = new Point(15, 802);
            addNoteButton.Margin = new Padding(4);
            addNoteButton.Name = "addNoteButton";
            addNoteButton.Size = new Size(49, 51);
            addNoteButton.TabIndex = 3;
            addNoteButton.Tag = "";
            addNoteButton.UseVisualStyleBackColor = true;
            addNoteButton.Click += AddNoteButton_Click;
            // 
            // notesListBox
            // 
            notesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            notesListBox.FormattingEnabled = true;
            notesListBox.ItemHeight = 25;
            notesListBox.Location = new Point(15, 82);
            notesListBox.Margin = new Padding(4);
            notesListBox.Name = "notesListBox";
            notesListBox.Size = new Size(421, 679);
            notesListBox.TabIndex = 2;
            notesListBox.SelectedIndexChanged += NotesListBox_SelectedIndexChanged;
            // 
            // categoriesCbLabel
            // 
            categoriesCbLabel.AutoSize = true;
            categoriesCbLabel.Location = new Point(15, 24);
            categoriesCbLabel.Margin = new Padding(4, 0, 4, 0);
            categoriesCbLabel.Name = "categoriesCbLabel";
            categoriesCbLabel.Size = new Size(137, 25);
            categoriesCbLabel.TabIndex = 1;
            categoriesCbLabel.Text = "Show Category:";
            // 
            // categoriesComboBox
            // 
            categoriesComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoriesComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            categoriesComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            categoriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoriesComboBox.Location = new Point(162, 20);
            categoriesComboBox.Margin = new Padding(4);
            categoriesComboBox.Name = "categoriesComboBox";
            categoriesComboBox.Size = new Size(273, 33);
            categoriesComboBox.TabIndex = 1;
            categoriesComboBox.SelectedIndexChanged += CategoriesComboBox_SelectedIndexChanged;
            // 
            // NoteTextBox
            // 
            NoteTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NoteTextBox.BackColor = SystemColors.Info;
            NoteTextBox.Location = new Point(22, 185);
            NoteTextBox.Margin = new Padding(4);
            NoteTextBox.Multiline = true;
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.ReadOnly = true;
            NoteTextBox.ScrollBars = ScrollBars.Vertical;
            NoteTextBox.Size = new Size(980, 667);
            NoteTextBox.TabIndex = 3;
            // 
            // noteModifyDateTimePicker
            // 
            noteModifyDateTimePicker.CustomFormat = "dd.MM.yy HH:mm:ss";
            noteModifyDateTimePicker.Enabled = false;
            noteModifyDateTimePicker.Format = DateTimePickerFormat.Custom;
            noteModifyDateTimePicker.Location = new Point(449, 128);
            noteModifyDateTimePicker.Margin = new Padding(4);
            noteModifyDateTimePicker.Name = "noteModifyDateTimePicker";
            noteModifyDateTimePicker.Size = new Size(224, 31);
            noteModifyDateTimePicker.TabIndex = 2;
            // 
            // noteCreateDateTimePicker
            // 
            noteCreateDateTimePicker.CustomFormat = "dd.MM.yy HH:mm:ss";
            noteCreateDateTimePicker.Enabled = false;
            noteCreateDateTimePicker.Format = DateTimePickerFormat.Custom;
            noteCreateDateTimePicker.Location = new Point(109, 128);
            noteCreateDateTimePicker.Margin = new Padding(4);
            noteCreateDateTimePicker.Name = "noteCreateDateTimePicker";
            noteCreateDateTimePicker.Size = new Size(224, 31);
            noteCreateDateTimePicker.TabIndex = 2;
            // 
            // noteModifyLabel
            // 
            noteModifyLabel.AutoSize = true;
            noteModifyLabel.Location = new Point(351, 131);
            noteModifyLabel.Margin = new Padding(4, 0, 4, 0);
            noteModifyLabel.Name = "noteModifyLabel";
            noteModifyLabel.Size = new Size(88, 25);
            noteModifyLabel.TabIndex = 1;
            noteModifyLabel.Text = "Modified:";
            // 
            // noteCategoryLabel
            // 
            noteCategoryLabel.AutoSize = true;
            noteCategoryLabel.Location = new Point(120, 82);
            noteCategoryLabel.Margin = new Padding(4, 0, 4, 0);
            noteCategoryLabel.Name = "noteCategoryLabel";
            noteCategoryLabel.Size = new Size(161, 25);
            noteCategoryLabel.TabIndex = 1;
            noteCategoryLabel.Text = "noteCategoryLabel";
            // 
            // noteCreateDateLabel
            // 
            noteCreateDateLabel.AutoSize = true;
            noteCreateDateLabel.Location = new Point(22, 131);
            noteCreateDateLabel.Margin = new Padding(4, 0, 4, 0);
            noteCreateDateLabel.Name = "noteCreateDateLabel";
            noteCreateDateLabel.Size = new Size(77, 25);
            noteCreateDateLabel.TabIndex = 1;
            noteCreateDateLabel.Text = "Created:";
            // 
            // noteCategoryCaptionLabel
            // 
            noteCategoryCaptionLabel.AutoSize = true;
            noteCategoryCaptionLabel.Location = new Point(22, 82);
            noteCategoryCaptionLabel.Margin = new Padding(4, 0, 4, 0);
            noteCategoryCaptionLabel.Name = "noteCategoryCaptionLabel";
            noteCategoryCaptionLabel.Size = new Size(88, 25);
            noteCategoryCaptionLabel.TabIndex = 1;
            noteCategoryCaptionLabel.Text = "Category:";
            // 
            // noteNameLabel
            // 
            noteNameLabel.AutoSize = true;
            noteNameLabel.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            noteNameLabel.Location = new Point(22, 20);
            noteNameLabel.Margin = new Padding(4, 0, 4, 0);
            noteNameLabel.Name = "noteNameLabel";
            noteNameLabel.Size = new Size(275, 45);
            noteNameLabel.TabIndex = 0;
            noteNameLabel.Text = "noteNameLabel";
            // 
            // addNoteToolTip
            // 
            addNoteToolTip.OwnerDraw = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 901);
            Controls.Add(mainContainer);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Margin = new Padding(4);
            MinimumSize = new Size(1494, 946);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteApp";
            Load += MainForm_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            mainContainer.Panel1.ResumeLayout(false);
            mainContainer.Panel1.PerformLayout();
            mainContainer.Panel2.ResumeLayout(false);
            mainContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainContainer).EndInit();
            mainContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addNoteToolStripMenuItem;
        private ToolStripMenuItem editNoteToolStripMenuItem;
        private ToolStripMenuItem deleteNoteToolStripMenuItem;
        private SplitContainer mainContainer;
        private Label categoriesCbLabel;
        private ComboBox categoriesComboBox;
        private Button addNoteButton;
        private ListBox notesListBox;
        private Button deleteNoteButton;
        private Button editNoteButton;
        private ToolTip addNoteToolTip;
        private Label noteNameLabel;
        private Label noteCategoryCaptionLabel;
        private Label noteCategoryLabel;
        private DateTimePicker noteCreateDateTimePicker;
        private Label noteCreateDateLabel;
        private DateTimePicker noteModifyDateTimePicker;
        private Label noteModifyLabel;
        private TextBox NoteTextBox;
    }
}
