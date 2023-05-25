using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.business_Layer 
{
    public class CRUD_Operation : BaseR
    {

        public static readonly CRUD_Operation Instance = new CRUD_Operation();

        public List<Book> GetList() 
        { 
        
             var con = GetConnection();
             var Querys = "SELECT * FROM book";

             var cmd = new SqlCommand(Querys, con);

            var result = GetBooks(cmd, con);

            return result;
        
        }

    }
}
