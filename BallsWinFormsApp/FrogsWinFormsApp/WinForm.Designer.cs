namespace FrogsWinFormsApp
{
    partial class WinForm
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
            pictureBox1 = new PictureBox();
            congratsLabel = new Label();
            addTextLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WinPic;
            pictureBox1.Location = new Point(108, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // congratsLabel
            // 
            congratsLabel.AutoSize = true;
            congratsLabel.Font = new Font("Segoe Script", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            congratsLabel.Location = new Point(149, 198);
            congratsLabel.Name = "congratsLabel";
            congratsLabel.Size = new Size(123, 25);
            congratsLabel.TabIndex = 1;
            congratsLabel.Text = "Поздравляем!";
            // 
            // addTextLabel
            // 
            addTextLabel.AutoSize = true;
            addTextLabel.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addTextLabel.Location = new Point(38, 233);
            addTextLabel.Name = "addTextLabel";
            addTextLabel.RightToLeft = RightToLeft.No;
            addTextLabel.Size = new Size(336, 20);
            addTextLabel.TabIndex = 2;
            addTextLabel.Text = "Вы выиграли за оптимальное количество ходов!";
            // 
            // WinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 311);
            Controls.Add(addTextLabel);
            Controls.Add(congratsLabel);
            Controls.Add(pictureBox1);
            Name = "WinForm";
            Text = "WinForm";
            Load += WinForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label congratsLabel;
        private Label addTextLabel;
    }
}