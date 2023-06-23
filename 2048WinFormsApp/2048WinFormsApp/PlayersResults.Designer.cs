namespace _2048WinFormsApp
{
    partial class PlayersResults
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
            resultTable = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultTable).BeginInit();
            SuspendLayout();
            // 
            // resultTable
            // 
            resultTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            resultTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultTable.Columns.AddRange(new DataGridViewColumn[] { Name, Result });
            resultTable.Location = new Point(12, 12);
            resultTable.Name = "resultTable";
            resultTable.RowTemplate.Height = 25;
            resultTable.Size = new Size(242, 167);
            resultTable.TabIndex = 0;
            // 
            // Name
            // 
            Name.HeaderText = "Имя";
            Name.Name = "Name";
            // 
            // Result
            // 
            Result.HeaderText = "Результат";
            Result.Name = "Result";
            // 
            // PlayersResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 353);
            Controls.Add(resultTable);
            Text = "PlayersResults";
            Load += PlayersResults_Load;
            ((System.ComponentModel.ISupportInitialize)resultTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultTable;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Result;
    }
}