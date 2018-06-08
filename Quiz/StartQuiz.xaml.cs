using System;
using System.Windows;
using System.Windows.Controls;


namespace PZ_generatory.Quiz
{

    public partial class StartQuiz : UserControl
    {
        public string categoryName { get; set; }
        public int categoryId { get; set; }

        QuizManager quizmanager;
       

        public StartQuiz(int categoryid, string categoryname)
        {
            InitializeComponent();
            this.quizmanager = new QuizManager(categoryid, QuestionPlace, QuestionNumberLabel, ChangeButtonNextquestion);
            this.categoryName = categoryname;
            this.categoryId = categoryid;

            HowManyQuestionLabel.Content = "Liczba pytań z danej kategorii: " + quizmanager.howManyQuestionInCategory;
            LabelCategoryChoice.Content = "Wybrana kategoria: " + categoryName;

            if (quizmanager._canStart)
            {
                buttonStartQuiz.IsEnabled = true;
            }
            else
            {
                buttonStartQuiz.IsEnabled = false;
                GoodLuck.Visibility = Visibility.Hidden;
            }
        }

        public void ChangeButtonNextquestion(object sender, EventArgs e)
        {
            buttonStartQuiz.Content = "Wróć do wyboru kategorii";
            buttonStartQuiz.Click -= buttonQuiz_Click;
            buttonStartQuiz.Click += buttonBackToCAtegoryChoice_Click;
        }

        private void buttonBackToCAtegoryChoice_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void buttonQuiz_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (quizmanager.actualQuestion == 0)
            {
                HowManyQuestionLabel.Visibility = Visibility.Hidden;
                button.Content = "Następne pytanie";
                buttonBackToCAtegoryChoice.Visibility = Visibility.Hidden;
                quizmanager.NextQuestion(sender,e);
            }
            else
            {
                var a = (UserControlQuestion)QuestionPlace.Children[0];
                a.EndQuestion(e);
                 
            }
            
        }
    }
}
