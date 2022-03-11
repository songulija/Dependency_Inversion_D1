using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //texter just class that implements IMessageSender interface
    public class Texter : IMessageSender
    {
        //instead of "emailing"we now "texting". method changes slightly
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"I am texting {person.FirstName} to say {message}");
        }
    }
}
