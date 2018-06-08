using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace PZ_generatory.AdminPanel
{
    /// <summary>
    /// Interaction logic for UserControlGeneratory.xaml
    /// </summary>
    public partial class UserControlAdminPanel : UserControl
    {
        DBLinqClassesDataContext db = new DBLinqClassesDataContext();

        public UserControlAdminPanel()
        {
            InitializeComponent();
        }

        List<Question> LoadQuestion()
        {            
            return db.Questions.ToList();
        }

        List<Answer> LoadAnswer()
        {
            return db.Answers.ToList();
        }

        List<Category> LoadCategory()
        {
            return db.Categories.ToList();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            switch((sender as Button).Content.ToString())
            {
                case "Kategorie":
                    dataGrid.ItemsSource = LoadCategory();
                    dataGrid.Columns.Clear();

                    var col = new DataGridTextColumn();
                    col.Header = "Nazwa Kategorii";
                    Binding Binding = new Binding("CategoryName");
                    Binding.Mode = BindingMode.TwoWay;
                    col.Binding = Binding;
                    dataGrid.Columns.Add(col);
                    break;

                case "Odpowiedzi":
                    dataGrid.ItemsSource = LoadAnswer();
                    dataGrid.Columns.Clear();

                    var col1 = new DataGridTextColumn();
                    col1.Header = "Treść Odpowiedzi";
                    Binding Binding1 = new Binding("Content");
                    Binding1.Mode = BindingMode.TwoWay;
                    col1.Binding = Binding1;
                    dataGrid.Columns.Add(col1);

                    var col2 = new DataGridCheckBoxColumn();
                    col2.Header = "Poprawność";
                    Binding Binding2 = new Binding("Correct");
                    Binding2.Mode = BindingMode.TwoWay;
                    col2.Binding = Binding2;
                    dataGrid.Columns.Add(col2);


                    break;


                case "Pytania":
                    dataGrid.ItemsSource = LoadQuestion();
                    dataGrid.Columns.Clear();

                    var col3 = new DataGridTextColumn();
                    col3.Header = "Treść Pytania";
                    Binding Binding3 = new Binding("Content");
                    Binding3.Mode = BindingMode.TwoWay;
                    col3.Binding = Binding3;
                    dataGrid.Columns.Add(col3);

                    break;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db.SubmitChanges();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
           
        }
    }
}

