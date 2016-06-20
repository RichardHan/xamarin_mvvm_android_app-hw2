using MvvmCross.Plugins.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldClock.Core.Services;
using WorldClock.Core.ViewModels;

namespace WorldClock.Core.Services
{
    public class ClockService : IClockService
    {
        private readonly IMvxMessenger _messenger;
        public ClockService(IMvxMessenger messenger)
        {
            _messenger = messenger;
        }

        public List<ClockViewModel> GetClocks()
        {
            List<ClockViewModel> clocks = new List<ClockViewModel>() {
                new ClockViewModel { Offset = 8 , Name = "Taipei" },
                new ClockViewModel { Offset = -6 , Name = "Central Standard Time" },
            };

            return clocks;
        }
    }
}
