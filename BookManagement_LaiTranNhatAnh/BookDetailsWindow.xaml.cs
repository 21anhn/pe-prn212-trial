﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BLL.Services;
using DAL.Models;

namespace BookManagement_LaiTranNhatAnh
{
    /// <summary>
    /// Interaction logic for BookDetailsWindow.xaml
    /// </summary>
    public partial class BookDetailsWindow : Window
    {
        private Book _currentBook;
        private CategoryService _categoryService = new();
        private BookService _bookService = new();

        public BookDetailsWindow()
        {
            InitializeComponent();
        }

        //Dependency injection
        public BookDetailsWindow(Book book)
        {
            InitializeComponent();
            _currentBook = book;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BookCategoryComboBox.ItemsSource = _categoryService.GetAllCategories();
            BookCategoryComboBox.DisplayMemberPath = "BookGenreType";
            BookCategoryComboBox.SelectedValuePath = "BookCategoryId";
            //Nếu là update
            if (_currentBook != null)
            {
                BookIdTextBox.Text = _currentBook.BookId + "";
                BookNameTextBox.Text = _currentBook.BookName;
                DescriptionTextBox.Text = _currentBook.Description;
                PublicationDateDatePicker.Text = _currentBook.PublicationDate.ToString();
                QuantityTextBox.Text = _currentBook.Quantity + "";
                PriceTextBox.Text = _currentBook.Price + "";
                AuthorTextBox.Text = _currentBook.Author;
                BookCategoryComboBox.SelectedValue = _currentBook.BookCategoryId;
            }
        }

        private void SaveButton_Click_1(object sender, RoutedEventArgs e)
        {
            int bookId = int.Parse(BookIdTextBox.Text);
            string bookName = BookNameTextBox.Text;
            string description = DescriptionTextBox.Text;
            var publicationDateStr = PublicationDateDatePicker.Text;
            var publicationDate = DateTime.Parse(publicationDateStr);
            int quantity = int.Parse(QuantityTextBox.Text);
            var price = double.Parse(PriceTextBox.Text);
            string author = AuthorTextBox.Text;
            int categoryId = int.Parse(BookCategoryComboBox.SelectedValue.ToString());

            Book b = new Book()
            {
                BookId = bookId,
                BookName = bookName,
                Description = description,
                PublicationDate = publicationDate,
                Author = author,
                Price = price,
                Quantity = quantity,
                BookCategoryId = categoryId
            };
            if (_currentBook != null)
            {
                bool checkUpdate = _bookService.UpdateBook(b);
                if (checkUpdate)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Error in updating book!", "Warning");
                }
                return;
            }
            bool checkCreate = _bookService.CreateBook(b);
            if (checkCreate)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Error in saving book!", "Warning");
            }
        }
    }
}
