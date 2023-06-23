namespace GeniyIdiotWinFormsApp
{
    partial class RemoveQuestionForm
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
            questionTable = new DataGridView();
            questionNumber = new DataGridViewTextBoxColumn();
            questionText = new DataGridViewTextBoxColumn();
            deleteButton = new Button();
            declineButton = new Button();
            ((System.ComponentModel.ISupportInitialize)questionTable).BeginInit();
            SuspendLayout();
            // 
            // questionTable
            // 
            questionTable.AllowUserToAddRows = false;
            questionTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionTable.Columns.AddRange(new DataGridViewColumn[] { questionNumber, questionText });
            questionTable.Location = new Point(1, -2);
            questionTable.Name = "questionTable";
            questionTable.RowTemplate.Height = 25;
            questionTable.Size = new Size(695, 196);
            questionTable.TabIndex = 0;
            // 
            // questionNumber
            // 
            questionNumber.HeaderText = "Номер";
            questionNumber.Name = "questionNumber";
            questionNumber.Width = 50;
            // 
            // questionText
            // 
            questionText.HeaderText = "Вопросы";
            questionText.Name = "questionText";
            questionText.Width = 600;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(218, 245);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // declineButton
            // 
            declineButton.Location = new Point(386, 245);
            declineButton.Name = "declineButton";
            declineButton.Size = new Size(75, 23);
            declineButton.TabIndex = 4;
            declineButton.Text = "Отмена";
            declineButton.UseVisualStyleBackColor = true;
            declineButton.Click += declineButton_Click;
            // 
            // RemoveQuestionForm
            // 
            AcceptButton = deleteButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = declineButton;
            ClientSize = new Size(695, 294);
            Controls.Add(declineButton);
            Controls.Add(deleteButton);
            Controls.Add(questionTable);
            KeyPreview = true;
            Name = "RemoveQuestionForm";
            Text = "Удаление вопроса";
            ((System.ComponentModel.ISupportInitialize)questionTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView questionTable;
        private Button deleteButton;
        private Button declineButton;
        private DataGridViewTextBoxColumn questionNumber;
        private DataGridViewTextBoxColumn questionText;
    }
}