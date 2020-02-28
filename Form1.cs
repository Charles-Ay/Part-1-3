using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_1_3
{

    public partial class frmHeight : Form
    {
        //#1
        string name;
        string age;
        int ageNum;
        string height;
        double heightNum;
        int life = 80;
        int total;
        double tallest = 2.36;
        double heightTotal;
        

        public frmHeight()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            age = txtAge.Text;
            height = txtHeight.Text;
            ageNum = System.Convert.ToInt32(age);
            heightNum = System.Convert.ToDouble(height);
            lblSubmit.Text = $"{name} you are {ageNum} years old and {heightNum} meters tall";
            total = life - ageNum;
            lblLife.Text = $"You have {total} more years to live on avrage";
            heightTotal = tallest - heightNum;
            heightTotal = Math.Round(heightTotal, 2);
            lblTallest.Text = $"you are {heightTotal} meters shorter than the tallest man";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void lblSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
