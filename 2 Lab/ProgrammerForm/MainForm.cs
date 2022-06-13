using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgrammerModel;

namespace ProgrammerForm
{
    public partial class MainForm : Form
    {
        Programmer programmer;
        ProgrammerChild programmerChild;
        public MainForm(Programmer programmer, ProgrammerChild programmerChild)
        {
            InitializeComponent();
            this.programmer = programmer;
            this.programmerChild = programmerChild;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            textBoxProgramer.Text = programmer.ToString();
        }

        private void buttonInfoChild_Click(object sender, EventArgs e)
        {
            textBoxProgramerChild.Text = programmerChild.ToString();
        }

        private void buttonQuallity_Click(object sender, EventArgs e)
        {
            MessageBox.Show(programmer.Quallity().ToString());
        }

        private void buttonQuallityChild_Click(object sender, EventArgs e)
        {
            MessageBox.Show(programmerChild.Quallity().ToString());
        }
    }
}
