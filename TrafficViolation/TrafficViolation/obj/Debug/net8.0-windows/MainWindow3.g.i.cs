﻿#pragma checksum "..\..\..\MainWindow3.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "808551DCD1B33813B558A3F762041A583894913C"
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
using TrafficViolation;


namespace TrafficViolation {
    
    
    /// <summary>
    /// MainWindow3
    /// </summary>
    public partial class MainWindow3 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\MainWindow3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image UserAvatar;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\MainWindow3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu AvatarMenu;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\MainWindow3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btReport;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\MainWindow3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt2;
        
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
            System.Uri resourceLocater = new System.Uri("/TrafficViolation;component/mainwindow3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow3.xaml"
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
            
            #line 42 "..\..\..\MainWindow3.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Avatar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UserAvatar = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.AvatarMenu = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 4:
            
            #line 48 "..\..\..\MainWindow3.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewProfile_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 49 "..\..\..\MainWindow3.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangePassword_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 51 "..\..\..\MainWindow3.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Logout_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 58 "..\..\..\MainWindow3.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UserManage_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btReport = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\MainWindow3.xaml"
            this.btReport.Click += new System.Windows.RoutedEventHandler(this.btReport_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.bt2 = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\MainWindow3.xaml"
            this.bt2.Click += new System.Windows.RoutedEventHandler(this.btReport_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 61 "..\..\..\MainWindow3.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btReportView_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 62 "..\..\..\MainWindow3.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 63 "..\..\..\MainWindow3.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Logout);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

