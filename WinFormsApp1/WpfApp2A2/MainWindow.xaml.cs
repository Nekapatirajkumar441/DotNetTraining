using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2A2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //SimpleObjectDemo();
            //DisplayUIElementWithContent();

            var book1 = new Book()   //Or some user defined object
            {
                Title = "The Accursed God",
                Author = "Vivek Dutta Mishra ",
               
            };

            var book2 = new Book()   //Or some user defined object
            {
                Title = "Rashmirathi",
                Author = "Ramdhari Singh Dinkar ",
                
            };

            var book3 = new Book()   //Or some user defined object
            {
                Title = "The Count of Monte Cristo",
                Author = "Alexandre Dumas",
               
            };

            var book4 = new Book()   //Or some user defined object
            {
                Title = "The Brethren",
                Author = "John Gris Price",
            };
            






            var title = new Label() { Content = " My Book List"};
            //this.title = System.Drawing.SystemColors.MenuHighlight;
            //var controls = new ListBox();
            //controls.Items.Add(title);
            //controls.Items.Add(book1Label);
            //controls.Items.Add(title);
            //controls.Items.Add(title);
            var exitButton = new Button { Content = "Show Details" };
            var book1Label = new Label() { Content = book1 };
            var book2Label = new Label() { Content = book2 };
            var book3Label = new Label() { Content = book3 };
            var book4Label = new Label() { Content = book4 };
            
            var controls = new ListBox();
            controls.Items.Add(title);
            controls.Items.Add(book1Label);
            controls.Items.Add(book2Label);
            controls.Items.Add(book3Label);
            controls.Items.Add(book4Label);
           
            controls.Items.Add(exitButton);



            this.Content = controls;

        }

       
        private static ListBox CreateListBox(Label title, Label book1Label, Label book2Label, Label book3Label, Label book4Label, Button book2Button, Button exitButton)
        {
            //How do I add three Items on the Window
            //Window can Accept a single content

            //Step 1. Create a Items Control
            var controls = new ListBox();

            //Step 2. Add All Controls to Items control
            controls.Items.Add(title);
            controls.Items.Add(book1Label);
            controls.Items.Add(book2Label);
            controls.Items.Add(book3Label);
            controls.Items.Add(book4Label);
            controls.Items.Add(book2Button);
          
            controls.Items.Add("End of List");

            //Step 3. Add the Items control to the window
            return controls;
        }

       

        private void DisplayUIElementWithContent()
        {
            //WPF Window can display one Content of type Object ---> any type
            //Not necessarily a WPF UI Element




            //We can add UI Element also

            TextBlock text1 = new TextBlock()
            {
                Text = "Welcome to WPF"
                //NO property to position or size the control
            };

            this.Content = text1;

            var book = new Book()   //Or some user defined object
            {
                Title = "The Accursed God",
                Author = "Vivek Dutta Mishra",
                Price = 399
            };

            //text1.Text = book; //can't assign object to TextBlock

            Label label1 = new Label();
            label1.Content = book;



            this.Content = label1;


            Button button = new Button();
            button.Content = book;
            button.Margin = new Thickness(10);

            //button.Click += ShowBookInfo;
            this.Content = button;
        }



        private void SimpleObjectDemo()
        {
            this.Content = "Hello Wpf!"; //Simple String

            this.Content = 3.141592;  //value of PI

            this.Content = DateTime.Now;  //Or some other builtin object

            this.Content = new Book()   //Or some user defined object
            {
                Title = "The Accursed God",
                Author = "Vivek Dutta Mishra",
                Price = 399
            };
        }
    }
}
