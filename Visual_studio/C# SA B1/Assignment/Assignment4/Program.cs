using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Here:

            try
            {
                Console.WriteLine("Write a Console Program with the following output.");
                Console.WriteLine("1. Add New Product");
                Console.WriteLine("2. Show Product List");
                Console.WriteLine("3. Update the existing Product");
                Console.WriteLine("4. Delete the existing Product");
                Console.WriteLine("5. Exit");

                AddNewProduct add = new AddNewProduct();
                ShowProductList show = new ShowProductList();
                UpdateExistingProduct update = new UpdateExistingProduct();
                DeleteExistingProduct delete = new DeleteExistingProduct();
                ColumnsName name = new ColumnsName();

                Console.Write("Select the Operation(1,2,3,4,5) : ");
                int operation = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case 1: name.GetInformation(); add.AddProduct(name); break;
                    case 2: show.ShowProduct(); break;
                    case 3: name.GetInformation(); show.ShowProduct(); update.UpdateProduct(name); break;
                    case 4: name.GetInformation(); show.ShowProduct(); delete.DeleteProduct(name); break;
                    case 5: Console.WriteLine("Press to any key."); Console.ReadKey(); break;
                    default: Console.WriteLine("Your enter operation error occur!"); break;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur " + error.Message);
                goto Here;
            }
        } 
    }
}
