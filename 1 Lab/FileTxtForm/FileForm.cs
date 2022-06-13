using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileTxt;
namespace FileTxtForm
{
    public partial class FileForm : Form
    {
        TxtFile file;
        public FileForm(TxtFile txtFile)
        {
            InitializeComponent();
            file = txtFile;
            UpdateInformationAboutFile();
        }

        private void UpdateInformationAboutFile()
        {
            textBoxContent.Text = file.Data;
            textBoxCreator.Text = file.Creator;
            textBoxDirectory.Text = file.DirectoryInfo.Path;
            textBoxName.Text = file.Name;
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            InputString form = new InputString("Введите новое имя файла");
            if(form.ShowDialog() == DialogResult.OK)
            {
                file.Rename(form.Value);
                UpdateInformationAboutFile();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InputString form = new InputString("Введите текст для добавления в файл");
            if (form.ShowDialog() == DialogResult.OK)
            {
                file.AddContent(form.Value);
                UpdateInformationAboutFile();
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            file.IsExists = false;
            Close();
        }
    }
}
