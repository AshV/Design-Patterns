using System.Collections.Generic;

namespace P_Solution_1
{
    public class ToDoList
    {
        private List<Task> tasks;
        private ISortStrategy sortStrategy;
        private IViewStrategy viewStrategy;

        public ToDoList()
        {
            tasks = new List<Task>();
        }

        public void addTask(Task task)
        {
            tasks.Add(task);
        }

        public void setSortStrategy(ISortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void setViewStrategy(IViewStrategy viewStrategy)
        {
            this.viewStrategy = viewStrategy;
        }

        public void display()
        {
            sortStrategy.sort(tasks);
            viewStrategy.formattedDisplay(tasks);
        }
    }
}