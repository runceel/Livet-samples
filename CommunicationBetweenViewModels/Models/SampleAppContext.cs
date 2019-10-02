using Livet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationBetweenViewModels.Models
{
    public class SampleAppContext : NotificationObject
    {
        public UserManager UserManager { get; } = new UserManager();
        public ProductManager ProductManager { get; } = new ProductManager();
    }
}
