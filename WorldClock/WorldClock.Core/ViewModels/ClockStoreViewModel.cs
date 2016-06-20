using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldClock.Core.Services;

namespace WorldClock.Core.ViewModels
{
    public class ClockStoreViewModel : BaseViewModel
    {
        private IClockService _clockService;

        public ClockStoreViewModel(IClockService clockService)
        {
            _clockService = clockService;
        }

        private List<ClockViewModel> _clocks = null;

        public List<ClockViewModel> Clocks
        {
            get
            {
                if (_clocks == null)
                {
                    _clocks = _clockService.GetClocks();
                }
                return _clocks;
            }
        }
    }
}
