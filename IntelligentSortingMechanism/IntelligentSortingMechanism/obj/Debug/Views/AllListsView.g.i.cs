﻿#pragma checksum "..\..\..\Views\AllListsView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2B0BE2AABF957DB34BB9C6F17BB96792"
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
    /// AllListsView
    /// </summary>
    public partial class AllListsView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\AllListsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid all_lists_grid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\AllListsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button new_list_btn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\AllListsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button view_list_btn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\AllListsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock all_lists_header;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\AllListsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delete_list;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\AllListsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit_btn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\AllListsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edit_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/IntelligentSortingMechanism;component/views/alllistsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AllListsView.xaml"
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
            this.all_lists_grid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.new_list_btn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Views\AllListsView.xaml"
            this.new_list_btn.Click += new System.Windows.RoutedEventHandler(this.new_list_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.view_list_btn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Views\AllListsView.xaml"
            this.view_list_btn.Click += new System.Windows.RoutedEventHandler(this.view_list_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.all_lists_header = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.delete_list = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Views\AllListsView.xaml"
            this.delete_list.Click += new System.Windows.RoutedEventHandler(this.delete_list_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.exit_btn = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Views\AllListsView.xaml"
            this.exit_btn.Click += new System.Windows.RoutedEventHandler(this.exit_btn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.edit_btn = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Views\AllListsView.xaml"
            this.edit_btn.Click += new System.Windows.RoutedEventHandler(this.edit_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

