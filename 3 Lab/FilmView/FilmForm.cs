using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmModels;

namespace FilmView
{
    public partial class FilmForm : Form
    {
        ComedyFilm film;
        private void UpdateFilmInformation()
        {
            textBoxCountry.Text = film.Country;
            textBoxDuration.Text = film.Duration.ToString();
            textBoxMoney.Text = film.Fees.ToString();
            textBoxProducer.Text = film.Producer;
            textBoxWatches.Text = film.CountOfWathes.ToString();
            textBoxName.Text = film.Name;
        }
        public FilmForm(IFilm film)
        {
            InitializeComponent();
            this.film = film is ComedyFilm ? film as ComedyFilm : throw new Exception();
            UpdateFilmInformation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputString inputStringForm = new InputString("Введите количество сцен.");
            int scenes;
            inputStringForm.ShowDialog();
            while (!int.TryParse(inputStringForm.Value, out scenes))
            {
                MessageBox.Show("Ошибка ввода, введите целое число!", "Ошибка", MessageBoxButtons.OK);
                inputStringForm.ShowDialog();
            }
            film.DeleteScene(scenes);
            UpdateFilmInformation();
        }

        private void FilmForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddWatch_Click(object sender, EventArgs e)
        {
            InputString inputStringForm = new InputString("Введите количество просмотров.");
            int watches;
            inputStringForm.ShowDialog();
            while (!int.TryParse(inputStringForm.Value, out watches))
            {
                MessageBox.Show("Ошибка ввода, введите целое число!", "Ошибка", MessageBoxButtons.OK);
                inputStringForm.ShowDialog();
            }
            film.Watch(watches);
            UpdateFilmInformation();
        }

        private void buttonDoRemake_Click(object sender, EventArgs e)
        {

            InputString inputProducerForm = new InputString("Введите нового режиссера.");
            InputString inputNameForm = new InputString("Введите новое название.");
            inputProducerForm.ShowDialog();
            inputNameForm.ShowDialog();
            film.DoRemake(inputProducerForm.Value, inputNameForm.Value);
            UpdateFilmInformation();
        }

        private void buttonAddScene_Click(object sender, EventArgs e)
        {
            InputString inputStringForm = new InputString("Введите количество удаленных сцен.");
            int scenes;
            inputStringForm.ShowDialog();
            while (!int.TryParse(inputStringForm.Value, out scenes))
            {
                MessageBox.Show("Ошибка ввода, введите целое число!", "Ошибка", MessageBoxButtons.OK);
                inputStringForm.ShowDialog();
            }
            film.AddScene(scenes);
            UpdateFilmInformation();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            film.CountOfWathes = int.Parse(textBoxWatches.Text);
            film.Producer = textBoxProducer.Text;
            film.Duration = double.Parse(textBoxDuration.Text);
            film.Country = textBoxCountry.Text;
            film.Fees = double.Parse(textBoxMoney.Text);
            film.Name = textBoxName.Text;

            DialogResult = DialogResult.OK;
            Close(); ;
        }
    }
}
