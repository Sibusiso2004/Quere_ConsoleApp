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

           Console.WriteLine("Quere console application");
           Console.WriteLine("Dev: Haides Hagarama");
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
            console.WriteLine("Full name\tSurname\tGender\tCategory\tKitType\tSize\tOrder date\tTotal price\tTotal Discount Amount\tFinal Amount");
            Console.WriteLine(obj.Fullname.ToString()+"\t"+ obj.Surname.ToString()+"\t"+ obj.Gender.ToString()+"\t"+obj.Category.ToString()+"\t"+ obj.KitType.ToString()+"\t"+ obj.Size.ToString()+"\t"+obj.OrderDate.ToString("G")+"\t"+obj.CalcBasic()+"\t"+obj.TotalDiscountGiven()+"\t"+obj.FinalTotalAmount());
           











        }
    }
}
