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
using System.Windows.Navigation;
using System.Windows.Shapes;

//Los comento porque ninguno hace que compile

//using VistaModelo;
//using Ejer5MVVM.VistaModelo;
//using Ejer5MVVM.VistaModelo.VistaModelo;
namespace Ejer5MVVM
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Añadimos el contexto de Datos para que Vista y ViewModel se encuentren conectados
            var vm = new VistaModelo();
            DataContext = vm;
        }
    }
}
