﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoFinalCorregido
{
    /// <summary>
    /// Lógica de interacción para VentanaHistorialReportes.xaml
    /// </summary>
    public partial class VentanaHistorialReportes : Window
    {
        public VentanaHistorialReportes()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, RoutedEventArgs e)
        {
            VentanaReporte ventanaReporte = new VentanaReporte();
            ventanaReporte.Show();
            this.Close();
        }
    }
}