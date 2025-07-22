using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDoItem
    {
       
        public string Title { get; set; }
        public bool isDone { get; set; }

        public ToDoItem(string title) {
         
            Title = title;
            isDone = false;
        }

        public override string ToString() {

            return $"{(isDone ?"[Yes]" : "[No]")} {Title}";

        }
    }

    class Program
    {
        static List<ToDoItem> task = new List<ToDoItem>();
        static void Main(string[] args)
        {

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("----To Do List----");
                Console.WriteLine($"{"These are the core operations of this program, Please select one of them: "}{"\n"} {"1. Add Task "} {"\n"} {"2. View Tasks"}  {"\n"} {"3. Delete Task"} {"\n"} {"4. Exit"} {"\n"}  ");
                string input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;  
                    case "3":
                        DeleteTask();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }

            }
            Console.WriteLine("Thank You !!");

        }
         
       static void AddTask()
        {
            Console.WriteLine("Please write the Task title: ");
            String title = Console.ReadLine();
            task.Add(new ToDoItem(title));
            Console.WriteLine($"The task was Added, press Enter to continue: ");
            Console.WriteLine();
        }

        static void ViewTasks() {
         
;            int count = task.Count;
            if (count == 0)
            {
                Console.WriteLine("The List is empty please Add one!");
            }
            else
            {
                for(int i =0; i < count; i++)
                {
                    Console.WriteLine($"{i+1} {"The Task is :"} {task[i]}");
                }
            }
            Console.WriteLine("Please enter to return to menu:");
            Console.ReadLine();

        }

        static void DeleteTask()
        {
            ViewTasks();

            Console.Write("Enter task number to delete: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= task.Count)
            {
                task.RemoveAt(index - 1);
                Console.WriteLine("Task deleted.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }


    }
}
