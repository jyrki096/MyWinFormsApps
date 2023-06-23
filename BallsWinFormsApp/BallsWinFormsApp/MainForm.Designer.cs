namespace BallsWinFormsApp
{
    partial class MainForm

    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>я
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
            drawAndMoveManyBallsButton = new Button();
            stopAllBallsButton = new Button();
            RetryButton = new Button();
            SuspendLayout();
            // 
            // drawAndMoveManyBallsButton
            // 
            drawAndMoveManyBallsButton.Location = new Point(469, 12);
            drawAndMoveManyBallsButton.Name = "drawAndMoveManyBallsButton";
            drawAndMoveManyBallsButton.Size = new Size(188, 23);
            drawAndMoveManyBallsButton.TabIndex = 0;
            drawAndMoveManyBallsButton.Text = "Нарисовать много шариков";
            drawAndMoveManyBallsButton.UseVisualStyleBackColor = true;
            drawAndMoveManyBallsButton.Click += DrawAndMoveManyBallsButton_Click;
            // 
            // stopAllBallsButton
            // 
            stopAllBallsButton.Location = new Point(663, 12);
            stopAllBallsButton.Name = "stopAllBallsButton";
            stopAllBallsButton.Size = new Size(125, 23);
            stopAllBallsButton.TabIndex = 1;
            stopAllBallsButton.Text = "Остановить все";
            stopAllBallsButton.UseVisualStyleBackColor = true;
            stopAllBallsButton.Click += StopAllBallsButton_Click;
            // 
            // RetryButton
            // 
            RetryButton.Location = new Point(663, 41);
            RetryButton.Name = "RetryButton";
            RetryButton.Size = new Size(125, 23);
            RetryButton.TabIndex = 2;
            RetryButton.Text = "Начать сначала";
            RetryButton.UseVisualStyleBackColor = true;
            RetryButton.Click += RetryButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RetryButton);
            Controls.Add(stopAllBallsButton);
            Controls.Add(drawAndMoveManyBallsButton);
            Name = "MainForm";
            Text = "Шарики";
            MouseDoubleClick += MainForm_MouseDoubleClick;
            ResumeLayout(false);
        }

        #endregion

        private Button drawAndMoveManyBallsButton;
        private Button stopAllBallsButton;
        private Button RetryButton;
    }
}