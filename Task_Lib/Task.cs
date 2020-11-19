using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_Lib
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public State State { get; set; }
    }

    public enum State
    {
        Open,
        InProgress,
        Close
    }
    public class Tasks
    {
        List<Task> tasks = new List<Task>();
        public void AddTask()
        {

  
            
        }
    }
}
