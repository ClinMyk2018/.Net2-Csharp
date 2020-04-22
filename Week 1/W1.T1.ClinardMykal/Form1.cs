using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1.T1.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Click button and will display in Text Field
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            textBox1.Text = dog.Snoozing() + " " + dog.MakeSomeNoise();
            textBox2.Text = cat.Snoozing() + " " + cat.MakeSomeNoise();
        }
    }

    public class Animal //Base Class
    {
        public void Snoozing()
        {
        }

        public void MakeSomeNoise()
        {
        }
    }

    class Dog : Animal //First Inheritance
    {
        public new string MakeSomeNoise()
        {
            return "Barking Bark Bark";
        }

        public new string Snoozing()
        {
            return "Snorriiiinnng...... hmph squirrel";
        }
    }

    class Cat : Animal //Second Inheritance
    {
        public new string MakeSomeNoise()
        {
            return "Puuuuurrr, Meeeeooooow!";
        }

        public new string Snoozing()
        {
            return "Puuuuurrr, scratch don't wake me up";
        }
    }
}
