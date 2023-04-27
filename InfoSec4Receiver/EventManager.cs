using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSec4Receiver
{
    public class EventManager
    {
        public static event Action onInformationReceived;
        public static void InformationReceived()
        {
            onInformationReceived?.Invoke();
        }
    }
}
