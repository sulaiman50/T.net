using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using ConsoleApp1.business_Layer;

namespace ConsoleApp2
{
    public class  Book
    {
        int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        
    }




    internal class Program
    {

        public static readonly CRUD_Operation Operation = new CRUD_Operation();

        static void Main(string[] args)
        {
            
            var result = Operation.GetList();

            foreach (var item in result) 
            {
                Console.WriteLine(item.id + "\t : " + item.Name + "\t : " + item.Page);
            }
            Console.WriteLine("DB has been closed");
        }
    }
}
