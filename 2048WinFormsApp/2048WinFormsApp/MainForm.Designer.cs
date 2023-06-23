namespace _2048WinFormsApp
{
    partial class MainForm : Form
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
            scorePointerLabel = new Label();
            scoreLabel = new Label();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            newGameMenuButton = new ToolStripMenuItem();
            resultsMenuItem = new ToolStripMenuItem();
            rulesMenuButton = new ToolStripMenuItem();
            exitMenuButton = new ToolStripMenuItem();
            bestScorePointerLabel = new Label();
            bestScoreLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // scorePointerLabel
            // 
            scorePointerLabel.AutoSize = true;
            scorePointerLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            scorePointerLabel.Location = new Point(12, 24);
            scorePointerLabel.Name = "scorePointerLabel";
            scorePointerLabel.Size = new Size(39, 15);
            scorePointerLabel.TabIndex = 0;
            scorePointerLabel.Text = "Счёт:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.Location = new Point(57, 24);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(14, 15);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(310, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameMenuButton, resultsMenuItem, rulesMenuButton, exitMenuButton });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // newGameMenuButton
            // 
            newGameMenuButton.Name = "newGameMenuButton";
            newGameMenuButton.Size = new Size(136, 22);
            newGameMenuButton.Text = "Новая игра";
            newGameMenuButton.Click += newGameMenuButton_Click;
            // 
            // resultsMenuItem
            // 
            resultsMenuItem.Name = "resultsMenuItem";
            resultsMenuItem.Size = new Size(136, 22);
            resultsMenuItem.Text = "Результаты";
            resultsMenuItem.Click += resultsMenuItem_Click;
            // 
            // rulesMenuButton
            // 
            rulesMenuButton.Name = "rulesMenuButton";
            rulesMenuButton.Size = new Size(136, 22);
            rulesMenuButton.Text = "Правила";
            rulesMenuButton.Click += rulesMenuButton_Click;
            // 
            // exitMenuButton
            // 
            exitMenuButton.Name = "exitMenuButton";
            exitMenuButton.Size = new Size(136, 22);
            exitMenuButton.Text = "Выход";
            exitMenuButton.Click += exitMenuButton_Click;
            // 
            // bestScorePointerLabel
            // 
            bestScorePointerLabel.AutoSize = true;
            bestScorePointerLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bestScorePointerLabel.Location = new Point(200, 24);
            bestScorePointerLabel.Name = "bestScorePointerLabel";
            bestScorePointerLabel.Size = new Size(51, 15);
            bestScorePointerLabel.TabIndex = 3;
            bestScorePointerLabel.Text = "Рекорд:";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bestScoreLabel.Location = new Point(253, 24);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(14, 15);
            bestScoreLabel.TabIndex = 4;
            bestScoreLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(310, 323);
            Controls.Add(bestScoreLabel);
            Controls.Add(bestScorePointerLabel);
            Controls.Add(scoreLabel);
            Controls.Add(scorePointerLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "2048";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label scorePointerLabel;
        private Label scoreLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem newGameMenuButton;
        private ToolStripMenuItem rulesMenuButton;
        private ToolStripMenuItem exitMenuButton;
        private ToolStripMenuItem resultsMenuItem;
        private Label bestScorePointerLabel;
        private Label bestScoreLabel;
    }
}