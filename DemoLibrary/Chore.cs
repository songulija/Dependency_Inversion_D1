using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Chore : IChore
    {
        //we can now have application that is disconected from eachover. nothing 
        //directly depends on higher or lower level classes. instead on interfaces
        ILogger _logger;
        IMessageSender _messageSender;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        //we passed two interfaces into our chore class. and set them to ..
        //then we can use those interfaces to call methods
        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }
        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on { ChoreName }");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            _logger.Log($"Completed { ChoreName }");
            _messageSender.SendMessage(Owner, $"The chore { ChoreName } is complete.");
        }
    }
}
