using PZ_generatory.Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace PZ_generatory.Quiz
{
    class QuizManager
    {
        DBLinqClassesDataContext db = new DBLinqClassesDataContext();
        List<Question> _questions = new List<Question>();
        public int howManyQuestionInQuiz = 8;
        public int actualQuestion = 0;
        public int howManyQuestionInCategory;
        StackPanel questionPlace;
        Label InfoAboutActualQuestion;
        bool[] UserAnswears;
        public event EventHandler ChangeButtonNextquestionEvent;

        public bool _canStart;

        public QuizManager(int categoryId, StackPanel questionPlace, Label infoAboutActualQuestion,EventHandler ChangeButtonNextquestion)
        {
            List<Question> allQuestionFromCategory = loadQuestionByCategory(categoryId);
            howManyQuestionInCategory = allQuestionFromCategory.Count();
            randXQuestionsFromAll(allQuestionFromCategory);
            this.questionPlace = questionPlace;
            this.InfoAboutActualQuestion = infoAboutActualQuestion;
            this.UserAnswears = new bool[howManyQuestionInQuiz];
            this.ChangeButtonNextquestionEvent = ChangeButtonNextquestion;
        }

        public int HowManyQuestionInCategory()
        {
            return howManyQuestionInCategory;
        }

        private List<Question> loadQuestionByCategory(int CategoryId)
        {
            return db.Questions.Where(s => s.CategoryId == CategoryId).ToList();
        }

        private void randXQuestionsFromAll(List<Question> allQuestionFromCategory)
        {
            if(allQuestionFromCategory.Count>= howManyQuestionInQuiz)
            { 
                HashSet<int> numbers = new HashSet<int>();
                var rnd = new Random();
                while (numbers.Count < howManyQuestionInQuiz )
                {
                    numbers.Add(rnd.Next(0, allQuestionFromCategory.Count));
                }

                foreach (var item in numbers)
                {
                    _questions.Add(allQuestionFromCategory[item]);
                }
                _canStart = true;
            }
            else
            {
                _canStart = false;
            }
        }

        public void QuestionEnded(object sender, EventArgs e)
        {
            var a = sender as UserControlQuestion;
            if (a.Questionnumber+1 == actualQuestion)
            { 
            UserAnswears[actualQuestion - 1] = a._isCorrect;

            NextQuestion(sender, e);
            }
        }

        public void NextQuestion(object sender, EventArgs e)
        {
            UserControl a;
            if (actualQuestion > howManyQuestionInQuiz - 1)
            {
                InfoAboutActualQuestion.Content = "";

                int goodAnswer = 0;
                int badAnswer = 0;

                foreach (var item in UserAnswears)
                {
                    if (item == true)
                    {
                        goodAnswer++;
                    }else
                    {
                        badAnswer++;
                    }
                }
                EventHandler handler = ChangeButtonNextquestionEvent;
                 handler(this, e);


                a = new EndQuizUserControl(goodAnswer, UserAnswears.Length);
            }
            else
            {
                InfoAboutActualQuestion.Content = ((actualQuestion +1).ToString() + "/" + howManyQuestionInQuiz.ToString());
                a = new UserControlQuestion(_questions[actualQuestion], QuestionEnded, actualQuestion);
                actualQuestion++;
            }
            if (actualQuestion > 1)
            {
                var b = questionPlace.Children[0] as UserControlQuestion;
                var c = b.TimerGrid.Children[0] as TimerControl;

                var d = c.Animation;
                var g = c.timer;

                
            }
           

            questionPlace.Children.Clear();
            questionPlace.Children.Add(a);
        }
    }
}
