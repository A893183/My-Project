using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture3_Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvSalary.Rows.Add(4);

            dgvSalary.Rows[0].HeaderCell.Value = "June";
            dgvSalary.Rows[1].HeaderCell.Value = "July";
            dgvSalary.Rows[2].HeaderCell.Value = "August";
            dgvSalary.Rows[3].HeaderCell.Value = "September";


            //Populate DataGridView

            dgvSalary[0, 0].Value = 10;
            dgvSalary[0, 1].Value = 50;
            dgvSalary[0, 2].Value = 35;
            dgvSalary[0, 3].Value = 20;

            dgvSalary[1, 0].Value = 5;
            dgvSalary[1, 1].Value = 25;
            dgvSalary[1, 2].Value = 45;
            dgvSalary[1, 3].Value = 30;

            dgvSalary[2, 0].Value = 15;
            dgvSalary[2, 1].Value = 30;
            dgvSalary[2, 2].Value = 25;
            dgvSalary[2, 3].Value = 10;

            dgvSalary[3, 0].Value = 20;
            dgvSalary[3, 1].Value = 15;
            dgvSalary[3, 2].Value = 40;
            dgvSalary[3, 3].Value = 56;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int juneRowsSum = 0;

            for (i = 0; i < dgvSalary.Columns.Count; i++)
            {
                juneRowsSum += Convert.ToInt32(dgvSalary[i, 0].Value);
            }
            MessageBox.Show(" The total rainfall in the years is:" + Convert.ToString(juneRowsSum));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            int col2013 = 0;

            for (i = 0; i < dgvSalary.Rows.Count; i++)
            {
                col2013 += Convert.ToInt32(dgvSalary[1, i].Value);
            }
            MessageBox.Show("the total rainfall in 2013 was: " + Convert.ToString(col2013));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
                int Sum = 0;

            for(i=0; i<dgvSalary.Columns.Count; i++)
            {  for ( int j = 0; j<dgvSalary.Rows.Count-1; j++)
                { Sum += Convert.ToInt32(dgvSalary[i, j].Value);
                }

            }
            MessageBox.Show("the total rainfall is:" + Convert.ToString(Sum));
        }
    }
}
