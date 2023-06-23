namespace FruitNinjaWinFormsApp
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
            timer = new System.Windows.Forms.Timer(components);
            startButton = new Button();
            scorePointerLabel = new Label();
            scoreLabel = new Label();
            retryButton = new Button();
            SuspendLayout();
            // 
            // timer
            // 
            timer.Interval = 500;
            timer.Tick += timer_Tick;
            // 
            // startButton
            // 
            startButton.Location = new Point(682, 32);
            startButton.Name = "startButton";
            startButton.Size = new Size(89, 23);
            startButton.TabIndex = 0;
            startButton.Text = "Старт";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // scorePointerLabel
            // 
            scorePointerLabel.AutoSize = true;
            scorePointerLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            scorePointerLabel.Location = new Point(12, 17);
            scorePointerLabel.Name = "scorePointerLabel";
            scorePointerLabel.Size = new Size(59, 25);
            scorePointerLabel.TabIndex = 1;
            scorePointerLabel.Text = "Счёт:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.Location = new Point(77, 17);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(23, 25);
            scoreLabel.TabIndex = 2;
            scoreLabel.Text = "0";
            // 
            // retryButton
            // 
            retryButton.Location = new Point(682, 79);
            retryButton.Name = "retryButton";
            retryButton.Size = new Size(89, 23);
            retryButton.TabIndex = 3;
            retryButton.Text = "Перезапуск";
            retryButton.UseVisualStyleBackColor = true;
            retryButton.Click += retryButton_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(retryButton);
            Controls.Add(scoreLabel);
            Controls.Add(scorePointerLabel);
            Controls.Add(startButton);
            Name = "mainForm";
            Text = "Fruit Ninja";
            Load += mainForm_Load;
            MouseMove += mainForm_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private Button startButton;
        private Label scorePointerLabel;
        private Label scoreLabel;
        private Button retryButton;
    }
}