﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gulov_Megafonchik
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new Form2();
            Form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new Megafon();
            Form1.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void мегафонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new Megafon();
            Form1.Show();
        }

        private void билайнToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new Form2();
            Form2.Show();
        }
    }
}
