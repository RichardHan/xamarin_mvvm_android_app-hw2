using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldClock.Core.ViewModels;

namespace WorldClock.Core.Services
{
    public interface IClockService
    {
        List<ClockViewModel> GetClocks();
    }
}
