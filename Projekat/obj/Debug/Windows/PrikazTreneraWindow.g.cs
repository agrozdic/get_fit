﻿#pragma checksum "..\..\..\Windows\PrikazTreneraWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2ABC097D8DE4AD86E52B412D2E91BC225589BB68E81F96E10AFEE58A49C8A2E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Projekat.Windows;
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


namespace Projekat.Windows {
    
    
    /// <summary>
    /// PrikazTreneraWindow
    /// </summary>
    public partial class PrikazTreneraWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Windows\PrikazTreneraWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGTreneri;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Windows\PrikazTreneraWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPretraga;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Windows\PrikazTreneraWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPretragaIme;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Windows\PrikazTreneraWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OdjavaSaProfila;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Windows\PrikazTreneraWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VratiSe;
        
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
            System.Uri resourceLocater = new System.Uri("/Projekat;component/windows/prikaztrenerawindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\PrikazTreneraWindow.xaml"
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
            this.DGTreneri = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\..\Windows\PrikazTreneraWindow.xaml"
            this.DGTreneri.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.DGTreneri_AutoGeneratingColumn);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblPretraga = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txtPretragaIme = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\Windows\PrikazTreneraWindow.xaml"
            this.txtPretragaIme.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.txtPretragaIme_PreviewKeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OdjavaSaProfila = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Windows\PrikazTreneraWindow.xaml"
            this.OdjavaSaProfila.Click += new System.Windows.RoutedEventHandler(this.bntOdjava_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.VratiSe = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Windows\PrikazTreneraWindow.xaml"
            this.VratiSe.Click += new System.Windows.RoutedEventHandler(this.btnVratiSe_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

