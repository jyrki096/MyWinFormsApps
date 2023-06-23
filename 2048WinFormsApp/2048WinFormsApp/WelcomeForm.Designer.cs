namespace _2048WinFormsApp
{
    partial class WelcomeForm
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
            startButton = new Button();
            greetingLable = new Label();
            namePointerLable = new Label();
            playerNameTextBox = new TextBox();
            fourOnFourRadio = new RadioButton();
            eightOnEigthRadio = new RadioButton();
            sixOnSixRadio = new RadioButton();
            tenOnTenRadio = new RadioButton();
            sizeTableGroupBox = new GroupBox();
            sizeTableGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.Location = new Point(136, 328);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 32);
            startButton.TabIndex = 0;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // greetingLable
            // 
            greetingLable.AutoSize = true;
            greetingLable.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            greetingLable.Location = new Point(27, 31);
            greetingLable.Name = "greetingLable";
            greetingLable.Size = new Size(345, 26);
            greetingLable.TabIndex = 1;
            greetingLable.Text = "Добро пожаловать в игру 2048!";
            // 
            // namePointerLable
            // 
            namePointerLable.AutoSize = true;
            namePointerLable.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            namePointerLable.Location = new Point(104, 84);
            namePointerLable.Name = "namePointerLable";
            namePointerLable.Size = new Size(159, 21);
            namePointerLable.TabIndex = 2;
            namePointerLable.Text = "Введите ваше имя:";
            // 
            // playerNameTextBox
            // 
            playerNameTextBox.Location = new Point(116, 137);
            playerNameTextBox.Name = "playerNameTextBox";
            playerNameTextBox.Size = new Size(128, 23);
            playerNameTextBox.TabIndex = 3;
            // 
            // fourOnFourRadio
            // 
            fourOnFourRadio.AutoSize = true;
            fourOnFourRadio.Checked = true;
            fourOnFourRadio.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            fourOnFourRadio.Location = new Point(17, 24);
            fourOnFourRadio.Name = "fourOnFourRadio";
            fourOnFourRadio.Size = new Size(45, 19);
            fourOnFourRadio.TabIndex = 4;
            fourOnFourRadio.TabStop = true;
            fourOnFourRadio.Text = "4x4";
            fourOnFourRadio.UseVisualStyleBackColor = true;
            fourOnFourRadio.CheckedChanged += WelcomeForm_Load;
            // 
            // eightOnEigthRadio
            // 
            eightOnEigthRadio.AutoSize = true;
            eightOnEigthRadio.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            eightOnEigthRadio.Location = new Point(16, 71);
            eightOnEigthRadio.Name = "eightOnEigthRadio";
            eightOnEigthRadio.Size = new Size(45, 19);
            eightOnEigthRadio.TabIndex = 5;
            eightOnEigthRadio.Text = "8x8";
            eightOnEigthRadio.UseVisualStyleBackColor = true;
            // 
            // sixOnSixRadio
            // 
            sixOnSixRadio.AutoSize = true;
            sixOnSixRadio.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            sixOnSixRadio.Location = new Point(120, 22);
            sixOnSixRadio.Name = "sixOnSixRadio";
            sixOnSixRadio.Size = new Size(45, 19);
            sixOnSixRadio.TabIndex = 6;
            sixOnSixRadio.Text = "6x6";
            sixOnSixRadio.UseVisualStyleBackColor = true;
            // 
            // tenOnTenRadio
            // 
            tenOnTenRadio.AutoSize = true;
            tenOnTenRadio.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tenOnTenRadio.Location = new Point(120, 71);
            tenOnTenRadio.Name = "tenOnTenRadio";
            tenOnTenRadio.Size = new Size(59, 19);
            tenOnTenRadio.TabIndex = 7;
            tenOnTenRadio.Text = "10x10";
            tenOnTenRadio.UseVisualStyleBackColor = true;
            // 
            // sizeTableGroupBox
            // 
            sizeTableGroupBox.Controls.Add(fourOnFourRadio);
            sizeTableGroupBox.Controls.Add(sixOnSixRadio);
            sizeTableGroupBox.Controls.Add(tenOnTenRadio);
            sizeTableGroupBox.Controls.Add(eightOnEigthRadio);
            sizeTableGroupBox.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            sizeTableGroupBox.Location = new Point(88, 201);
            sizeTableGroupBox.Name = "sizeTableGroupBox";
            sizeTableGroupBox.Size = new Size(200, 100);
            sizeTableGroupBox.TabIndex = 9;
            sizeTableGroupBox.TabStop = false;
            sizeTableGroupBox.Text = "Размер поля";
            // 
            // WelcomeForm
            // 
            AcceptButton = startButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 372);
            Controls.Add(sizeTableGroupBox);
            Controls.Add(playerNameTextBox);
            Controls.Add(namePointerLable);
            Controls.Add(greetingLable);
            Controls.Add(startButton);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            FormClosing += WelcomeForm_FormClosing;
            Load += WelcomeForm_Load;
            Click += startButton_Click;
            sizeTableGroupBox.ResumeLayout(false);
            sizeTableGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label greetingLable;
        private Label namePointerLable;
        private TextBox playerNameTextBox;
        private RadioButton fourOnFourRadio;
        private RadioButton eightOnEigthRadio;
        private RadioButton sixOnSixRadio;
        private RadioButton tenOnTenRadio;
        private GroupBox sizeTableGroupBox;
    }
}