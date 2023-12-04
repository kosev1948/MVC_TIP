using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipMVC.Model
{
     class Tip
    {
        private double amount;
        private double Amout;
        
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public double Percent;
        private double percent


        {
            get { return percent; }
            set {
                if (value>100||value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Invalid percent");
                }
                if(value > 1)
                {
                    percent = value / 100.0;
                }
                else
                {
                    percent=value;
                }
            }
        }
        public Tip(double amount, double percent)
        {
            this.Amount = amount;
            this.Percent = percent;
        }
        public Tip():this(0,0)
        {

        }
        public double CalculateTip()
        {
            return Amount * Percent;

        }
        public double CalculateTotal() 
        {
            return CalculateTotal() + Amount;
        }
    }
}
