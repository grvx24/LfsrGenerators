using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_generatory.AdminPanel
{
    class CategoryInfo:Category, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string howManyQuestionsInCategory;

        public string HowManyQuestionsInCategory
        {
            get { return howManyQuestionsInCategory; }
            set
            {
                howManyQuestionsInCategory = value;
                onPropertyChanged("howManyQuestionsInCategory");
            }
        }

        private void onPropertyChanged(string propertyName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public CategoryInfo()
        {

        }

        public CategoryInfo (Category category, int howManyQuestionsInCategory)
        {
            this.ID = category.ID;
            this.CategoryName = category.CategoryName;
            this.HowManyQuestionsInCategory = howManyQuestionsInCategory.ToString();
        }
    }
}
