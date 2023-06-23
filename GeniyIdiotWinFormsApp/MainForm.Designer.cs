namespace GeniyIdiotWinFormsApp
{
    partial class mainForm
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
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            userTextBox = new TextBox();
            nextButton = new Button();
            menuStrip1 = new MenuStrip();
            menuStrip = new ToolStripMenuItem();
            restartButton = new ToolStripMenuItem();
            addNewQuestionButton = new ToolStripMenuItem();
            questionRemoveButton = new ToolStripMenuItem();
            showResultsButton = new ToolStripMenuItem();
            exitButton = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            timerText = new Label();
            retry = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            questionNumberLabel.Location = new Point(27, 36);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(130, 27);
            questionNumberLabel.TabIndex = 0;
            questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            questionTextLabel.Location = new Point(27, 97);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(126, 21);
            questionTextLabel.TabIndex = 1;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(31, 153);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(178, 23);
            userTextBox.TabIndex = 2;
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            nextButton.ImageKey = "(none)";
            nextButton.Location = new Point(31, 214);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(108, 32);
            nextButton.TabIndex = 3;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(693, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip
            // 
            menuStrip.DropDownItems.AddRange(new ToolStripItem[] { restartButton, addNewQuestionButton, questionRemoveButton, showResultsButton, retry, exitButton });
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(53, 20);
            menuStrip.Text = "Меню";
            // 
            // restartButton
            // 
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(251, 22);
            restartButton.Text = "Новая игра";
            restartButton.Click += restartButton_Click;
            // 
            // addNewQuestionButton
            // 
            addNewQuestionButton.Name = "addNewQuestionButton";
            addNewQuestionButton.Size = new Size(251, 22);
            addNewQuestionButton.Text = "Добавить новый вопрос";
            addNewQuestionButton.Click += addNewQuestionButton_Click;
            // 
            // questionRemoveButton
            // 
            questionRemoveButton.Name = "questionRemoveButton";
            questionRemoveButton.Size = new Size(251, 22);
            questionRemoveButton.Text = "Удалить существующий вопрос";
            questionRemoveButton.Click += questionRemoveButton_Click;
            // 
            // showResultsButton
            // 
            showResultsButton.Name = "showResultsButton";
            showResultsButton.Size = new Size(251, 22);
            showResultsButton.Text = "Посмотреть результаты";
            showResultsButton.Click += showResultsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(251, 22);
            exitButton.Text = "Выйти";
            exitButton.Click += exitButton_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timerText
            // 
            timerText.AutoSize = true;
            timerText.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            timerText.Location = new Point(357, 58);
            timerText.Name = "timerText";
            timerText.Size = new Size(324, 17);
            timerText.TabIndex = 5;
            timerText.Text = "Осталось времени на ответ: {timeleft} секунд";
            // 
            // retry
            // 
            retry.Name = "retry";
            retry.Size = new Size(251, 22);
            retry.Text = "Начать заново";
            retry.Click += retry_Click;
            // 
            // mainForm
            // 
            AcceptButton = nextButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 274);
            Controls.Add(timerText);
            Controls.Add(nextButton);
            Controls.Add(userTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "mainForm";
            Text = "Гений Идиот";
            Load += mainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionNumberLabel;
        private TextBox userTextBox;
        private Button nextButton;
        public Label questionTextLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuStrip;
        private ToolStripMenuItem restartButton;
        private ToolStripMenuItem showResultsButton;
        private ToolStripMenuItem exitButton;
        private ToolStripMenuItem addNewQuestionButton;
        private ToolStripMenuItem questionRemoveButton;
        private System.Windows.Forms.Timer timer1;
        private Label timerText;
        private ToolStripMenuItem retry;
    }
}