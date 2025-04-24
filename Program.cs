using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quere
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();

           
            //this is a long reminder. its been 3 years since i coded a console application, so computer.... please bare with me on this one.
            Console.Write("Enter your name please: ");
            obj.Fullname = Console.ReadLine();

            Console.Write("Enter your surname please: ");
            obj.Surname = Console.ReadLine();

            Console.Write("Enter your email please: ");
            obj.Email = Console.ReadLine();

            Console.Write("Enter your Gender { Male/Female }: ");
            obj.Gender = Console.ReadLine();

            Console.Write("Enter your Catergory { Platinum/Gold/Silver }: ");
            obj.Category = Console.ReadLine();

            Console.Write("Enter your Kit type { Classic/Modern }: ");
            obj.KitType = Console.ReadLine();

            Console.Write("Enter your Kit size { Small/Medium/Large }: ");
            obj.Size = Console.ReadLine();

            Console.Write("Enter the quantity: ");
            obj.Quantity =int.Parse(Console.ReadLine());

            //run Methods
            obj.CalcBasic();
            obj.CustomerCategoryDiscount();
            obj.CalcChristmasDiscount();
            obj.TotalDiscountGiven();
            obj.FinalTotalAmount();

            //print
            Console.WriteLine("");
            Console.WriteLine(".............Quote.............");
            Console.WriteLine("");
            Console.WriteLine("Full Name: "+ obj.Fullname.ToString());
            Console.WriteLine("Surname: " + obj.Surname.ToString());
            Console.WriteLine("Gender: " + obj.Gender.ToString());
            Console.WriteLine("Category: " + obj.Category.ToString());
            Console.WriteLine("KitType: " + obj.KitType.ToString());
            Console.WriteLine("Size: " + obj.Size.ToString());
            Console.WriteLine("Order Date: " + obj.OrderDate.ToString("G"));
            Console.WriteLine("Total Price: R " + obj.CalcBasic());
            Console.WriteLine("Total Discount Amount: R " + obj.TotalDiscountGiven());
            Console.WriteLine("Final Amount: R " + obj.FinalTotalAmount());












        }
    }
}
