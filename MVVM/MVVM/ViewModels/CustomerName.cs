using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    internal class CustomerName
    {
        private Customer _Customer;
        /// <summary>
        /// Constructor
        /// </summary>
        public CustomerName()
        {
            _Customer = new Customer("David");
        }

        public Customer Customer { 
            get
            {
                return _Customer;
            }
        }

        public ICommand UpdateCommand
        {
            get;

        }

        /// <summary>
        /// Name Changing to Customer Instance
        /// </summary>
        public void SaveChanges()
        {
            Debug.Assert(false, $"{Customer.Name} has been updated");
        }
    }
}
