﻿#pragma checksum "..\..\..\Quiz\StartQuiz.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1C0507BF4584C639517631B192622605A47E8EFB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using PZ_generatory.Quiz;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PZ_generatory.Quiz {
    
    
    /// <summary>
    /// StartQuiz
    /// </summary>
    public partial class StartQuiz : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Quiz\StartQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MainPage;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Quiz\StartQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel QuestionPlace;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Quiz\StartQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelCategoryChoice;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Quiz\StartQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GoodLuck;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Quiz\StartQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonBackToCAtegoryChoice;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Quiz\StartQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label HowManyQuestionLabel;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Quiz\StartQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label QuestionNumberLabel;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Quiz\StartQuiz.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonStartQuiz;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PZ_generatory;component/quiz/startquiz.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Quiz\StartQuiz.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainPage = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.QuestionPlace = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.LabelCategoryChoice = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.GoodLuck = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.buttonBackToCAtegoryChoice = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Quiz\StartQuiz.xaml"
            this.buttonBackToCAtegoryChoice.Click += new System.Windows.RoutedEventHandler(this.buttonBackToCAtegoryChoice_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HowManyQuestionLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.QuestionNumberLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.buttonStartQuiz = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Quiz\StartQuiz.xaml"
            this.buttonStartQuiz.Click += new System.Windows.RoutedEventHandler(this.buttonQuiz_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

