﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTxtForm
{
    public partial class InputString : Form
    {
        public string Value { get; set; } = "";
        public InputString(string labelText)
        {
            InitializeComponent();
            label1.Text = labelText;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Value = textBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
