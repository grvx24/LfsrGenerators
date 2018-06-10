using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        DataClasses1DataContext db = new DataClasses1DataContext();
        List<Category> _Categories;
        List<Question> _Questions;
        List<Answer> _Answers;
        List<CategoryInfo> categoryInfoList;
        int EditedQuestionId;

        public UserControlAdminPanel()
        {
            InitializeComponent();
            this._Categories = LoadCategory();
            this._Questions = LoadQuestion();
            this._Answers = LoadAnswer();
            CategoryList.ItemsSource = _Categories;
            EditedCategoryList.ItemsSource = _Categories;
            categoryInfoList = new List<CategoryInfo>();
            foreach (var item in _Categories)
            {
                CategoryInfo a = new CategoryInfo(item, HowManyQuestionsInCategory(item.ID));
                categoryInfoList.Add(a);
            }
            CategoryGrid.ItemsSource = categoryInfoList;
            QuestionGrid.ItemsSource = _Questions;

        }

        public int HowManyQuestionsInCategory(int categoryId)
        {
            int a = 0;
            foreach (var item in _Questions)
            {
                if(item.CategoryId == categoryId) a++;
            }
            return a; 
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

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void LettersValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z ]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void AddQuestionClick(object sender, RoutedEventArgs e)
        {
            if (QuestionContent.Text == "" || Answer1Content.Text=="" || Answer2Content.Text == "" || Answer3Content.Text == "" || Answer4Content.Text == "" )
            {
                MessageBox.Show("Proszę uzupełnić wszystkie pola.");
            }
            else
            {
                if(Answer1CheckBox.IsChecked.Value == false  && Answer2CheckBox.IsChecked.Value == false && Answer3CheckBox.IsChecked.Value == false && Answer4CheckBox.IsChecked.Value == false)
                {
                    MessageBox.Show("Proszę wybrać która odpowiedź ma być poprawna.");
                }
                else
                {
                    if (QuestionTime.Text == "")
                    {
                        MessageBox.Show("Proszę wpisać ilość sekund przewidzianych na pytanie.");
                    }
                    else
                    {
                        if (CategoryList.SelectedItem == null)
                        {
                            MessageBox.Show("Proszę wybrać kategorie pytania.");
                        }
                        else
                        {
                            Question question = new Question
                            {
                                Content = QuestionContent.Text,
                                CategoryId = (CategoryList.SelectedItem as Category).ID,
                                Time = Int32.Parse(QuestionTime.Text)
                            };

                            try
                            {
                                db.Connection.Open();
                                db.Transaction = db.Connection.BeginTransaction();
                                foreach (var item in db.Questions)
                                {
                                    if (item.Content == question.Content && item.CategoryId == question.CategoryId)
                                    {
                                        throw new Exception("Istnieje już  pytanie o takiej treści, w tej kategorii.");
                                    }
                                };
                                db.Questions.InsertOnSubmit(question);
                                db.SubmitChanges();
                                var questionId = db.Questions.Where(j => j.Content == question.Content).Select(s => s.Id).First();

                                Answer answer1 = new Answer
                                {
                                    Content = Answer1Content.Text,
                                    Correct = Answer1CheckBox.IsChecked.Value,
                                    QuestionId = questionId
                                };

                                db.Answers.InsertOnSubmit(answer1);

                                Answer answer2 = new Answer
                                {
                                    Content = Answer2Content.Text,
                                    Correct = Answer2CheckBox.IsChecked.Value,
                                    QuestionId = questionId
                                };
                                db.Answers.InsertOnSubmit(answer2);

                                Answer answer3 = new Answer
                                {
                                    Content = Answer3Content.Text,
                                    Correct = Answer3CheckBox.IsChecked.Value,
                                    QuestionId = questionId
                                };
                                db.Answers.InsertOnSubmit(answer3);

                                Answer answer4 = new Answer
                                {
                                    Content = Answer4Content.Text,
                                    Correct = Answer4CheckBox.IsChecked.Value,
                                    QuestionId = questionId
                                };
                                db.Answers.InsertOnSubmit(answer4);


                                db.SubmitChanges();
                                db.Transaction.Commit();
                                db.Connection.Close();
                                MessageBox.Show("Pomyślnie dodano pytanie do bazy danych.");
                            }
                            catch (Exception exception)
                            {
                                db.Connection.Close();
                                if (exception.Message == "Istnieje już  pytanie o takiej treści, w tej kategorii.")
                                {
                                    MessageBox.Show(exception.Message);
                                }
                                else
                                {
                                    MessageBox.Show("Nie udało się dodać pytania.");
                                }

                                Console.WriteLine(exception.Message);
                                try
                                {
                                    db.Transaction.Rollback();
                                }
                                catch (Exception ex2)
                                {
                                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                                    Console.WriteLine("  Message: {0}", ex2.Message);
                                }
                            }
                        }
                    }
                }    
            }    
        }

        private void AddCategory(object sender, RoutedEventArgs e)
        {
            if(NewCategoryName.Text == "")
            {
                MessageBox.Show("Proszę wpisać nazwę kategorii.");
            }
            else {
                try
                {
                    db.Connection.Open();
                    db.Transaction = db.Connection.BeginTransaction();

                    Category categoryToAdd = new Category
                    {
                        CategoryName = NewCategoryName.Text
                    };
                    foreach (var item in db.Categories)
                    {
                        if (item.CategoryName == categoryToAdd.CategoryName)
                        {
                            throw new Exception("Istnieje już kategoria o takiej nazwie !");
                        }
                    };

                    db.Categories.InsertOnSubmit(categoryToAdd);

                    db.SubmitChanges();
                    db.Transaction.Commit();
                    db.Connection.Close();

                    categoryInfoList.Add(new CategoryInfo(categoryToAdd,0));
                    CategoryGrid.ItemsSource = null;
                    CategoryGrid.ItemsSource = categoryInfoList;
                    MessageBox.Show("Pomyślnie dodano nową kategorie !");
                }
                catch (Exception exception)
                {
                    db.Connection.Close();
                    if (exception.Message == "Istnieje już kategoria o takiej nazwie !")
                    {
                        MessageBox.Show(exception.Message);
                    }
                    else
                    {
                        MessageBox.Show("Nie udało się dodać kategorii.");
                    }
                    Console.WriteLine(exception.Message);
                    try
                    {
                        db.Transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
        }

        private void DeleteCategory(object sender, RoutedEventArgs e)
        {
            var baseobj = sender as FrameworkElement;
            var myObject = (CategoryInfo)baseobj.DataContext;

            if (MessageBox.Show("Czy na pewno chcesz usunąć całą kategorie: " +myObject.CategoryName + " ? " + Environment.NewLine + "Zawiera ona " + myObject.HowManyQuestionsInCategory + " pytań. ","", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    db.Connection.Open();
                    db.Transaction = db.Connection.BeginTransaction();

                    List<Question> questiontoDelete = db.Questions.Where(q => q.CategoryId == myObject.ID).ToList();
                    List<Answer> answerstoDelete = new List<Answer>();
                    foreach (var item in questiontoDelete)
                    {
                        answerstoDelete.AddRange(db.Answers.Where(a => a.QuestionId == item.Id).ToList());
                    }


                    db.Answers.DeleteAllOnSubmit(answerstoDelete);
                    db.SubmitChanges();

                    db.Questions.DeleteAllOnSubmit(questiontoDelete);
                    db.SubmitChanges();

                    var kategoria = db.Categories.SingleOrDefault(c => c.ID == myObject.ID);
                    db.Categories.DeleteOnSubmit(kategoria);
                    db.SubmitChanges();

                    db.Transaction.Commit();
                    db.Connection.Close();


                    categoryInfoList.RemoveAt(categoryInfoList.FindIndex(q => q.ID == myObject.ID));
                    CategoryGrid.ItemsSource = null;
                    CategoryGrid.ItemsSource = categoryInfoList;
                    MessageBox.Show("Pomyślnie usunięto całą kategorie."); 
                }
                catch (Exception exception)
                {
                    db.Connection.Close();
                    MessageBox.Show("Kategoria nie mogła zostać usunięta");
                    Console.WriteLine(exception.Message);
                    try
                    {
                        db.Transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
        }

        private void GoToAddQuestionToCategory(object sender, RoutedEventArgs e)
        {
            var baseobj = sender as FrameworkElement;
            var myObject = (CategoryInfo)baseobj.DataContext;

            AddQuestionTab.IsSelected = true;

            foreach (Category item in CategoryList.Items)
                if (item.CategoryName == myObject.CategoryName)
                {
                    CategoryList.SelectedValue = item;
                    break;
                }
        }

        private void DeleteQuestion(object sender, RoutedEventArgs e)
        {
            var baseobj = sender as FrameworkElement;
            var myObject = (Question)baseobj.DataContext;

            if (MessageBox.Show("Czy na pewno chcesz usunąć to pytanie?" + Environment.NewLine, "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    List<Answer> answerstoDelete = new List<Answer>();

                    answerstoDelete.AddRange(db.Answers.Where(a => a.QuestionId == myObject.Id).ToList());

                    db.Answers.DeleteAllOnSubmit(answerstoDelete);

                    var pytanie = db.Questions.SingleOrDefault(p => p.Id == myObject.Id);
                    db.Questions.DeleteOnSubmit(pytanie);

                    db.SubmitChanges();

                    QuestionGrid.ItemsSource = null;
                    _Questions = LoadQuestion();
                    QuestionGrid.ItemsSource = _Questions;
                    MessageBox.Show("Pomyślnie usunięto pytanie.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Pytanie nie mogło zostać usunięta");
                    Console.WriteLine(exception.Message);
                }
            }
        }

        private void EditQuestion(object sender, RoutedEventArgs e)
        {
            if (EditedQuestionContent.Text == "" || EditedAnswer1Content.Text == "" || EditedAnswer2Content.Text == "" || EditedAnswer3Content.Text == "" || EditedAnswer4Content.Text == "")
            {
                MessageBox.Show("Proszę uzupełnić wszystkie pola.");
            }
            else
            {
                if (EditedAnswer1CheckBox.IsChecked.Value == false && EditedAnswer2CheckBox.IsChecked.Value == false && EditedAnswer3CheckBox.IsChecked.Value == false && EditedAnswer4CheckBox.IsChecked.Value == false)
                {
                    MessageBox.Show("Proszę wybrać która odpowiedź ma być poprawna.");
                }
                else
                {
                    if (QuestionTime.Text == "")
                    {
                        MessageBox.Show("Proszę wpisać ilość sekund przewidzianych na pytanie.");
                    }
                    else
                    {
                        if (EditedCategoryList.SelectedItem == null)
                        {
                            MessageBox.Show("Proszę wybrać kategorie pytania.");
                        }
                        else
                        {
                            try
                            {
                                Question updatedQuestion = db.Questions.SingleOrDefault(x => x.Id == EditedQuestionId);

                                foreach (var item in db.Questions)
                                {
                                    if (item.Content == EditedQuestionContent.Text && item.CategoryId == ((Category)EditedCategoryList.SelectedItem).ID && item.Id != updatedQuestion.Id)
                                    {
                                        throw new Exception("Istnieje już pytanie o takiej treści, w tej kategorii.");
                                    }
                                };

                                updatedQuestion.Content = EditedQuestionContent.Text;
                                updatedQuestion.Time = Int32.Parse(EditedQuestionTime.Text);
                                updatedQuestion.Answers[0].Content = EditedAnswer1Content.Text;
                                updatedQuestion.Answers[0].Correct = EditedAnswer1CheckBox.IsChecked.Value;
                                updatedQuestion.Answers[1].Content = EditedAnswer2Content.Text;
                                updatedQuestion.Answers[1].Correct = EditedAnswer2CheckBox.IsChecked.Value;
                                updatedQuestion.Answers[2].Content = EditedAnswer3Content.Text;
                                updatedQuestion.Answers[2].Correct = EditedAnswer3CheckBox.IsChecked.Value;
                                updatedQuestion.Answers[3].Content = EditedAnswer4Content.Text;
                                updatedQuestion.Answers[3].Correct = EditedAnswer4CheckBox.IsChecked.Value;
                                updatedQuestion.CategoryId = ((Category)EditedCategoryList.SelectedItem).ID;
                                updatedQuestion.Category = (Category)EditedCategoryList.SelectedItem;

                                db.SubmitChanges();
                                MessageBox.Show("Pomyślnie zmodyfikowano pytanie w bazie danych.");
                            }
                            catch (Exception exception)
                            {
                                if (exception.Message == "Istnieje już pytanie o takiej treści, w tej kategorii.")
                                {
                                    MessageBox.Show(exception.Message);
                                }
                                else
                                {
                                    MessageBox.Show("Nie udało się dodać pytania.");
                                }

                                Console.WriteLine(exception.Message);
                            }
                        }
                    }
                }
            }
        }

        private void GoToEditQuestion(object sender, RoutedEventArgs e)
        {
            var baseobj = sender as FrameworkElement;
            var myObject = (Question)baseobj.DataContext;
            EditQuestionTab.IsSelected = true;

            EditedQuestionContent.Text = myObject.Content;
            EditedQuestionTime.Text = myObject.Time.ToString();
            foreach (Category item in EditedCategoryList.Items)
                if (item.CategoryName == myObject.Category.CategoryName)
                {
                    EditedCategoryList.SelectedValue = item;
                    EditedCategoryList.IsEnabled = false;
                    break;
                }

            EditedAnswer1Content.Text = myObject.Answers[0].Content;
            EditedAnswer1CheckBox.IsChecked = myObject.Answers[0].Correct;

            EditedAnswer2Content.Text = myObject.Answers[1].Content;
            EditedAnswer2CheckBox.IsChecked = myObject.Answers[1].Correct;

            EditedAnswer3Content.Text = myObject.Answers[2].Content;
            EditedAnswer3CheckBox.IsChecked = myObject.Answers[2].Correct;

            EditedAnswer4Content.Text = myObject.Answers[3].Content;
            EditedAnswer4CheckBox.IsChecked = myObject.Answers[3].Correct;

            EditedQuestionId = myObject.Id;
        }
        
    }
}

