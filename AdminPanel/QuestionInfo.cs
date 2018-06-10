using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_generatory.AdminPanel
{
    class QuestionInfo:Question, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string categoryName;

        public string CategoryName
        {
            get { return categoryName; }
            set
            {
                categoryName = value;
                onPropertyChanged("categoryName");
            }
        }

        private void onPropertyChanged(string propertyName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public QuestionInfo()
        {

        }

        public QuestionInfo(Question question)
        {
            this.CategoryName = categoryName;
            this.Id = question.Id;
            this.Content = question.Content;
            this.Time = question.Time;
            this.CategoryName = question.Category.CategoryName;
        }
    }
}
