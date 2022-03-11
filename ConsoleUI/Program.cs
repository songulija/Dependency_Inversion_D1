using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /// <summary>
    /// whenever you do NEW. i try to break those dependencies on lower
    /// level modules, and instead working with interfaces
    /// dependency injection is one of ways to make principle work. to not use new
    /// </summary>
    class Program
    {
        //what essentialy Dependency Inversion is that everything is disconected
        //and everything talking to interfaces. SOLID means everythinng is diconected 
        //everything is replacable, everything is modular. so you dont have to replace
        //whole car you can just replace small part like wheel
        static void Main(string[] args)
        {
            //now we use interface but still dependent on Person class
            //i havent inverted dependecies. program.cs still depends on person class
            //even if assigning to interface var

            //now 
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Tim";
            owner.LastName = "Corey";
            owner.EmailAddress = "tim@iamtimcorey.com";
            owner.PhoneNumber = "555-1212";

            //this method creates new chore and returns it as IChore
            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
