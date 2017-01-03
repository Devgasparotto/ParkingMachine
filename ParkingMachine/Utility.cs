using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingMachine
{
    class Utility
    {
        public static Action<string[]> HandleCardManualEntrySubmitButtonClick{
            get;
            set;
        }
    }
}
