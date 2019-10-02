using Livet.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommunicationBetweenViewModels.Messaging
{
    public class NavigationMessage : InteractionMessage
    {


        public string ViewName
        {
            get { return (string)GetValue(ViewNameProperty); }
            set { SetValue(ViewNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ViewName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ViewNameProperty =
            DependencyProperty.Register("ViewName", typeof(string), typeof(NavigationMessage), new PropertyMetadata(null));

        public INotifyPropertyChanged ViewModel
        {
            get { return (INotifyPropertyChanged)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ViewModel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(INotifyPropertyChanged), typeof(NavigationMessage), new PropertyMetadata(null));

        public NavigationMessage()
        {
        }

        public NavigationMessage(string messageKey) : base(messageKey)
        {
        }

        protected override Freezable CreateInstanceCore()
        {
            return new NavigationMessage();
        }
    }
}
