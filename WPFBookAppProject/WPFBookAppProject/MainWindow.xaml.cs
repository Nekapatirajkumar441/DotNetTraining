using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFBookAppProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<BookApp> bookapp = new List<BookApp>();
        BookApp app = new BookApp();
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Title.Text != "" && Author.Text != "" && Price.Text != "")
                {
                    BookApp bookapplist = new BookApp();
                    bookapplist.Title = Title.Text;
                    bookapplist.Author = Author.Text;
                    bookapplist.Price = Convert.ToInt32(Price.Text);
                    bookapp.Add(bookapplist);
                    MessageBox.Show("BookDetails Saved Successfully", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                    Author.Text = "";
                    Price.Text = "";
                    Title.Text = "";
                    Status.Content = "";
                }
                else
                {
                    MessageBox.Show("Please Enter Book App Details", "Message", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (app != null)
                {
                    bookapp.Remove(app);
                    MessageBox.Show("BookDetails Deleted Successfully", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                    Author.Text = "";
                    Price.Text = "";
                    Title.Text = "";
                    Status.Content = "";
                }
                else
                {
                    MessageBox.Show("Please select the BookDetails To Delete", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void First_Click(object sender, RoutedEventArgs e)
        {
            if (bookapp.Count > 0)
            {
                int i = 0;
                app = bookapp[i];
                Title.Text = app.Title.ToString();
                Author.Text = app.Author.ToString();
                Price.Text = app.Price.ToString();
                Status.Content = (i + 1).ToString() + " of " + bookapp.Count.ToString();
            }
        }
        private void Prv_Click(object sender, RoutedEventArgs e)
        {
            if (bookapp.Count > 0)
            {
                if (i == bookapp.Count - 1 || i != 0)
                {
                    i--;
                    app = bookapp[i];
                    Title.Text = app.Title.ToString();
                    Author.Text = app.Author.ToString();
                    Price.Text = app.Price.ToString();
                    Status.Content = (i + 1).ToString() + " of " + bookapp.Count.ToString();

                }
            }

        }
        private void New_Click(object sender, RoutedEventArgs e)
        {
            Author.Text = "";
            Price.Text = "";
            Title.Text = "";
            Status.Content = "";
        }
            private void Nxt_Click(object sender, RoutedEventArgs e)
        {
            if (bookapp.Count +1 > 0)
            {
                if (i == bookapp.Count - 1 || i != 0)
                {
                    i--;
                    app = bookapp[i];
                    Title.Text = app.Title.ToString();
                    Author.Text = app.Author.ToString();
                    Price.Text = app.Price.ToString();
                    Status.Content = (i + 1).ToString() + " of " + bookapp.Count.ToString();

                }
            }
        }
        private void Last_Click(object sender, RoutedEventArgs e)
        {
            if (bookapp.Count+1 > 0)
            {
                if (i == bookapp.Count - 1 || i != 0)
                {
                    i--;
                    app = bookapp[i];
                    Title.Text = app.Title.ToString();
                    Author.Text = app.Author.ToString();
                    Price.Text = app.Price.ToString();
                    Status.Content = (i + 1).ToString() + " of " + bookapp.Count.ToString();

                }
            }
        }
    }
}
