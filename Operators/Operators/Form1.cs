using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Int32 txtFirstNumber;
            Int32 txtSecondNumber;
            Int32 txtRezultat;

           Int32.TryParse(this.txtFirstNumber.Text, out txtFirstNumber);
           Int32.TryParse(this.txtSecondNumber.Text, out txtSecondNumber);

            txtRezultat = txtFirstNumber + txtSecondNumber;
            this.txtRezultat.Text = txtRezultat.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Int32 txtFirstNumber;
            Int32 txtSecondNumber;
            Int32 txtRezultat;

            Int32.TryParse(this.txtFirstNumber.Text, out txtFirstNumber);
            Int32.TryParse(this.txtSecondNumber.Text, out txtSecondNumber);

            txtRezultat = txtFirstNumber - txtSecondNumber;
            this.txtRezultat.Text = txtRezultat.ToString();
        }

        private void btnMnozenje_Click(object sender, EventArgs e)
        {
            Int32 txtFirstNumber;
            Int32 txtSecondNumber;
            Int32 txtRezultat;

            Int32.TryParse(this.txtFirstNumber.Text, out txtFirstNumber);
            Int32.TryParse(this.txtSecondNumber.Text, out txtSecondNumber);

            txtRezultat = txtFirstNumber * txtSecondNumber;
            this.txtRezultat.Text = txtRezultat.ToString();
        }

        private void btnDelenje_Click(object sender, EventArgs e)
        {
            Int32 txtFirstNumber;
            Int32 txtSecondNumber;
            Int32 txtRezultat;

            Int32.TryParse(this.txtFirstNumber.Text, out txtFirstNumber);
            Int32.TryParse(this.txtSecondNumber.Text, out txtSecondNumber);

            txtRezultat = txtFirstNumber / txtSecondNumber;
            this.txtRezultat.Text = txtRezultat.ToString();
        }
    }
}
