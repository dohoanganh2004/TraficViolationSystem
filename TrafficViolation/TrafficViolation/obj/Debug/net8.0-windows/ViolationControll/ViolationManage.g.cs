﻿#pragma checksum "..\..\..\..\ViolationControll\ViolationManage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BC7B3B5979582B0EE450316D570DAF70593FDF28"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
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
using TrafficViolation.ViolationControll;


namespace TrafficViolation.ViolationControll {
    
    
    /// <summary>
    /// ViolationManage
    /// </summary>
    public partial class ViolationManage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\ViolationControll\ViolationManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchPlate;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\ViolationControll\ViolationManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchName;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\ViolationControll\ViolationManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSortByDate;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\ViolationControll\ViolationManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridViolation;
        
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
            System.Uri resourceLocater = new System.Uri("/TrafficViolation;V1.0.0.0;component/violationcontroll/violationmanage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ViolationControll\ViolationManage.xaml"
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
            this.txtSearchPlate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtSearchName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 34 "..\..\..\..\ViolationControll\ViolationManage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbSortByDate = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            
            #line 44 "..\..\..\..\ViolationControll\ViolationManage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSort_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GridViolation = ((System.Windows.Controls.DataGrid)(target));
            
            #line 49 "..\..\..\..\ViolationControll\ViolationManage.xaml"
            this.GridViolation.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GridViolation_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

