using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectSushiShop
{
    internal interface ISushiRepository
    {
        public void AddOrderSushi();
        public void DeleteSushiOrder();
        public void UpdateSushiOrder();
        public void GetViewAllOrderInformation();
        public void SushiSerilizationAndOutProgramm(string jsons);
        public void EmailMessege();
    }
}