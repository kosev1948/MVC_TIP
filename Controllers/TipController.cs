using ConsoleMVC.Model;
using ConsoleMVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipMVC.Model;
using TipMVC.View;

namespace ConsoleMVC.Controllers
{
    internal class TipController
    {
        Tip myTip = new Tip();
        Display myDisplay = new Display();
        public TipController()
        {
            myDisplay.Input();

            myTip.Amount = myDisplay.Amount;
            myTip.Percent = myDisplay.Percent;
            
            myDisplay.Tip =  myTip.CalculateTip();

            myDisplay.Total = myTip.CalculateTotal();
            myDisplay.Output();
        }
    }
}
