﻿#pragma checksum "..\..\VentanaRegistroConductor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "10385BEAD54AE3A33EF301E9200F5E033E85F37EE0DB36B468AD2B1A254F3168"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ProyectoFinalCorregido;
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


namespace ProyectoFinalCorregido {
    
    
    /// <summary>
    /// VentanaRegistroConductor
    /// </summary>
    public partial class VentanaRegistroConductor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\VentanaRegistroConductor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_nombre;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\VentanaRegistroConductor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_apellidoP;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\VentanaRegistroConductor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_apellidoM;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\VentanaRegistroConductor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_numeroLicencia;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\VentanaRegistroConductor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_celular;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\VentanaRegistroConductor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dt_fechaNacimiento;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\VentanaRegistroConductor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_guardar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\VentanaRegistroConductor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button brn_cancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/ProyectoFinalCorregido;component/ventanaregistroconductor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VentanaRegistroConductor.xaml"
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
            this.tb_nombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tb_apellidoP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tb_apellidoM = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb_numeroLicencia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb_celular = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.dt_fechaNacimiento = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.btn_guardar = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\VentanaRegistroConductor.xaml"
            this.btn_guardar.Click += new System.Windows.RoutedEventHandler(this.btn_guardar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.brn_cancelar = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\VentanaRegistroConductor.xaml"
            this.brn_cancelar.Click += new System.Windows.RoutedEventHandler(this.brn_cancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
