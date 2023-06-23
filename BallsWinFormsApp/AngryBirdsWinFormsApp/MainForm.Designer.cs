namespace AngryBirdsWinFormsApp
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
            startButton = new Button();
            restartButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            scorePointerLabel = new Label();
            scoreLabel = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(619, 33);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 0;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // restartButton
            // 
            restartButton.Location = new Point(713, 33);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(75, 23);
            restartButton.TabIndex = 1;
            restartButton.Text = "Рестарт";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Click += restartButton_Click;
            // 
            // timer
            // 
            timer.Interval = 15;
            timer.Tick += timer_Tick;
            // 
            // scorePointerLabel
            // 
            scorePointerLabel.AutoSize = true;
            scorePointerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scorePointerLabel.Location = new Point(12, 25);
            scorePointerLabel.Name = "scorePointerLabel";
            scorePointerLabel.Size = new Size(55, 21);
            scorePointerLabel.TabIndex = 2;
            scorePointerLabel.Text = "Очки:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.Location = new Point(73, 25);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(19, 21);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "0";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scoreLabel);
            Controls.Add(scorePointerLabel);
            Controls.Add(restartButton);
            Controls.Add(startButton);
            Name = "mainForm";
            Text = "Angry Birds";
            Load += mainForm_Load;
            MouseClick += mainForm_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button restartButton;
        private System.Windows.Forms.Timer timer;
        private Label scorePointerLabel;
        private Label scoreLabel;
    }
}