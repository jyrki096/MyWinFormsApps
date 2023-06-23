namespace GeniyIdiotWinFormsApp
{
    partial class AddNewQuestionForm
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
            questionPointerLabel = new Label();
            answerPointerLabel = new Label();
            inputQuestionTextBox = new TextBox();
            inputAnswerTextBox = new TextBox();
            addButton = new Button();
            declineButton = new Button();
            SuspendLayout();
            // 
            // questionPointerLabel
            // 
            questionPointerLabel.AutoSize = true;
            questionPointerLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            questionPointerLabel.Location = new Point(12, 24);
            questionPointerLabel.Name = "questionPointerLabel";
            questionPointerLabel.Size = new Size(110, 17);
            questionPointerLabel.TabIndex = 0;
            questionPointerLabel.Text = "Введите вопрос:";
            // 
            // answerPointerLabel
            // 
            answerPointerLabel.AutoSize = true;
            answerPointerLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            answerPointerLabel.Location = new Point(12, 84);
            answerPointerLabel.Name = "answerPointerLabel";
            answerPointerLabel.Size = new Size(103, 17);
            answerPointerLabel.TabIndex = 1;
            answerPointerLabel.Text = "Введите ответ:";
            // 
            // inputQuestionTextBox
            // 
            inputQuestionTextBox.Location = new Point(128, 22);
            inputQuestionTextBox.Name = "inputQuestionTextBox";
            inputQuestionTextBox.Size = new Size(523, 23);
            inputQuestionTextBox.TabIndex = 2;
            // 
            // inputAnswerTextBox
            // 
            inputAnswerTextBox.Location = new Point(128, 82);
            inputAnswerTextBox.Name = "inputAnswerTextBox";
            inputAnswerTextBox.Size = new Size(118, 23);
            inputAnswerTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            addButton.Location = new Point(201, 122);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // declineButton
            // 
            declineButton.Location = new Point(388, 122);
            declineButton.Name = "declineButton";
            declineButton.Size = new Size(75, 23);
            declineButton.TabIndex = 5;
            declineButton.Text = "Отменить";
            declineButton.UseVisualStyleBackColor = true;
            declineButton.Click += declineButton_Click;
            // 
            // AddNewQuestionForm
            // 
            AcceptButton = addButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = declineButton;
            ClientSize = new Size(670, 154);
            Controls.Add(declineButton);
            Controls.Add(addButton);
            Controls.Add(inputAnswerTextBox);
            Controls.Add(inputQuestionTextBox);
            Controls.Add(answerPointerLabel);
            Controls.Add(questionPointerLabel);
            KeyPreview = true;
            Name = "AddNewQuestionForm";
            Text = "Добавление нового вопроса";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionPointerLabel;
        private Label answerPointerLabel;
        private TextBox inputQuestionTextBox;
        private TextBox inputAnswerTextBox;
        private Button addButton;
        private Button declineButton;
    }
}