﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejer5MVVM.VistaModelo
{
    public class RelayCommand : ICommand
    {
        private Action _action;
        private Action<object, EventArgs> perfomEjecutarNumero;

        public RelayCommand(Action action)
        {
            _action = action;
        }

        //en principio me permite recibir el sender del boton que sea pulsado
        public RelayCommand(Action<object, EventArgs> perfomEjecutarNumero)
        {
           this.perfomEjecutarNumero = perfomEjecutarNumero;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action?.Invoke();
        }
    }

    //Clase que recibe el generico

    public class RelayCommand<T> : ICommand
    {
        public RelayCommand(Action<T> action)
        {
            _action = action;
        }

        private Action<T> _action;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action?.Invoke((T)parameter);
        }
    }
}
