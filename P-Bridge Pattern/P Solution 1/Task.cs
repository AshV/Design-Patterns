using System;

namespace P_Solution_1
{
    public class Task
    {
        private string description;
        private DateTime duedate;
        private int priority;

        public Task(string description, DateTime duedate, int priority)
        {
            this.description = description;
            this.duedate = duedate;
            this.priority = priority;
        }

        public string getDescription()
        {
            return description;
        }

        public DateTime getDuedate()
        {
            return duedate;
        }

        public int getPriority()
        {
            return priority;
        }

        public override string ToString()
        {
            return "Task [description=" + description + ", duedate=" + duedate + ", priority=" + priority + "]";
        }
    }
}