﻿#pragma checksum "..\..\..\..\..\UI\Registros\rAportes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65EC441CBC69C04CC29AE1440F076F2E46543169"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using P1_AP1_Frankelyn_20190276.UI.Registros;
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


namespace P1_AP1_Frankelyn_20190276.UI.Registros {
    
    
    /// <summary>
    /// rAportes
    /// </summary>
    public partial class rAportes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\..\UI\Registros\rAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AporteIdTextbox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\UI\Registros\rAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BuscarButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\UI\Registros\rAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FechaDatePicker;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\UI\Registros\rAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PersonaTextbox;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\UI\Registros\rAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConceptoTextbox;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\..\UI\Registros\rAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MontoTextbox;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\..\UI\Registros\rAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NuevoButton;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\..\UI\Registros\rAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GuardarButton;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\..\UI\Registros\rAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EliminarButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/P1-AP1-Frankelyn-20190276;V1.0.0.0;component/ui/registros/raportes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Registros\rAportes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AporteIdTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BuscarButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\UI\Registros\rAportes.xaml"
            this.BuscarButton.Click += new System.Windows.RoutedEventHandler(this.BuscarButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FechaDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.PersonaTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ConceptoTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.MontoTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.NuevoButton = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\..\..\UI\Registros\rAportes.xaml"
            this.NuevoButton.Click += new System.Windows.RoutedEventHandler(this.NuevoButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.GuardarButton = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\..\..\UI\Registros\rAportes.xaml"
            this.GuardarButton.Click += new System.Windows.RoutedEventHandler(this.GuardarButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.EliminarButton = ((System.Windows.Controls.Button)(target));
            
            #line 121 "..\..\..\..\..\UI\Registros\rAportes.xaml"
            this.EliminarButton.Click += new System.Windows.RoutedEventHandler(this.EliminarButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

