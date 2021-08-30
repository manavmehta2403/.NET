using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class Customer : INotifyPropertyChanged
    {
        private String _Name;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="customerName"></param>
        public Customer(String customerName)
        {
            _Name = customerName;
        }

        /// <summary>
        /// Getter and Setter
        /// </summary>
        public String Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
