using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookHaven_Bookstore_Management_System.Domain;
using BookHaven_Bookstore_Management_System.Domain.Enums;
using BookHaven_Bookstore_Management_System.Services.interfaces;

namespace BookHaven_Bookstore_Management_System.View.CommonModules
{
    public partial class CommonModuleBook : Form
    {
        private readonly IBookService _bookService;

        public CommonModuleBook(IBookService bookService)
        {
            InitializeComponent();
            _bookService = bookService;
            InitializeData();
            txtBookId.Enabled = false;
            txtQuantity.Enabled = false;
        }

        private void InitializeData()
        {
            LoadGenresIntoComboBox();
            LoadBooks();
            dataGridViewBooks.CellClick += DataGridViewBooks_CellClick;
        }

        private void LoadGenresIntoComboBox()
        {
            comboGenre.DataSource = Enum.GetValues(typeof(Genre)).Cast<Genre>().ToList();
            comboGenre.DisplayMember = "ToString";
        }

       private void LoadBooks()
{
    try
    {
        var books = _bookService.GetAllBooks();
        var bookData = books.Select(b => new
        {
            b.BookID,
            b.ISBN,
            b.Title,
            b.Author,
            Genre = b.Genre.ToString(),
            b.Price,
            b.StockQuantity
        }).ToList();

        dataGridViewBooks.DataSource = bookData;
        ConfigureDataGridViewColumns();
        ConfigureStockAlertColumn(); // Add this line
        dataGridViewBooks.Refresh();
        Refresh();
    }
    catch (Exception ex)
    {
        ShowErrorMessage("Error loading books", ex);
    }
}

        private void ConfigureStockAlertColumn()
        {
            DataGridViewColumn stockAlertColumn = new DataGridViewTextBoxColumn();
            stockAlertColumn.Name = "StockAlert";
            stockAlertColumn.HeaderText = "Stock Alert";
            dataGridViewBooks.Columns.Add(stockAlertColumn);

            dataGridViewBooks.CellFormatting += DataGridViewBooks_CellFormatting;
        }

