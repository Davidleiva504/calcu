using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using queso.Models;

namespace ViewModels
{
    public class ViewModels: INotifyPropertyChanged
    {
        int n1;
        int n2;
        string total;

        public ViewModels()
        {
            sumar = new Command(() =>
            {
                Models C = new Models()
                {
                   n1 = this.n1,
                   n2 = this.n2,
                };
                TT = C.sumar().ToString();
            });

            Resta = new Command(() =>
            {
                Models C = new Models()
                {
                    n1 = this.n1,
                    n2 = this.n2,
                };
                TT = C.Resta().ToString();
            });

            division = new Command(() =>
            {
                Models C = new Models()
                {
                    n1 = this.n1,
                    n2 = this.n2,
                };
                TT = C.division().ToString();
            });

            multiplicar = new Command(() =>
            {
                Models C = new Models()
                {
                    n1 = this.n1,
                    n2 = this.n2,
                };
                TT = C.multiplicar().ToString();
            });
        }

       
        public int Nm1
        {
            get => n1;
            set
            {
               n1 = value;
                var argsEvent = new PropertyChangedEventArgs(nameof(Nm1));
                PropertyChanged?.Invoke(this, argsEvent);
            }
        }
        public int Nm2
        {
            get => n2;
            set
            {
                n2 = value;
                var argsEvent = new PropertyChangedEventArgs(nameof(Nm2));
                PropertyChanged?.Invoke(this, argsEvent);
            }
        }

        public string TT
        {
            get => total;
            set
            {
                total = value;
                var argsEvent = new PropertyChangedEventArgs(nameof(TT));
                PropertyChanged?.Invoke(this, argsEvent);
            }
        }

        public Command sumar { get; }
        public Command Resta { get; }
        public Command division { get; }
        public Command multiplicar { get; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
    

}
