using System.Collections.Generic;

namespace P_Solution_2
{
public abstract    class AbstractView
    {
        protected List<Task> tasks;
        private ISortStrategy sortStrategy;

        public AbstractView(List<Task> tasks)
        {
            this.tasks = tasks;
            sortStrategy = new UnsortedStrategy();
        }

        public void setSortStrategy(ISortStrategy sortStrategy) {
            this.sortStrategy = sortStrategy;
        }

        public abstract void formattedDisplay();

        public void display()
        {
            sortStrategy.sort(tasks);
            formattedDisplay();
        }
    }
}