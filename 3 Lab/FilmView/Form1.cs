using FilmModels;

namespace FilmView
{
    public partial class Form1 : Form
    {
        List<IFilm> films = new List<IFilm>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IFilm film = new ComedyFilm();
            FilmForm filmForm = new FilmForm(film);
            if (filmForm.ShowDialog() == DialogResult.OK)
            {
                listBoxFilms.Items.Add(film);
                films.Add(film);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedItem = listBoxFilms.SelectedIndex;
            if (selectedItem != -1)
            {
                FilmForm filmForm = new FilmForm(films[selectedItem]);

                if (filmForm.ShowDialog() == DialogResult.OK)
                {
                    listBoxFilms.Items.RemoveAt(selectedItem);
                    listBoxFilms.Items.Insert(selectedItem, films[selectedItem]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxFilms.SelectedIndex != -1)
            {
                listBoxFilms.Items.RemoveAt(listBoxFilms.SelectedIndex);
                films.RemoveAt(listBoxFilms.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBoxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxFilms_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedItem = listBoxFilms.SelectedIndex;
            FilmForm filmForm = new FilmForm(films[selectedItem]);
            if (selectedItem != -1)
            {
                if (filmForm.ShowDialog() == DialogResult.OK)
                {
                    listBoxFilms.Items.RemoveAt(selectedItem);
                    listBoxFilms.Items.Insert(selectedItem, films[selectedItem]);
                }
            }
        }
    }
}