using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace PZ_generatory.Quiz
{
    public partial class TimerControl : UserControl
    {
        EventHandler CallBack;
        public TimerControl(int time, EventHandler callBack)
        {
            InitializeComponent();
            timer.Maximum = time;
            Animation.Duration = new Duration(new System.TimeSpan(0, 0, time));
            this.CallBack = callBack;
            Animation.Completed += (sender, eArgs) => callBack(sender, eArgs);
        }

        public void stop()
        {

        }
    }
}
