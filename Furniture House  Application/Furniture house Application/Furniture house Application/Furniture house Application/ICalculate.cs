using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture_house_Application
{
    interface ICalculate
    {
        double CalculateAmount(double ActualPrice,int RebatePercent);
    }
}
