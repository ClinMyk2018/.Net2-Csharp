using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3.T1.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void verifySinglePoint(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            verifySinglePoint(sender, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            verifySinglePoint(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double numOneDub;
            numOneDub = double.Parse(textBox1.Text);
            double numTwoDub;
            numTwoDub = double.Parse(textBox2.Text);

            MathedAdd add1 = new MathedAdd();                   //ADDING
            float numFloatA = (float) add1
            .DoMathed(numOneDub, numTwoDub);
            labelAdd.Text = numFloatA
            .ToString();

            MathedMultiply mult1 = new MathedMultiply();        //MULTIPLYING
            float numFloatM = (float) mult1
            .DoMathed(numOneDub, numTwoDub);
            labelMult.Text = numFloatM
            .ToString();

            MathedDivide div1 = new MathedDivide();              //DIVIDING
            float numFloatD = (float) div1
            .DoMathed(numOneDub, numTwoDub);
            labelDiv.Text = numFloatD
            .ToString();

            MathedSubtract sub1 = new MathedSubtract();         //SUBTRACTING
            float numFloatS = (float) sub1
            .DoMathed(numOneDub, numTwoDub);
            labelSub.Text = numFloatS
            .ToString();

        }
    }
}
