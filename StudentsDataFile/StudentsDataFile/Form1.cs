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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'students_dbDataSet.Information' table. You can move, or remove it, as needed.
            this.informationTableAdapter.Fill(this.students_dbDataSet.Information);

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Form form_search = new Search();
            form_search.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            informationTableAdapter.Update(students_dbDataSet);
        }
    }
}
