namespace GeniyIdiotWinFormsApp
{
    partial class UserNameForm
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
            namePointerLabel = new Label();
            userNameTextBox = new TextBox();
            okButton = new Button();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // namePointerLabel
            // 
            namePointerLabel.AutoSize = true;
            namePointerLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            namePointerLabel.Location = new Point(21, 104);
            namePointerLabel.Name = "namePointerLabel";
            namePointerLabel.Size = new Size(92, 17);
            namePointerLabel.TabIndex = 0;
            namePointerLabel.Text = "Введите имя:";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(159, 102);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(152, 23);
            userNameTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            okButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            okButton.Location = new Point(195, 175);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 36);
            okButton.TabIndex = 2;
            okButton.Text = "Начать";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(63, 38);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(352, 23);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Добро пожаловать в игру Гений Идиот";
            // 
            // UserNameForm
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 239);
            Controls.Add(titleLabel);
            Controls.Add(okButton);
            Controls.Add(userNameTextBox);
            Controls.Add(namePointerLabel);
            KeyPreview = true;
            Name = "UserNameForm";
            Text = "Добавление нового пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namePointerLabel;
        private TextBox userNameTextBox;
        private Button okButton;
        private Label titleLabel;
    }
}