        private void DataGridViewBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewBooks.Columns["StockAlert"].Index)
            {
                int stockQuantity = Convert.ToInt32(dataGridViewBooks.Rows[e.RowIndex].Cells["StockQuantity"].Value);

                if (stockQuantity < 10)
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.Value = "Low Stock";
                }
                else if (stockQuantity < 20)
                {
                    e.CellStyle.BackColor = Color.Orange;
                    e.Value = "Medium Stock";
                }
                else
                {
                    e.CellStyle.BackColor = Color.White; 
                    e.Value = "Normal";
                }
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            if (dataGridViewBooks.Columns.Count > 0)
            {
                dataGridViewBooks.Columns["BookID"].HeaderText = "Book ID";
                dataGridViewBooks.Columns["ISBN"].HeaderText = "ISBN";
                dataGridViewBooks.Columns["Title"].HeaderText = "Title";
                dataGridViewBooks.Columns["Author"].HeaderText = "Author";
                dataGridViewBooks.Columns["Genre"].HeaderText = "Genre";
                dataGridViewBooks.Columns["Price"].HeaderText = "Price";
                dataGridViewBooks.Columns["StockQuantity"].HeaderText = "Quantity";
            }
        }

        private void DataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedRow = dataGridViewBooks.Rows[e.RowIndex];
            txtBookId.Text = selectedRow.Cells["BookID"].Value?.ToString() ?? "";
            txtTitle.Text = selectedRow.Cells["Title"].Value?.ToString() ?? "";
            txtAuthor.Text = selectedRow.Cells["Author"].Value?.ToString() ?? "";
            txtISBN.Text = selectedRow.Cells["ISBN"].Value?.ToString() ?? "";
            txtPrice.Text = selectedRow.Cells["Price"].Value?.ToString() ?? "";
            txtQuantity.Text = selectedRow.Cells["StockQuantity"].Value?.ToString() ?? "";

            if (selectedRow.Cells["Genre"].Value != null)
            {
                comboGenre.SelectedItem = Enum.Parse(typeof(Genre), selectedRow.Cells["Genre"].Value.ToString());
            }
        }

        private void cus_save_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var newBook = CreateBookFromInput();
                _bookService.AddBook(newBook);
                ShowSuccessMessage("Book added successfully.");
                RefreshData();
            }
            catch (FormatException)
            {
                ShowErrorMessage("Invalid Quantity or Price format.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error adding book", ex);
            }
        }

        private void cus_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateBookId()) return;

                int bookId = Convert.ToInt32(txtBookId.Text);
                string title = txtTitle.Text.Trim();
                string author = txtAuthor.Text.Trim();
                string isbn = txtISBN.Text.Trim();
                int stockQuantity = int.Parse(txtQuantity.Text.Trim());
                int genre = (int)(Genre)comboGenre.SelectedItem;
                decimal price = decimal.Parse(txtPrice.Text.Trim());

                Book updatedBook = new Book
                {
                    BookID = bookId,
                    Title = title,
                    Author = author,
                    ISBN = isbn,
                    StockQuantity = stockQuantity,
                    Genre = (Genre)genre,
                    Price = price
                };

                //Example using update existing entity.
                var existingBook = _bookService.GetBookById(updatedBook.BookID);

                if (existingBook != null)
                {
                    existingBook.Title = updatedBook.Title;
                    existingBook.Author = updatedBook.Author;
                    existingBook.ISBN = updatedBook.ISBN;
                    existingBook.StockQuantity = updatedBook.StockQuantity;
                    existingBook.Genre = updatedBook.Genre;
                    existingBook.Price = updatedBook.Price;


                    _bookService.UpdateBook(existingBook);

                    MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                LoadBooks();
                ClearTextBoxes();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Customer ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cus_delete_Click(object sender, EventArgs e)
        {
            if (!ValidateBookId()) return;

            if (ConfirmDelete())
            {
                try
                {
                    _bookService.DeleteBook(int.Parse(txtBookId.Text.Trim()));
                    ShowSuccessMessage("Book deleted successfully.");
                    RefreshData();
                }
                catch (FormatException)
                {
                    ShowErrorMessage("Invalid Book ID format.");
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("Error deleting book", ex);
                }
            }
        }

        private void cus_search_Click(object sender, EventArgs e)
        {
            try
            {
                var books = _bookService.SearchBooks(book_search_key.Text.Trim());
                dataGridViewBooks.DataSource = books.Select(b => new
                {
                    b.BookID,
                    b.ISBN,
                    b.Title,
                    b.Author,
                    Genre = b.Genre.ToString(),
                    b.Price,
                    b.StockQuantity
                }).ToList();
                ConfigureDataGridViewColumns();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error loading customers", ex);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txtBookId.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtISBN.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            comboGenre.SelectedIndex = -1;
        }

        private void RefreshData()
        {
            LoadBooks();
            ClearTextBoxes();
        }

        private Book CreateBookFromInput()
        {
            return new Book
            {
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                ISBN = txtISBN.Text.Trim(),
                StockQuantity = int.Parse(txtQuantity.Text.Trim()),
                Genre = (Genre)comboGenre.SelectedItem,
                Price = decimal.Parse(txtPrice.Text.Trim())
            };
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text) ||
                comboGenre.SelectedItem == null || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                ShowInformationMessage("Please fill in all book details.");
                return false;
            }
            return true;
        }

        private bool ValidateBookId()
        {
            if (string.IsNullOrWhiteSpace(txtBookId.Text))
            {
                ShowInformationMessage("Please select a book.");
                return false;
            }
            return true;
        }

        private bool ConfirmDelete()
        {
            return MessageBox.Show("Are you sure you want to delete this book?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void ShowErrorMessage(string message, Exception ex = null)
        {
            MessageBox.Show($"{message}: {ex?.Message ?? ""}{(ex?.InnerException != null ? $"\nInner Exception: {ex.InnerException.Message}" : "")}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowInformationMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void StaffBook_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }
}