using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PZ_generatory.Quiz
{
    /// <summary>
    /// Interaction logic for Question.xaml
    /// </summary>
    public partial class EndQuizUserControl : UserControl
    {

        public EndQuizUserControl(int goodAnswer,int amountOfQuestions)
        {
            InitializeComponent();  
            int procent = (int)(((double)goodAnswer / (double)amountOfQuestions) * 100 );
            ResultLabel.Content = procent.ToString() +"%";
            string msg = "";
            if (procent == 100)
            {
                msg = "Rewelacja znasz sie na rzeczy harvard stoi otworem";
            }
            else if (procent > 70)
            {
                msg = "No no całkiem nieźle! ";
            }
            else if (procent > 50)
            {
                msg = "No nie jest źle, ważne że zdane :D ";
            }
            else if(procent > 25)
            {
                msg = "No no, kilka pytań było faktycznie dobrze";
            }
            else
            {
                msg = "Musisz jeszcze potrenować ";
            }
            MotywacyjnyLabel.Content = msg;
        }

    }
}
