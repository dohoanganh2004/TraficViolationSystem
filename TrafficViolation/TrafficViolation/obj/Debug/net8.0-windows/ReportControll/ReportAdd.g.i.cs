﻿#pragma checksum "..\..\..\..\ReportControll\ReportAdd.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E92ACFE80A532311E5662CD3DC3CA738B5C2B854"
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
using TrafficViolation.ReportControll;


namespace TrafficViolation.ReportControll {
    
    
    /// <summary>
    /// ReportAdd
    /// </summary>
    public partial class ReportAdd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\ReportControll\ReportAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPlateNumber;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\ReportControll\ReportAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cbViolationType;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\ReportControll\ReportAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescription;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\ReportControll\ReportAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtImageUrl;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\ReportControll\ReportAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVideoUrl;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\ReportControll\ReportAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLocation;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\ReportControll\ReportAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\ReportControll\ReportAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TrafficViolation;V1.0.0.0;component/reportcontroll/reportadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ReportControll\ReportAdd.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtPlateNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cbViolationType = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtImageUrl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtVideoUrl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtLocation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\ReportControll\ReportAdd.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\ReportControll\ReportAdd.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

