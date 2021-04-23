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
    /// Lógica de interacción para LoginDireccion.xaml
    /// </summary>
    public partial class LoginDireccion : Window
    {
        public LoginDireccion()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            MenuPrincipalDireccion menuPrincipalDireccion = new MenuPrincipalDireccion();
            menuPrincipalDireccion.Show();
            this.Close();
        }
    }
}