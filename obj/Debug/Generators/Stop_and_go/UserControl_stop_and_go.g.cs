﻿#pragma checksum "..\..\..\..\Generators\Stop_and_go\UserControl_stop_and_go.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25EEF8C6DCDF939F0F83604D15334A27332993F0"
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
using PZ_generatory;
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


namespace PZ_generatory {
    
    
    /// <summary>
    /// UserControl_stop_and_go
    /// </summary>
    public partial class UserControl_stop_and_go : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Generators\Stop_and_go\UserControl_stop_and_go.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridStop_and_go;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Generators\Stop_and_go\UserControl_stop_and_go.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackGrid;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Generators\Stop_and_go\UserControl_stop_and_go.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonBackToCAtegoryChoice;
        
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
            System.Uri resourceLocater = new System.Uri("/PZ_generatory;component/generators/stop_and_go/usercontrol_stop_and_go.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Generators\Stop_and_go\UserControl_stop_and_go.xaml"
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
            this.GridStop_and_go = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.StackGrid = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.buttonBackToCAtegoryChoice = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Generators\Stop_and_go\UserControl_stop_and_go.xaml"
            this.buttonBackToCAtegoryChoice.Click += new System.Windows.RoutedEventHandler(this.BackTo_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 36 "..\..\..\..\Generators\Stop_and_go\UserControl_stop_and_go.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Wykorzystaj_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

