﻿#pragma checksum "..\..\..\..\Form\E27FlowDocumentPageViewerControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B155F489D92F3F25AAFA7C6B0AFD48AC999B0B85"
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
    /// E27FlowDocumentPageViewerControl
    /// </summary>
    public partial class E27FlowDocumentPageViewerControl : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\Form\E27FlowDocumentPageViewerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Form\E27FlowDocumentPageViewerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.FlowDocumentPageViewer fdViewer;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Form\E27FlowDocumentPageViewerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.FlowDocumentScrollViewer fdCodeBehind;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF HelloWord;component/form/e27flowdocumentpageviewercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Form\E27FlowDocumentPageViewerControl.xaml"
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
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Form\E27FlowDocumentPageViewerControl.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fdViewer = ((System.Windows.Controls.FlowDocumentPageViewer)(target));
            return;
            case 3:
            this.fdCodeBehind = ((System.Windows.Controls.FlowDocumentScrollViewer)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
