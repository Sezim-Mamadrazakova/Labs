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
    public partial class CreateClassesForm : Form
    {
        public CreateClassesForm()
        {
            InitializeComponent();
        }

        private void CreateClassesForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateClasses_Click(object sender, EventArgs e)
        {
            if (!CheckInt(textBoxLangCnt.Text) || !CheckInt(textBoxLangChild.Text))
                MessageBox.Show("Количество языков программирования должно быть целым числом", "Ошибка ввода", MessageBoxButtons.OK);
            else if (!CheckInt(textBoxProgCnt.Text) || !CheckInt(textBoxProgCntChild.Text))
                MessageBox.Show("Количество написанных программ должно быть целым числом", "Ошибка ввода", MessageBoxButtons.OK);
            else if (!CheckInt(textBoxRightProgCntChild.Text))
                MessageBox.Show("Количество правильно написанных программ должно быть целым числом", "Ошибка ввода", MessageBoxButtons.OK);
            else if (int.Parse(textBoxRightProgCntChild.Text) > int.Parse(textBoxProgCntChild.Text))
                MessageBox.Show("Количество правильно написанных программ не может привышать общее количество программ.", "Ошибка ввода", MessageBoxButtons.OK);
            else
            {

                Programmer programmer = new Programmer(
                    textBoxSurname.Text,
                    int.Parse(textBoxProgCnt.Text),
                    int.Parse(textBoxLangCnt.Text));

                ProgrammerChild programmerChild = new ProgrammerChild(
                     textBoxSurnameChild.Text,
                    int.Parse(textBoxProgCntChild.Text),
                    int.Parse(textBoxLangChild.Text),
                    int.Parse(textBoxRightProgCntChild.Text));

                MainForm mainForm = new MainForm(programmer, programmerChild);
                mainForm.ShowDialog();
                Close();
            }
        }

        private bool CheckInt(string str)
        {
            return int.TryParse(str,out int number);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
