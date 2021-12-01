using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataFunctions dataObj = new lab2.DataFunctions();
            string SQL_Slect = "Select * from city";
            dataGridView1.DataSource = dataObj.getData(SQL_Slect);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataFunctions dataObj = new lab2.DataFunctions();
            string SQL_Join = "Select * from uni inner join city on uni.cityId=city.cityId";
            dataGridView1.DataSource = dataObj.getData(SQL_Join);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataFunctions dataObj = new lab2.DataFunctions();
            string SQL_Join = "Select * from Course inner join sr on Course.courseid=sr.courseid";
            dataGridView1.DataSource = dataObj.getData(SQL_Join);
        }
    }
}
