// Updated by XamlIntelliSenseFileGenerator 05/10/2021 02:30:04 p. m.
#pragma checksum "..\..\..\..\..\UI\Consultas\cAportes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9C323343F6955650293640203E26693F73F502E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using P1_AP1_Frankelyn_20190276.UI.Consultas;
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


namespace P1_AP1_Frankelyn_20190276.UI.Consultas
{


    /// <summary>
    /// cAportes
    /// </summary>
    public partial class cAportes : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/P1-AP1-Frankelyn-20190276;V1.0.0.0;component/ui/consultas/caportes.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\..\UI\Consultas\cAportes.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.DatePicker DesdeDatePicker;
        internal System.Windows.Controls.DatePicker HastaDatePicker;
        internal System.Windows.Controls.ComboBox FiltroComboBox;
        internal System.Windows.Controls.TextBox CriterioTextbox;
        internal System.Windows.Controls.Button BuscarButton;
        internal System.Windows.Controls.DataGrid DatosDataGrid;
        internal System.Windows.Controls.TextBox ConteoTextBox;
        internal System.Windows.Controls.TextBox TotalTextBox;
    }
}
