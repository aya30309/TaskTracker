using System;
using System.Collections.Generic;

namespace Task_Tracker
{
    internal class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("**************************************** Welcome to my Task Tracker ****************************************");



            while (true)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\nEnter your choice from 1 to 5 : ");
                Console.WriteLine("(1) Add Task");
                Console.WriteLine("(2) View All Tasks");
                Console.WriteLine("(3) Mark Task Complete");
                Console.WriteLine("(4) Remove Task");
                Console.WriteLine("(5) Exit");
                Console.Write("Your Choice is : ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewAllTasks();
                        break;
                    case "3":
                        MarkTaskComplete();
                        break;
                    case "4":
                        RemoveTask();
                        break;
                    case "5":
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Please Enter A Number From 1 To 5 Only.");
                        break;
                }
            }
        }

        private static void AddTask()
        {
            Console.Write("Enter Task Title: ");
            string taskTitle = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(taskTitle))
            {
                tasks.Add(taskTitle);
                Console.WriteLine("Task added successfully!");
            }
            else
            {
                Console.WriteLine("Task title cannot be empty.");
            }
        }

        private static void ViewAllTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("######## Task list ########");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"Task {i + 1}: {tasks[i]}");
            }
        }

        private static void MarkTaskComplete()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available to mark as complete.");
                return;
            }

            Console.Write("Enter the task number to mark as complete: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks[taskNumber - 1] += " --COMPLETED";
                Console.WriteLine("Task marked as complete.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        private static void RemoveTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available to remove.");
                return;
            }

            Console.Write("Enter the task number to remove: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        private static void Exit()
        {
            Console.WriteLine("Exiting the Task Tracker. Goodbye!");
            Environment.Exit(0);
        }
    }
}
