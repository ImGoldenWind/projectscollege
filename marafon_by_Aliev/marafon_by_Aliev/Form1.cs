using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marafon_by_Gulov
{
    public partial class Form1 : Form
    {
        float index;
        float r;
        float v;

        public Form1()
        {
            InitializeComponent();
        }

        private void Rasschitat_Click(object sender, EventArgs e)
        {
            r = float.Parse(rost.Text);
            v = float.Parse(ves.Text);
            r = r / 100;
            index = v / (r * r);
            otvet.Text = index.ToString();
            trackBar1.Value = (int)index;
            if (index < 18.5)
               { pictureBox4.Image = Image.FromFile(@"C:\Users\student\source\repos\marafon_by_Gulov\marafon_by_Gulov\Resoures\bmi-underweight-icon.png"); otvetik.Text = "Недостаточный"; }
            else if (index < 25)
               { pictureBox4.Image = Image.FromFile(@"C:\Users\student\source\repos\marafon_by_Gulov\marafon_by_Gulov\Resoures\bmi-healthy-icon.png"); otvetik.Text = "Здоровый"; }
            else if (index < 30)
               { pictureBox4.Image = Image.FromFile(@"C:\Users\student\source\repos\marafon_by_Gulov\marafon_by_Gulov\Resoures\bmi-obese-icon.png"); otvetik.Text = "Избыточный"; }
            else { pictureBox4.Image = Image.FromFile(@"C:\Users\student\source\repos\marafon_by_Gulov\marafon_by_Gulov\Resoures\bmi-overweight-icon.png"); otvetik.Text = "Ожирение"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ves.Clear();
            rost.Clear();
            otvetik.Text = "";
            otvet.Text = "";
            pictureBox4 = null;
            trackBar1.Value = 40;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox3.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }
    }
}