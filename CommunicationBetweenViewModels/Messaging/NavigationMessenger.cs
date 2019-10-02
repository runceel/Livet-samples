using Livet.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationBetweenViewModels.Messaging
{
    public static class NavigationMessenger
    {
        public static InteractionMessenger Messenger { get; } = new InteractionMessenger();
    }
}
