using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentLayer;

namespace DataBaseAdd.formularies
{
    public partial class FormStudent : Form
    {
        //NOTE
        private readonly B_Student student = new B_Student();

        public FormStudent()
        {
            InitializeComponent();
        }


        //METHOD
        private void ShowRegister()
        {
            dataGridView1.DataSource = student.ShowData();
        }
        private void FormStudent_Load(object sender, EventArgs e)
        {
            ShowRegister();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
