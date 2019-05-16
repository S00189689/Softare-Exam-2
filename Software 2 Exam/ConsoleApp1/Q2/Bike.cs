using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Bike
    {
        private string _bike_brand;
        private int _frame_number;
        private Double _Price;

        public string Bike_brand
        {
            get { return _bike_brand; }
            set { _bike_brand = value; }
        }

        public int Frame_Number
        {
            get { return _frame_number; }
            set { _frame_number = value; }
        }

        public double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }


        public virtual string CalcDeposit ()
        {
            double d;
            d = Price * 0.30;
            return "the despot is " + d;

        }

        public Bike()
        {

        }

        public Bike (string B,int F,Double P)
        {
            Bike_brand = B;
            Frame_Number = F;
            Price = P;

        }


        public override string ToString()
        {
            return "The Brand" + Bike_brand + " the frame Number is " + Frame_Number + " the price is " + Price;
        }

    }
}
