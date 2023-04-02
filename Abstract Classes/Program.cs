using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<DataAccess> databases = new List<DataAccess>()
            {
                new SQLDataAccess(),
                new SqliteDataAccess()



            };  

        foreach(var db in databases)
            {
            db.LoadConnectionString("demo");
            db.LoadData("select * from Table");
            db.SaveData("Insert into Table");
            Console.WriteLine();
            
            
            }

            

           
          

            Animal dog = new Dog();
            dog.Name = "Max";
            dog.Age = 2;
            dog.MakeSound(); // Output: Woof!

            Animal cat = new Cat();
            cat.Name = "Ivy";
            cat.Age = 5;
            cat.MakeSound(); // Output: Meow!


            Console.ReadLine();


        
        }


    }

}