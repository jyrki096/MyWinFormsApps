namespace GeniyIdiotWinFormsApp
{
    partial class UsersResultsForm
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
            name = new DataGridViewTextBoxColumn();
            rightAnswers = new DataGridViewTextBoxColumn();
            diagnosis = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultTable).BeginInit();
            SuspendLayout();
            // 
            // resultTable
            // 
            resultTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultTable.Columns.AddRange(new DataGridViewColumn[] { name, rightAnswers, diagnosis });
            resultTable.Location = new Point(-2, 1);
            resultTable.Name = "resultTable";
            resultTable.RowTemplate.Height = 25;
            resultTable.Size = new Size(345, 453);
            resultTable.TabIndex = 0;
            // 
            // name
            // 
            name.HeaderText = "Имя";
            name.Name = "name";
            // 
            // rightAnswers
            // 
            rightAnswers.HeaderText = "Количество верных ответов";
            rightAnswers.Name = "rightAnswers";
            // 
            // diagnosis
            // 
            diagnosis.HeaderText = "Диагноз";
            diagnosis.Name = "diagnosis";
            // 
            // UsersResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 450);
            Controls.Add(resultTable);
            Name = "UsersResultsForm";
            Text = "Результаты";
            ((System.ComponentModel.ISupportInitialize)resultTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultTable;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn rightAnswers;
        private DataGridViewTextBoxColumn diagnosis;
    }
}