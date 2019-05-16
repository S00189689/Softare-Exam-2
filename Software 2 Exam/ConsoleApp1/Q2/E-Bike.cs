using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class E_Bike:Bike
    {
        private int _power;

        public int Power
        {
            get { return _power; }
            set { _power = value;}
        }


        public E_Bike ()
        {

        }

        public E_Bike (string B, int F, Double P,int PO) : base(B,F,P)
        {
            Power = PO;

        }

        public override string CalcDeposit()
        {
            double d;
            d = Price * 0.10;
            return "the despot is " + d;

        }


        public override string ToString()
        {
            return base.ToString() + "the power is " + Power;
        }


    }
}
