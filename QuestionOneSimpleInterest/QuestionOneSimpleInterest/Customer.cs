using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionOneSimpleInterest
{
    class Customer
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Address { get; set; }
        private decimal principal;
        private double rate;
        private int time;

        public Customer(string name, int id, string address, decimal princ, double ra, int tim)
        {
            Name = name;
            ID = id;
            Address = address;
            Principal = princ;
            Rate = ra;
            Time = tim;
        }

        public decimal Principal
        {
            get { return principal; }
            set
            {
                if(value >= 0)
                {
                    principal = value;
                }                
            }
        }

        public double Rate
        {
            get { return rate; }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    rate = value;
                }
            }
        }

        public int Time
        {
            get { return time; }
            set
            {
                if(value >= 0)
                {
                    time = value;
                }
            }
        }
        public override string ToString()
        {
            return $"Name: {Name}\nID: {ID}\nAddress: {Address}\nPrincipal: {Principal}\nRate: {Rate}\nTime:{Time}"; 
        }

    }   
}
