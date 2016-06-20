using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldClock.Core.ViewModels
{
    public class ClockViewModel : BaseViewModel
    {
        private int _offset;
        public int Offset
        {
            get { return _offset; }
            set { SetProperty(ref _offset, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
    }
}
