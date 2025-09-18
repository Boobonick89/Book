using System.ComponentModel;
using System.Text.Json;

namespace Book
{
    public partial class Form1 : Form
    {
        private static readonly JsonSerializerOptions JsonOpts = new()
        {
            WriteIndented = true,
        };
        private const string FileName = "Books";
        private readonly BindingList<Book> _books = new BindingList<Book>();
        public Form1()
        {
            InitializeComponent();
            lstBooks.DataSource = _books;
            LoadFormFile();
            this.FormClosing += (_, _) => SaveToFile();
        }
        private void AddBook_Click(object sender, EventArgs e)
        {
            if (!TryReadInputs(out string name, out string autor, out string genre, out int yearofpublishing)) return;

            _books.Add(new Book(name, autor, genre, yearofpublishing));

            ClearInputs();
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem is not Book selected)
            {
                MessageBox.Show("Выберите книгу для удаления");
                return;
            }

            _books.Remove(selected);

            ClearInputs();
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string autor = txtAutor.Text.Trim();
            string genre = txtGenre.Text.Trim();
            bool hasYear = int.TryParse(txtyearOfPublishing.Text.Trim(), out int year);
            
            if (string.IsNullOrWhiteSpace(name) &&
                string.IsNullOrWhiteSpace(autor) &&
                string.IsNullOrWhiteSpace(genre) &&
                !hasYear)
            {
                lstBooks.DataSource = null;
                lstBooks.DataSource = _books;
                return;
            }
            
            var result = _books.Where(b =>
            (!string.IsNullOrWhiteSpace(name) && b.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) ||
            (!string.IsNullOrWhiteSpace(autor) && b.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase)) ||
            !string.IsNullOrWhiteSpace(genre) && b.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase) ||
             hasYear && b.YearOfPublishing == year).ToList();

            if (!result.Any())
            {
                lstBooks.DataSource = null;
                lstBooks.Items.Clear();
                lstBooks.Items.Add("Ничего не найдено");
                return;
            }

            lstBooks.DataSource = null;
            lstBooks.DataSource = result;
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAutor.Clear();
            txtGenre.Clear();
            txtyearOfPublishing.Clear();

            lstBooks.DataSource = null;
            lstBooks.DataSource = _books;
        }
        private bool TryReadInputs(out string name, out string autor, out string genre, out int yearofpublishing)
        {
            name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите наименование книги");
                autor = ""; genre = ""; yearofpublishing = 0;
                return false;
            }

            autor = txtAutor.Text.Trim();

            if (string.IsNullOrWhiteSpace(autor))
            {
                MessageBox.Show("Введите автора книги");
                genre = ""; yearofpublishing = 0;
                return false;
            }

            genre = txtGenre.Text.Trim();

            if (string.IsNullOrWhiteSpace(genre))
            {
                MessageBox.Show("Введите жанр книги");
                yearofpublishing = 0;
                return false;
            }

            if (!int.TryParse(txtyearOfPublishing.Text.Trim(), out yearofpublishing) || yearofpublishing < 0)
            {
                MessageBox.Show("Введите год выпуска книги");
                return false;
            }

            return true;
        }
        private void ClearInputs()
        {
            txtName.Clear();
            txtAutor.Clear();
            txtGenre.Clear();
            txtyearOfPublishing.Clear();
            txtName.Focus();
        }
        private void SaveToFile()
        {
            try
            {
                var json = JsonSerializer.Serialize(_books, JsonOpts);
                File.WriteAllText(FileName, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения" + ex.Message);
            }
        }
        private void LoadFormFile()
        {
            try
            {
               if(!File.Exists(FileName)) return;
               string json   = File.ReadAllText(FileName);
                var data = JsonSerializer.Deserialize<List<Book>>(json, JsonOpts);
                if (data == null) return;
                {
                    _books.Clear();
                }

                foreach(var bk in data)
                {
                    _books.Add(bk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке: " + ex.Message);
            }
        }
    }
}

       
