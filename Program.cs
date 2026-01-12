using System;
using System.Collections.Generic;


// First real .NET project - ToDoApp



List<string> tasks = new List<string>();
bool running = true;

while (running)
{
    ShowMenu();
    string choice = Console.ReadLine();

    switch (choice)
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
            running = false;
            break;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }

    Console.WriteLine();
}

void ShowMenu()
{
    Console.WriteLine("===== To Do App =====");
    Console.WriteLine("1 - Add Task");
    Console.WriteLine("2 - View Tasks");
    Console.WriteLine("3 - Delete Task");
    Console.WriteLine("4 - Exit");
    Console.Write("Choose an option: ");
}

void AddTask()
{
    Console.Write("Enter task name: ");
    string task = Console.ReadLine();
    tasks.Add(task);
    Console.WriteLine("Task added successfully!");
}

void ViewTasks()
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks found.");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {tasks[i]}");
    }
}

void DeleteTask()
{
    ViewTasks();
    Console.Write("Enter task number to delete: ");

    if (int.TryParse(Console.ReadLine(), out int index))
    {
        if (index > 0 && index <= tasks.Count)
        {
            tasks.RemoveAt(index - 1);
            Console.WriteLine("Task deleted!");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
}
