﻿#pragma checksum "..\..\..\..\ComplaintControll\ComplaintManage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CCA77C17B7E31B55D25C0A1C1DD5B933C3670406"
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


namespace TrafficViolation.ComplaintControll {
    
    
    /// <summary>
    /// ComplaintManage
    /// </summary>
    public partial class ComplaintManage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\ComplaintControll\ComplaintManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchName;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\ComplaintControll\ComplaintManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridComplaint;
        
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
            System.Uri resourceLocater = new System.Uri("/TrafficViolation;V1.0.0.0;component/complaintcontroll/complaintmanage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ComplaintControll\ComplaintManage.xaml"
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
            this.txtSearchName = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\..\ComplaintControll\ComplaintManage.xaml"
            this.txtSearchName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridComplaint = ((System.Windows.Controls.DataGrid)(target));
            
            #line 36 "..\..\..\..\ComplaintControll\ComplaintManage.xaml"
            this.gridComplaint.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GridComplaint_SelecionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

