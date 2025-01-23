namespace NoteAppUI;

partial class EditNoteForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNoteForm));
        noteNameTextBox = new TextBox();
        noteNameLabel = new Label();
        noteCategoryLabel = new Label();
        noteCategoryComboBox = new ComboBox();
        noteCreateLabel = new Label();
        noteCreateDateTimePicker = new DateTimePicker();
        noteModifyLabel = new Label();
        noteModifyDateTimePicker = new DateTimePicker();
        noteTextBox = new TextBox();
        okButton = new Button();
        cancelButton = new Button();
        noteNameErrorProvider = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)noteNameErrorProvider).BeginInit();
        SuspendLayout();
        // 
        // noteNameTextBox
        // 
        noteNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        noteNameTextBox.Location = new Point(124, 12);
        noteNameTextBox.Name = "noteNameTextBox";
        noteNameTextBox.Size = new Size(566, 27);
        noteNameTextBox.TabIndex = 0;
        noteNameTextBox.KeyDown += NoteNameTextBox_KeyDown;
        // 
        // noteNameLabel
        // 
        noteNameLabel.AutoSize = true;
        noteNameLabel.Location = new Point(24, 15);
        noteNameLabel.Name = "noteNameLabel";
        noteNameLabel.Size = new Size(41, 20);
        noteNameLabel.TabIndex = 1;
        noteNameLabel.Text = "Title:";
        // 
        // noteCategoryLabel
        // 
        noteCategoryLabel.AutoSize = true;
        noteCategoryLabel.Location = new Point(24, 72);
        noteCategoryLabel.Name = "noteCategoryLabel";
        noteCategoryLabel.Size = new Size(72, 20);
        noteCategoryLabel.TabIndex = 1;
        noteCategoryLabel.Text = "Category:";
        // 
        // noteCategoryComboBox
        // 
        noteCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        noteCategoryComboBox.FormattingEnabled = true;
        noteCategoryComboBox.Location = new Point(124, 68);
        noteCategoryComboBox.Name = "noteCategoryComboBox";
        noteCategoryComboBox.Size = new Size(252, 28);
        noteCategoryComboBox.TabIndex = 1;
        // 
        // noteCreateLabel
        // 
        noteCreateLabel.AutoSize = true;
        noteCreateLabel.Location = new Point(24, 128);
        noteCreateLabel.Name = "noteCreateLabel";
        noteCreateLabel.Size = new Size(64, 20);
        noteCreateLabel.TabIndex = 1;
        noteCreateLabel.Text = "Created:";
        // 
        // noteCreateDateTimePicker
        // 
        noteCreateDateTimePicker.CustomFormat = "dd.MM.yy HH:mm:ss";
        noteCreateDateTimePicker.Enabled = false;
        noteCreateDateTimePicker.Format = DateTimePickerFormat.Custom;
        noteCreateDateTimePicker.Location = new Point(124, 125);
        noteCreateDateTimePicker.Name = "noteCreateDateTimePicker";
        noteCreateDateTimePicker.Size = new Size(184, 27);
        noteCreateDateTimePicker.TabIndex = 3;
        // 
        // noteModifyLabel
        // 
        noteModifyLabel.AutoSize = true;
        noteModifyLabel.Location = new Point(346, 131);
        noteModifyLabel.Name = "noteModifyLabel";
        noteModifyLabel.Size = new Size(73, 20);
        noteModifyLabel.TabIndex = 1;
        noteModifyLabel.Text = "Modified:";
        // 
        // noteModifyDateTimePicker
        // 
        noteModifyDateTimePicker.CustomFormat = "dd.MM.yy HH:mm:ss";
        noteModifyDateTimePicker.Enabled = false;
        noteModifyDateTimePicker.Format = DateTimePickerFormat.Custom;
        noteModifyDateTimePicker.Location = new Point(446, 128);
        noteModifyDateTimePicker.Name = "noteModifyDateTimePicker";
        noteModifyDateTimePicker.Size = new Size(184, 27);
        noteModifyDateTimePicker.TabIndex = 3;
        // 
        // noteTextBox
        // 
        noteTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        noteTextBox.Location = new Point(12, 181);
        noteTextBox.Multiline = true;
        noteTextBox.Name = "noteTextBox";
        noteTextBox.ScrollBars = ScrollBars.Vertical;
        noteTextBox.Size = new Size(678, 340);
        noteTextBox.TabIndex = 2;
        // 
        // okButton
        // 
        okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        okButton.Location = new Point(446, 527);
        okButton.Name = "okButton";
        okButton.Size = new Size(114, 34);
        okButton.TabIndex = 3;
        okButton.Text = "OK";
        okButton.UseVisualStyleBackColor = true;
        okButton.Click += OkButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        cancelButton.Location = new Point(576, 527);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(114, 34);
        cancelButton.TabIndex = 4;
        cancelButton.Text = "Cancel";
        cancelButton.UseVisualStyleBackColor = true;
        // 
        // noteNameErrorProvider
        // 
        noteNameErrorProvider.ContainerControl = this;
        noteNameErrorProvider.RightToLeft = true;
        // 
        // EditNoteForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = cancelButton;
        ClientSize = new Size(702, 573);
        Controls.Add(cancelButton);
        Controls.Add(okButton);
        Controls.Add(noteTextBox);
        Controls.Add(noteModifyDateTimePicker);
        Controls.Add(noteCreateDateTimePicker);
        Controls.Add(noteModifyLabel);
        Controls.Add(noteCategoryComboBox);
        Controls.Add(noteCreateLabel);
        Controls.Add(noteCategoryLabel);
        Controls.Add(noteNameLabel);
        Controls.Add(noteNameTextBox);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(720, 620);
        Name = "EditNoteForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Add/Edit Note";
        ((System.ComponentModel.ISupportInitialize)noteNameErrorProvider).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox noteNameTextBox;
    private Label noteNameLabel;
    private Label noteCategoryLabel;
    private ComboBox noteCategoryComboBox;
    private Label noteCreateLabel;
    private DateTimePicker noteCreateDateTimePicker;
    private Label noteModifyLabel;
    private DateTimePicker noteModifyDateTimePicker;
    private TextBox noteTextBox;
    private Button okButton;
    private Button cancelButton;
    private ErrorProvider noteNameErrorProvider;
}