﻿#pragma checksum "..\..\..\TrafficPoliceWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FDFDA869A9C82488CFB2F7B8A4298237830EFF4D"
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
using TrafficViolation.Control;


namespace TrafficViolation {
    
    
    /// <summary>
    /// TrafficPoliceWindow
    /// </summary>
    public partial class TrafficPoliceWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\TrafficPoliceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image UserAvatar;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\TrafficPoliceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btReport;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\TrafficPoliceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btViolation;
        
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
            System.Uri resourceLocater = new System.Uri("/TrafficViolation;component/trafficpolicewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TrafficPoliceWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.UserAvatar = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            
            #line 51 "..\..\..\TrafficPoliceWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewProfile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 52 "..\..\..\TrafficPoliceWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangePassword_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 54 "..\..\..\TrafficPoliceWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Logout_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 64 "..\..\..\TrafficPoliceWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UserManage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btReport = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\TrafficPoliceWindow.xaml"
            this.btReport.Click += new System.Windows.RoutedEventHandler(this.btReport_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btViolation = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\TrafficPoliceWindow.xaml"
            this.btViolation.Click += new System.Windows.RoutedEventHandler(this.btViolation_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 79 "..\..\..\TrafficPoliceWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btComplaint_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 84 "..\..\..\TrafficPoliceWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btNotification_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 89 "..\..\..\TrafficPoliceWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btTransaction_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

