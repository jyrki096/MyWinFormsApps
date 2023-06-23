namespace Diffusion
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
            timer1 = new System.Windows.Forms.Timer(components);
            leftRedPointLabel = new Label();
            leftBluePointLabel = new Label();
            upRedPointLabel = new Label();
            rightRedPointLabel = new Label();
            downRedPointLabel = new Label();
            upBluePointLabel = new Label();
            downBluePointLabel = new Label();
            rightBluePointLabel = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // leftRedPointLabel
            // 
            leftRedPointLabel.AutoSize = true;
            leftRedPointLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            leftRedPointLabel.ForeColor = Color.Red;
            leftRedPointLabel.Location = new Point(8, 154);
            leftRedPointLabel.Name = "leftRedPointLabel";
            leftRedPointLabel.Size = new Size(19, 21);
            leftRedPointLabel.TabIndex = 0;
            leftRedPointLabel.Text = "0";
            // 
            // leftBluePointLabel
            // 
            leftBluePointLabel.AutoSize = true;
            leftBluePointLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            leftBluePointLabel.ForeColor = Color.Blue;
            leftBluePointLabel.Location = new Point(8, 276);
            leftBluePointLabel.Name = "leftBluePointLabel";
            leftBluePointLabel.Size = new Size(19, 21);
            leftBluePointLabel.TabIndex = 1;
            leftBluePointLabel.Text = "0";
            // 
            // upRedPointLabel
            // 
            upRedPointLabel.AutoSize = true;
            upRedPointLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            upRedPointLabel.ForeColor = Color.Red;
            upRedPointLabel.Location = new Point(476, 9);
            upRedPointLabel.Name = "upRedPointLabel";
            upRedPointLabel.Size = new Size(19, 21);
            upRedPointLabel.TabIndex = 2;
            upRedPointLabel.Text = "0";
            // 
            // rightRedPointLabel
            // 
            rightRedPointLabel.AutoSize = true;
            rightRedPointLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rightRedPointLabel.ForeColor = Color.Red;
            rightRedPointLabel.Location = new Point(769, 154);
            rightRedPointLabel.Name = "rightRedPointLabel";
            rightRedPointLabel.Size = new Size(19, 21);
            rightRedPointLabel.TabIndex = 3;
            rightRedPointLabel.Text = "0";
            // 
            // downRedPointLabel
            // 
            downRedPointLabel.AutoSize = true;
            downRedPointLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            downRedPointLabel.ForeColor = Color.Red;
            downRedPointLabel.Location = new Point(476, 420);
            downRedPointLabel.Name = "downRedPointLabel";
            downRedPointLabel.Size = new Size(19, 21);
            downRedPointLabel.TabIndex = 4;
            downRedPointLabel.Text = "0";
            // 
            // upBluePointLabel
            // 
            upBluePointLabel.AutoSize = true;
            upBluePointLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            upBluePointLabel.ForeColor = Color.Blue;
            upBluePointLabel.Location = new Point(318, 9);
            upBluePointLabel.Name = "upBluePointLabel";
            upBluePointLabel.Size = new Size(19, 21);
            upBluePointLabel.TabIndex = 5;
            upBluePointLabel.Text = "0";
            // 
            // downBluePointLabel
            // 
            downBluePointLabel.AutoSize = true;
            downBluePointLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            downBluePointLabel.ForeColor = Color.Blue;
            downBluePointLabel.Location = new Point(318, 420);
            downBluePointLabel.Name = "downBluePointLabel";
            downBluePointLabel.Size = new Size(19, 21);
            downBluePointLabel.TabIndex = 6;
            downBluePointLabel.Text = "0";
            // 
            // rightBluePointLabel
            // 
            rightBluePointLabel.AutoSize = true;
            rightBluePointLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rightBluePointLabel.ForeColor = Color.Blue;
            rightBluePointLabel.Location = new Point(769, 276);
            rightBluePointLabel.Name = "rightBluePointLabel";
            rightBluePointLabel.Size = new Size(19, 21);
            rightBluePointLabel.TabIndex = 7;
            rightBluePointLabel.Text = "0";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rightBluePointLabel);
            Controls.Add(downBluePointLabel);
            Controls.Add(upBluePointLabel);
            Controls.Add(downRedPointLabel);
            Controls.Add(rightRedPointLabel);
            Controls.Add(upRedPointLabel);
            Controls.Add(leftBluePointLabel);
            Controls.Add(leftRedPointLabel);
            Name = "mainForm";
            Text = "Диффузия";
            Load += mainForm_Load;
            MouseClick += mainForm_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label leftRedPointLabel;
        private Label leftBluePointLabel;
        private Label upRedPointLabel;
        private Label rightRedPointLabel;
        private Label downRedPointLabel;
        private Label upBluePointLabel;
        private Label downBluePointLabel;
        private Label rightBluePointLabel;
    }
}