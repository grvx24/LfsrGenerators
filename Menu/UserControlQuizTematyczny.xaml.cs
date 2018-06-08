using PZ_generatory.Quiz;
using System.Windows;
using System.Windows.Controls;

namespace PZ_generatory
{
    public partial class UserControlQuizTematyczny : UserControl
    {
        public UserControlQuizTematyczny()
        {
            InitializeComponent();
            LoadCategoriesToWrapPanelFromDataBase();
        }

        private void LoadCategoriesToWrapPanelFromDataBase()
        {
            var db = new DBLinqClassesDataContext();
            var categories = db.Categories;
            ItemContorlWrapPranel.ItemsSource = categories;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var context = button.DataContext as Category;
            UserControl usc = new StartQuiz(context.ID, context.CategoryName);
            GridMain.Children.Add(usc);
        }
    }
}
