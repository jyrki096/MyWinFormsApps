namespace CatchMe2
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
            startButton = new Button();
            retryButton = new Button();
            scorePointerLabel = new Label();
            scoreLabel = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(553, 26);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 0;
            startButton.Text = "Старт";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // retryButton
            // 
            retryButton.Location = new Point(676, 26);
            retryButton.Name = "retryButton";
            retryButton.Size = new Size(112, 23);
            retryButton.TabIndex = 1;
            retryButton.Text = "Начать сначала";
            retryButton.UseVisualStyleBackColor = true;
            retryButton.Click += retryButton_Click;
            // 
            // scorePointerLabel
            // 
            scorePointerLabel.AutoSize = true;
            scorePointerLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            scorePointerLabel.Location = new Point(12, 26);
            scorePointerLabel.Name = "scorePointerLabel";
            scorePointerLabel.Size = new Size(41, 17);
            scorePointerLabel.TabIndex = 2;
            scorePointerLabel.Text = "Счёт:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.Location = new Point(59, 26);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(15, 17);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scoreLabel);
            Controls.Add(scorePointerLabel);
            Controls.Add(retryButton);
            Controls.Add(startButton);
            Name = "MainForm";
            Text = "Catch Me 2";
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button retryButton;
        private Label scorePointerLabel;
        private Label scoreLabel;
    }
}