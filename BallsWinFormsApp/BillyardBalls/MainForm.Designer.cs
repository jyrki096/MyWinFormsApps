namespace BillyardBalls
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
            upLabel = new Label();
            rightLabel = new Label();
            downLabel = new Label();
            leftLabel = new Label();
            SuspendLayout();
            // 
            // upLabel
            // 
            upLabel.AutoSize = true;
            upLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            upLabel.Location = new Point(382, 9);
            upLabel.Name = "upLabel";
            upLabel.Size = new Size(14, 15);
            upLabel.TabIndex = 0;
            upLabel.Text = "0";
            // 
            // rightLabel
            // 
            rightLabel.AutoSize = true;
            rightLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rightLabel.Location = new Point(745, 199);
            rightLabel.Name = "rightLabel";
            rightLabel.Size = new Size(14, 15);
            rightLabel.TabIndex = 1;
            rightLabel.Text = "0";
            // 
            // downLabel
            // 
            downLabel.AutoSize = true;
            downLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            downLabel.Location = new Point(382, 426);
            downLabel.Name = "downLabel";
            downLabel.Size = new Size(14, 15);
            downLabel.TabIndex = 2;
            downLabel.Text = "0";
            // 
            // leftLabel
            // 
            leftLabel.AutoSize = true;
            leftLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            leftLabel.Location = new Point(12, 199);
            leftLabel.Name = "leftLabel";
            leftLabel.Size = new Size(14, 15);
            leftLabel.TabIndex = 3;
            leftLabel.Text = "0";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 450);
            Controls.Add(leftLabel);
            Controls.Add(downLabel);
            Controls.Add(rightLabel);
            Controls.Add(upLabel);
            Name = "mainForm";
            Text = "Бильярдные шарики";
            Load += mainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label upLabel;
        private Label rightLabel;
        private Label downLabel;
        private Label leftLabel;
    }
}