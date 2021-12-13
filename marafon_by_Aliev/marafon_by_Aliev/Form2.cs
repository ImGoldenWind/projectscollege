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
    public partial class Form2 : Form
    {
        float BMR;
        float r;
        float v;
        float l;
        public Form2()
        {
            InitializeComponent();
        }

        private void Rasschitat_Click(object sender, EventArgs e)
        {
            r= float.Parse(rost.Text);
            v = float.Parse(ves.Text);
            l = float.Parse(let.Text);
            BMR = (float)(66 + (13.7 * l) + (5 * r) - (6.8 * v));
            label6.Text = BMR.ToString();
            label13.Text = (BMR * 1.2).ToString("##.##");
            label14.Text = (BMR * 1.375).ToString("##.##");
            label15.Text = (BMR * 1.55).ToString("##.##");
            label16.Text = (BMR * 1.725).ToString("##.##");
            label17.Text = (BMR * 1.9).ToString("##.##");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ves.Clear();
            rost.Clear();
            let.Clear();
            label6.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }
    }
}