﻿#pragma checksum "..\..\..\..\Form\E36TabControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9D9C5A9A153077B0F5AC38C5A6651D05E20E1F18"
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
    /// E36TabControl
    /// </summary>
    public partial class E36TabControl : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\..\Form\E36TabControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPreviousTab;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Form\E36TabControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNextTab;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Form\E36TabControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelectedTab;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Form\E36TabControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tcSample;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF HelloWord;V1.0.0.0;component/form/e36tabcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Form\E36TabControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnPreviousTab = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\Form\E36TabControl.xaml"
            this.btnPreviousTab.Click += new System.Windows.RoutedEventHandler(this.btnPreviousTab_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnNextTab = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\Form\E36TabControl.xaml"
            this.btnNextTab.Click += new System.Windows.RoutedEventHandler(this.btnNextTab_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSelectedTab = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\Form\E36TabControl.xaml"
            this.btnSelectedTab.Click += new System.Windows.RoutedEventHandler(this.btnSelectedTab_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tcSample = ((System.Windows.Controls.TabControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

