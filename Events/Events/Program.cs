using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event.AddEvent("Meeting with Team", DateTime.Now.AddDays(1));
            Event.AddEvent("Doctor Appointment", DateTime.Now.AddDays(3));
            Event.AddEvent("Project Deadline", DateTime.Now.AddDays(7));
            Event.AddEvent("Family Dinner", DateTime.Now.AddDays(5));

            Event.AllEvent();

            Event.AddEvent("llll ", DateTime.Now.AddDays(9));


        }
    }
}
