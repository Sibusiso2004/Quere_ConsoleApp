using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quere
{
    public class Customer
    {
        //personal Details
        public string Fullname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        //Order Details
        public string Category { get; set; }
        public string KitType { get; set; }
        public string Size { get; set; }

        public DateTime OrderDate = DateTime.Now;
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public double TotalDiscount { get; set; }
        public double FinalTotalOrderAmount { get; set; }

        //sortout
       


        //methods
        public double CalcBasic()
        {
            double Basicprice = 7699.95;

            TotalPrice = Basicprice * Quantity;
            return TotalPrice;
           
        }


        public double CustomerCategoryDiscount()
        {
            double CustomerDiscount = 0;
            if (Category == "Platinum")
            {
                CustomerDiscount = CalcBasic() * 0.05;
            }
            else if (Category == "Gold")
            {
                CustomerDiscount = CalcBasic() * 0.10;
            }
            else if (Category == "Silver")
            {
                CustomerDiscount = CalcBasic() * 0.05;
            }

            return CustomerDiscount;
        }

        public double CalcChristmasDiscount()
        {
            double ChristmasDiscount = 0;
            if (Gender == "Female")
            {
                ChristmasDiscount = CalcBasic() * 0.08;
            }
            else
            {
                ChristmasDiscount = 0;
            }

            return ChristmasDiscount;

        }

        public double TotalDiscountGiven()
        {
            TotalDiscount = CustomerCategoryDiscount() + CalcChristmasDiscount();
            return TotalDiscount;
        }

        public double FinalTotalAmount()
        {
            FinalTotalOrderAmount = CalcBasic() - TotalDiscountGiven();
            return FinalTotalOrderAmount;
        }















    }
}
