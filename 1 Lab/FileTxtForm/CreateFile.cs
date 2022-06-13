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
    public partial class CreateFile : Form
    {
        FileTxt.Directory directory = new FileTxt.Directory();
        TxtFile file = new TxtFile();
        public CreateFile()
        {
            InitializeComponent();
        }

        private void directoryButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            MessageBox.Show("Выберите директорию.");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                directory.Path = dialog.SelectedPath;
            }
            file.Create(textBoxName.Text, textBoxCreator.Text, directory);
            FileForm form = new FileForm(file);
            form.ShowDialog();
            Close();
        }

        private void CreateFile_Load(object sender, EventArgs e)
        {

        }
    }
}
