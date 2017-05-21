using System;
using System.Collections.Generic;

namespace P_Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            tasks.Add(new Task("task1", new DateTime(), 3));
            tasks.Add(new Task("task2", new DateTime(), 2));
            tasks.Add(new Task("task3", new DateTime(), 4));

            AbstractView todoList = new ListView(tasks);
            todoList.setSortStrategy(new PriorityBasedSortStrategy());
            todoList.display();
            todoList = new NumberedView(tasks);
            todoList.display();
        }
    }
}