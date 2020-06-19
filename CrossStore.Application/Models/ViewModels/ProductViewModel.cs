using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CrossStore.Application.Models.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        private String name;
        private String photo;
        private Decimal price;

        public string Name { get => name; set => SetPropertyAndNotify(ref name, value); }
        public string Photo { get => photo; set => SetPropertyAndNotify(ref photo, value); }
        public decimal Price { get => price; set => SetPropertyAndNotify(ref price, value); }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Dispara notificação apenas se o valor de uma propriedade foi alterada.
        /// </summary>
        /// <typeparam name="T">Tipo da propriedade</typeparam>
        /// <param name="variable">Referencia </param>
        /// <param name="value">Valor a ser atribuido.</param>
        /// <param name="propertyNames">Nome da propriedade para notificar os listeners.  
        /// Nome da propriedade para notificar os listeners.  
        /// Esse valor é opcional porque será preenchido pelo compilador através do CallerMemberName.</param>
        /// <returns>Retorna TRUE se o valor foi alterado.</returns>
        protected bool SetPropertyAndNotify<T>(ref T variable, T value, [CallerMemberName]string propertyName = null)
        {
            if (object.Equals(variable, value))
                return false;

            variable = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        /// Notifica aos listeners que uma determinada propriedade mudou..
        /// </summary>
        /// <param name="propertyNames">Nome da propriedade para notificar os listeners.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
