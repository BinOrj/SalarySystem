using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem.Interfaces
{
    public interface ILogger
    {
        void LogError();
        void LogInfo();
    }
}
