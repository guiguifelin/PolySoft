﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PolySoft
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

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDeriver_Click(object sender, EventArgs e)
        {
            string[] polynome = Polynome.GetPolynome(textFonction.Text);

            polynome = Polynome.Evaluate(polynome);

            textFonction.Clear();
            textFonction.Text = Polynome.ToString(polynome);
        }
    }
}
