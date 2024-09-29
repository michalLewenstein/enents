using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Event
    {
        public int Id;
        public string Title;
        public DateTime start;

        private static List<Event> events = new List<Event>() ;
        private static int currentId=1;

        public Event()
        {

        }
        public Event( string Title, DateTime start)
        {
            Id = currentId++;
            this.Title = Title;
            this.start = start;
           
        }

        //כל האירועים
        public static void AllEvent()
        {
            foreach (Event e in events)
            {
                Console.WriteLine($" id:{e.Id} ,Title:{e.Title}, start:{e.start}");
            }
        }
        //הוספת אירוע
        public static void AddEvent(string title, DateTime start) 
        {
           Event e= new Event(title,start);
            events.Add(e);
        }

        //עדכון כותרת אירוע לפי ID

        public static void UpdateTitle(string title, int id) { 
            Event e = events.FirstOrDefault(ev => ev.Id==id);
            if (e!=null)
            {
                e.Title = title;
            }
        }

        //מחיקת אירוע לפי ID

        public static void DeleteEvent(int id)
        {
            Event e = events.FirstOrDefault(ev => ev.Id == id);
            if (e != null)
            {
                events.Remove(e);
            }
            else
            {
                Console.WriteLine($"Event with ID {id} not found!");
            }
        }
    }
}
