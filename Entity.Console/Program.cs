using System;
using Entity.Data;

namespace Entity.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContextFactory factory = new ApplicationDbContextFactory();
            ApplicationDbContext context = factory.Create(new Microsoft.EntityFrameworkCore.Infrastructure.DbContextFactoryOptions());
            
            System.Console.WriteLine("Hello World!");
            bool AddMore = true;
            while (AddMore)
            {
               
                System.Console.Write("\nPeople's Name:");
                string Name = System.Console.ReadLine();
                System.Console.Write("People's Age:");
                int Age = Convert.ToInt32(System.Console.ReadLine());
                context.People.Add(new People { Age = Age, Name = Name });
                context.SaveChanges();
                
                System.Console.Write("Will you continue adding?（press'y'for countinue,press other to quit）:");
                char the = System.Console.ReadKey(true).KeyChar;
                if (the != 'y')
                    AddMore = false;
            }



            System.Console.ReadKey();
        }
    }
}