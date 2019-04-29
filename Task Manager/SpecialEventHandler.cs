using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    public class SpecialEventHandler
    {
        List<Tuple<DateTime, Type>> eventData;

        //Creates and initializes a special event handler
        public SpecialEventHandler()
        {
            //Intermediary attributes
            int currentYear = DateTime.Now.Year;

            //Initialize event dates list
            eventData = new List<Tuple<DateTime, Type>>();

            //Add special events here...
            eventData.Add(new Tuple<DateTime, Type>(new DateTime(currentYear, 2, 14), typeof(ValentinesTaskManagerForm)));
            eventData.Add(new Tuple<DateTime, Type>(new DateTime(currentYear, 10, 31), typeof(HalloweenTaskManagerForm)));
            eventData.Add(new Tuple<DateTime, Type>(new DateTime(currentYear, 12, 25), typeof(ChristmasTaskManagerForm)));
        }

        //Returns event value for the specified date
        //If the specified date has no event default event value is returned
        public Type GetEventValue(DateTime date)
        {
            //For each set of event information in the event data
            foreach(Tuple<DateTime, Type> eventInformation in eventData)
            {
                //If the current day is the event
                if(date == eventInformation.Item1)
                {
                    //Return event data
                    return eventInformation.Item2;
                }
            }

            //Return default event value
            return typeof(TaskManagerForm);
        }
    }
}
