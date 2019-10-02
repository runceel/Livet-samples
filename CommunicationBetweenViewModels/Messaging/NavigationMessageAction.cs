using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Livet.Messaging;
using Livet.Behaviors.Messaging;
using CommunicationBetweenViewModels.Views;

namespace CommunicationBetweenViewModels.Messaging
{
    public class NavigationMessageAction : InteractionMessageAction<FrameworkElement>
    {
        public ContentControl NavigationHost
        {
            get { return (ContentControl)GetValue(NavigationHostProperty); }
            set { SetValue(NavigationHostProperty, value); }
        }

        public static readonly DependencyProperty NavigationHostProperty =
            DependencyProperty.Register("NavigationHost", typeof(ContentControl), typeof(NavigationMessageAction), new PropertyMetadata(null));


        protected override void InvokeAction(Livet.Messaging.InteractionMessage m)
        {
            if (!(m is NavigationMessage navigationMessage))
            {
                return;
            }

            if (NavigationHost is null)
            {
                throw new InvalidOperationException($"{nameof(NavigationHost)} is null.");
            }

            UserControl view = navigationMessage switch
            {
                { ViewName: "UserView" } => new UserView(),
                { ViewName: "ProductView" } => new ProductView(),
                _ => throw new InvalidOperationException($"{navigationMessage.ViewName} is invalid."),
            };
            if (navigationMessage.ViewModel != null)
            {
                view.DataContext = navigationMessage.ViewModel;
            }

            NavigationHost.Content = view;
        }

        protected override Freezable CreateInstanceCore()
        {
            return new NavigationMessageAction();
        }
    }
}
