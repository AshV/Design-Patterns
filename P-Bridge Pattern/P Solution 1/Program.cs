using System;

namespace P_Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoList todolist = new ToDoList();
            todolist.addTask(new Task("task1", new DateTime(), 3));
            todolist.addTask(new Task("task2", new DateTime(), 2));
            todolist.addTask(new Task("task3", new DateTime(), 4));
            todolist.setSortStrategy(new PriorityBasedSortStratrgy());
            todolist.setViewStrategy(new ListView());
            todolist.display();
            todolist.setViewStrategy(new NumberedView());
            todolist.display();
        }
    }
}