namespace StudentsDataFile
{
    partial class Search
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
            this.btn_search2 = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_average = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.students_dbDataSet = new StudentsDataFile.students_dbDataSet();
            this.informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informationTableAdapter = new StudentsDataFile.students_dbDataSetTableAdapters.InformationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.students_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search2
            // 
            this.btn_search2.Location = new System.Drawing.Point(73, 252);
            this.btn_search2.Name = "btn_search2";
            this.btn_search2.Size = new System.Drawing.Size(100, 23);
            this.btn_search2.TabIndex = 0;
            this.btn_search2.Text = "جستجو";
            this.btn_search2.UseVisualStyleBackColor = true;
            this.btn_search2.Click += new System.EventHandler(this.btn_search2_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(203, 77);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_id.Size = new System.Drawing.Size(82, 13);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "کد دانش آموزی :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(194, 134);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_name.Size = new System.Drawing.Size(91, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "نام نام خانوادگی :";
            // 
            // lbl_average
            // 
            this.lbl_average.AutoSize = true;
            this.lbl_average.Location = new System.Drawing.Point(209, 171);
            this.lbl_average.Name = "lbl_average";
            this.lbl_average.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_average.Size = new System.Drawing.Size(76, 13);
            this.lbl_average.TabIndex = 3;
            this.lbl_average.Text = "میانگین نمرات :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationBindingSource, "Name", true));
            this.label4.Location = new System.Drawing.Point(73, 134);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationBindingSource, "Average", true));
            this.label5.Location = new System.Drawing.Point(73, 164);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 5;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(73, 74);
            this.txt_id.Name = "txt_id";
            this.txt_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 6;
            // 
            // students_dbDataSet
            // 
            this.students_dbDataSet.DataSetName = "students_dbDataSet";
            this.students_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationBindingSource
            // 
            this.informationBindingSource.DataMember = "Information";
            this.informationBindingSource.DataSource = this.students_dbDataSet;
            // 
            // informationTableAdapter
            // 
            this.informationTableAdapter.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 305);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_average);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_search2);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.students_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search2;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_average;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private students_dbDataSet students_dbDataSet;
        private System.Windows.Forms.BindingSource informationBindingSource;
        private students_dbDataSetTableAdapters.InformationTableAdapter informationTableAdapter;
    }
}