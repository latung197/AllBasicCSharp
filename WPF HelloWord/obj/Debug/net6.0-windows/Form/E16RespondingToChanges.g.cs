﻿#pragma checksum "..\..\..\..\Form\E16RespondingToChanges.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8AD2DE9595F01D8C9EEDEA08199D856092B81851"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WPF_HelloWord.Form;


namespace WPF_HelloWord.Form {
    
    
    /// <summary>
    /// E16RespondingToChanges
    /// </summary>
    public partial class E16RespondingToChanges : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Form\E16RespondingToChanges.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddUser;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Form\E16RespondingToChanges.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChangeUser;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Form\E16RespondingToChanges.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteUser;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Form\E16RespondingToChanges.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbUsers;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF HelloWord;component/form/e16respondingtochanges.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Form\E16RespondingToChanges.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnAddUser = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\Form\E16RespondingToChanges.xaml"
            this.btnAddUser.Click += new System.Windows.RoutedEventHandler(this.btnAddUser_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnChangeUser = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Form\E16RespondingToChanges.xaml"
            this.btnChangeUser.Click += new System.Windows.RoutedEventHandler(this.btnChangeUser_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDeleteUser = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\Form\E16RespondingToChanges.xaml"
            this.btnDeleteUser.Click += new System.Windows.RoutedEventHandler(this.btnDeleteUser_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lbUsers = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
