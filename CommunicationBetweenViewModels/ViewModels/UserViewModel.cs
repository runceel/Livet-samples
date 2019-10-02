using CommunicationBetweenViewModels.Messaging;
using CommunicationBetweenViewModels.Models;
using Livet;
using Livet.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationBetweenViewModels.ViewModels
{
    public class UserViewModel : ViewModel
    {
        private readonly InteractionMessenger _navigationMessenger = NavigationMessenger.Messenger;

        private readonly UserManager _userManager = App.Current.SampleAppContext.UserManager;

        public string Message => _userManager.Message;

        public void NavigateToProductView()
        {
            _navigationMessenger.Raise(new NavigationMessage { ViewName = "ProductView" });
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
