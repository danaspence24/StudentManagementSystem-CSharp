namespace DanaSpence_LINQ
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPartition = new System.Windows.Forms.Button();
            this.btnAggregate = new System.Windows.Forms.Button();
            this.btnSetOps = new System.Windows.Forms.Button();
            this.dataGridViewStudents1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudents2 = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSortAsc = new System.Windows.Forms.Button();
            this.btnSortDesc = new System.Windows.Forms.Button();
            this.btnElementMethods = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtScore);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxDepartment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(423, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Student";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(95, 153);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(121, 20);
            this.txtScore.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Score";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(95, 106);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepartment.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Department";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(95, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(423, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(365, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Student to Table 1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(26, 236);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(371, 173);
            this.listBoxResults.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Results";
            // 
            // btnPartition
            // 
            this.btnPartition.Location = new System.Drawing.Point(26, 413);
            this.btnPartition.Name = "btnPartition";
            this.btnPartition.Size = new System.Drawing.Size(114, 23);
            this.btnPartition.TabIndex = 4;
            this.btnPartition.Text = "Partition";
            this.btnPartition.UseVisualStyleBackColor = true;
            this.btnPartition.Click += new System.EventHandler(this.btnPartition_Click);
            // 
            // btnAggregate
            // 
            this.btnAggregate.Location = new System.Drawing.Point(146, 413);
            this.btnAggregate.Name = "btnAggregate";
            this.btnAggregate.Size = new System.Drawing.Size(121, 23);
            this.btnAggregate.TabIndex = 5;
            this.btnAggregate.Text = "Aggregate";
            this.btnAggregate.UseVisualStyleBackColor = true;
            this.btnAggregate.Click += new System.EventHandler(this.btnAggregate_Click);
            // 
            // btnSetOps
            // 
            this.btnSetOps.Location = new System.Drawing.Point(273, 413);
            this.btnSetOps.Name = "btnSetOps";
            this.btnSetOps.Size = new System.Drawing.Size(117, 23);
            this.btnSetOps.TabIndex = 6;
            this.btnSetOps.Text = "Set Operations";
            this.btnSetOps.UseVisualStyleBackColor = true;
            this.btnSetOps.Click += new System.EventHandler(this.btnSetOps_Click);
            // 
            // dataGridViewStudents1
            // 
            this.dataGridViewStudents1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents1.Location = new System.Drawing.Point(26, 23);
            this.dataGridViewStudents1.Name = "dataGridViewStudents1";
            this.dataGridViewStudents1.Size = new System.Drawing.Size(371, 162);
            this.dataGridViewStudents1.TabIndex = 7;
            // 
            // dataGridViewStudents2
            // 
            this.dataGridViewStudents2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents2.Location = new System.Drawing.Point(423, 236);
            this.dataGridViewStudents2.Name = "dataGridViewStudents2";
            this.dataGridViewStudents2.Size = new System.Drawing.Size(365, 173);
            this.dataGridViewStudents2.TabIndex = 8;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(26, 191);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(61, 23);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSortAsc
            // 
            this.btnSortAsc.Location = new System.Drawing.Point(93, 191);
            this.btnSortAsc.Name = "btnSortAsc";
            this.btnSortAsc.Size = new System.Drawing.Size(94, 23);
            this.btnSortAsc.TabIndex = 10;
            this.btnSortAsc.Text = "Sort Ascending";
            this.btnSortAsc.UseVisualStyleBackColor = true;
            this.btnSortAsc.Click += new System.EventHandler(this.btnSortAsc_Click);
            // 
            // btnSortDesc
            // 
            this.btnSortDesc.Location = new System.Drawing.Point(193, 191);
            this.btnSortDesc.Name = "btnSortDesc";
            this.btnSortDesc.Size = new System.Drawing.Size(96, 23);
            this.btnSortDesc.TabIndex = 11;
            this.btnSortDesc.Text = "Sort Descending ";
            this.btnSortDesc.UseVisualStyleBackColor = true;
            this.btnSortDesc.Click += new System.EventHandler(this.btnSortDesc_Click);
            // 
            // btnElementMethods
            // 
            this.btnElementMethods.Location = new System.Drawing.Point(295, 191);
            this.btnElementMethods.Name = "btnElementMethods";
            this.btnElementMethods.Size = new System.Drawing.Size(102, 23);
            this.btnElementMethods.TabIndex = 12;
            this.btnElementMethods.Text = "Element Methods";
            this.btnElementMethods.UseVisualStyleBackColor = true;
            this.btnElementMethods.Click += new System.EventHandler(this.btnElementMethods_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnElementMethods);
            this.Controls.Add(this.btnSortDesc);
            this.Controls.Add(this.btnSortAsc);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dataGridViewStudents2);
            this.Controls.Add(this.dataGridViewStudents1);
            this.Controls.Add(this.btnSetOps);
            this.Controls.Add(this.btnAggregate);
            this.Controls.Add(this.btnPartition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPartition;
        private System.Windows.Forms.Button btnAggregate;
        private System.Windows.Forms.Button btnSetOps;
        private System.Windows.Forms.DataGridView dataGridViewStudents1;
        private System.Windows.Forms.DataGridView dataGridViewStudents2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSortAsc;
        private System.Windows.Forms.Button btnSortDesc;
        private System.Windows.Forms.Button btnElementMethods;
    }
}

