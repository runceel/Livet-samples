using CommunicationBetweenViewModels.Messaging;
using Livet;
using Livet.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationBetweenViewModels.ViewModels
{
    public class MenuViewModel : ViewModel
    {
        private readonly InteractionMessenger _navigationMessenger = NavigationMessenger.Messenger;

        public void Navigate(string viewName)
        {
            _navigationMessenger.Raise(new NavigationMessage { ViewName = viewName });
        }

        public void Initialize()
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
