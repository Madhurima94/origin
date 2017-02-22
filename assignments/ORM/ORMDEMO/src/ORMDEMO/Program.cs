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
                  db.Products.Add(new ProductTable
                  {
                      ProductName="Mobile Phones",
                      ProductDescription="Mobile Phones are Android types"
                  });
                var count1 = db.SaveChanges();
                  db.Products.Add(new ProductTable
                  {
                      ProductName="Computers",


                  });
                var count2 = db.SaveChanges();
                  db.Products.Add(new ProductTable
                  {
                      ProductName = "Laptops",
                      ProductDescription="These are the Laptops"


                  });
                var count3 = db.SaveChanges();
                  db.Updates.Add(new UpdateTable
                  {
                      UpdateName = "Android Phones",
                      PID=4

                  });
                var count4 = db.SaveChanges();

                db.Updates.Add(new UpdateTable
                {
                    UpdateName = "Nokia Phones",
                    PID = 4

                });

                var count9 = db.SaveChanges();
                db.Products.Update(new ProductTable
                  {
                     PID=3,
                     ProductName="Laptops"
                  });

                var count5 = db.SaveChanges();
                  db.Updates.Update(new UpdateTable
                  {
                      UpdateID = 9,
                      UpdateName = "Lenovo Phones",
                      PID=5

                  });
                var count6 = db.SaveChanges();

                  db.Products.Remove(new ProductTable
                  {
                      PID = 5
                  });

                var count7 = db.SaveChanges();
                db.Updates.Add(new UpdateTable
                {
                    UpdateName = "4G Phones",
                    PID = 3

                });
                var count8 = db.SaveChanges();
                db.Updates.Remove(new UpdateTable
                {
                    UpdateID = 17,
                    PID = 3
                });

                var count = db.SaveChanges();

            }
        }
    }
}
