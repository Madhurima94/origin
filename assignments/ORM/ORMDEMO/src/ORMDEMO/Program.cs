using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORMDEMO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db =new Model())
            {
                db.Database.Migrate();
                /*  db.Products.Add(new ProductTable
                  {
                      ProductName="Mobile Phones",
                      ProductDescription="Mobile Phones are Android types"
                  });
                  db.Products.Add(new ProductTable
                  {
                      ProductName="Computers",


                  });
                  db.Products.Add(new ProductTable
                  {
                      ProductName = "Laptops",
                      ProductDescription="These are the Laptops"


                  });
                  db.Updates.Add(new UpdateTable
                  {
                      UpdateName = "Android Phones",
                      PID=1

                  });

                 db.Products.Update(new ProductTable
                  {
                     PID=1,
                     ProductName="Laptops"
                  });

                  db.Updates.Update(new UpdateTable
                  {
                      UpdateID = 1,
                      UpdateName = "Nokia Phones",
                      PID=1

                  });

                  db.Products.Remove(new ProductTable
                  {
                      PID = 1
                  });
                db.Updates.Add(new UpdateTable
                {
                    UpdateName = "4G Phones",
                    PID = 3

                });*/
                db.Updates.Remove(new UpdateTable
                {
                    UpdateID = 7,
                    PID = 3
                });

                var count = db.SaveChanges();

            }
        }
    }
}
