using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsDataFile
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btn_search2_Click(object sender, EventArgs e)
        {
            int find = informationBindingSource.Find("Id", txt_id.Text);
            if (find >= 0)
            {

                informationBindingSource.ResumeBinding();
                informationBindingSource.Position = find;

            }
            else
            {
                informationBindingSource.SuspendBinding();
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'students_dbDataSet.Information' table. You can move, or remove it, as needed.
            this.informationTableAdapter.Fill(this.students_dbDataSet.Information);
            informationBindingSource.SuspendBinding();
        }
    }
}
