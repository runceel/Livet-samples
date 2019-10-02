using CommunicationBetweenViewModels.Models;
using Livet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationBetweenViewModels.ViewModels
{
    public class ProductViewModel : ViewModel
    {
        private readonly ProductManager _productManager = App.Current.SampleAppContext.ProductManager;

        public string Message => _productManager.Message;
        public void Initialize()
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
