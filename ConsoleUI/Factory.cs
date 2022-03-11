using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /// <summary>
    /// this class job will be to new up instances when i need them 
    /// one place that has all dependencies. Created static class that news up
    /// 4 different types of types instances that need to have
    /// </summary>
    public class Factory
    {
        //these methods create new instances. and return as IPerson
        public static IPerson CreatePerson()
        {
            //so if for example we want to change what return Person or Employee class
            //there will be no errors. as long as it has same contract(Interface)
            return new Person();
        }
        public static IChore CreateChore()
        {
            //Chore has constructor and needs ILogger,Emailer interfaces to pass
            //i can call methods that will return them 
            return new Chore(CreateLogger(), CreateMessageSender());
        }
        public static ILogger CreateLogger()
        {
            return new Logger();
        }
        public static IMessageSender CreateMessageSender()
        {
            //so now we can just change Emailer to Texter class that both implement from IMessageSender
            //we will not have any error nothing brakes. becouse Chore class did not depent directly on instantiation(new)
            return new Texter();
        }
    }
}
