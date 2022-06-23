namespace CourseProject
{
    partial class Results
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.resultsDataSet = new CourseProject.ResultsDataSet();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsTableAdapter = new CourseProject.ResultsDataSetTableAdapters.TestsTableAdapter();
            this.tableAdapterManager = new CourseProject.ResultsDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resultsDataSet1 = new CourseProject.ResultsDataSet1();
            this.testsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testsTableAdapter1 = new CourseProject.ResultsDataSet1TableAdapters.TestsTableAdapter();
            this.tableAdapterManager1 = new CourseProject.ResultsDataSet1TableAdapters.TableAdapterManager();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordspmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результаты";
            // 
            // resultsDataSet
            // 
            this.resultsDataSet.DataSetName = "ResultsDataSet";
            this.resultsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "Tests";
            this.testsBindingSource.DataSource = this.resultsDataSet;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TestsTableAdapter = this.testsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CourseProject.ResultsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.symbolsDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.errorsDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.wordspmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.testsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // resultsDataSet1
            // 
            this.resultsDataSet1.DataSetName = "ResultsDataSet1";
            this.resultsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testsBindingSource1
            // 
            this.testsBindingSource1.DataMember = "Tests";
            this.testsBindingSource1.DataSource = this.resultsDataSet1;
            // 
            // testsTableAdapter1
            // 
            this.testsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TestsTableAdapter = this.testsTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = CourseProject.ResultsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // symbolsDataGridViewTextBoxColumn
            // 
            this.symbolsDataGridViewTextBoxColumn.DataPropertyName = "symbols";
            this.symbolsDataGridViewTextBoxColumn.HeaderText = "symbols";
            this.symbolsDataGridViewTextBoxColumn.Name = "symbolsDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // errorsDataGridViewTextBoxColumn
            // 
            this.errorsDataGridViewTextBoxColumn.DataPropertyName = "errors";
            this.errorsDataGridViewTextBoxColumn.HeaderText = "errors";
            this.errorsDataGridViewTextBoxColumn.Name = "errorsDataGridViewTextBoxColumn";
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "language";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            // 
            // wordspmDataGridViewTextBoxColumn
            // 
            this.wordspmDataGridViewTextBoxColumn.DataPropertyName = "words_pm";
            this.wordspmDataGridViewTextBoxColumn.HeaderText = "words_pm";
            this.wordspmDataGridViewTextBoxColumn.Name = "wordspmDataGridViewTextBoxColumn";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(685, 485);
            this.MinimumSize = new System.Drawing.Size(685, 485);
            this.Name = "Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ResultsDataSet resultsDataSet;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private ResultsDataSetTableAdapters.TestsTableAdapter testsTableAdapter;
        private ResultsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ResultsDataSet1 resultsDataSet1;
        private System.Windows.Forms.BindingSource testsBindingSource1;
        private ResultsDataSet1TableAdapters.TestsTableAdapter testsTableAdapter1;
        private ResultsDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordspmDataGridViewTextBoxColumn;
    }
}