﻿#pragma checksum "..\..\..\Views\AddTaskView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3FAC2ADAFC1539EE3A1051A619B0AFB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IntelligentSortingMechanism.Views;
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


namespace IntelligentSortingMechanism.Views {
    
    
    /// <summary>
    /// AddTaskView
    /// </summary>
    public partial class AddTaskView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\AddTaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label task_desc_lbl;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Views\AddTaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label task_deadline_lbl;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\AddTaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label task_priority_lbl;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\AddTaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock add_task_header;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\AddTaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox task_desc_box;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Views\AddTaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker task_deadline_date;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\AddTaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox task_priority_combo;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\AddTaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back_btn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\AddTaskView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_task_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/IntelligentSortingMechanism;component/views/addtaskview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddTaskView.xaml"
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
            this.task_desc_lbl = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.task_deadline_lbl = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.task_priority_lbl = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.add_task_header = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.task_desc_box = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.task_deadline_date = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.task_priority_combo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.back_btn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Views\AddTaskView.xaml"
            this.back_btn.Click += new System.Windows.RoutedEventHandler(this.back_btn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.add_task_btn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Views\AddTaskView.xaml"
            this.add_task_btn.Click += new System.Windows.RoutedEventHandler(this.add_task_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

