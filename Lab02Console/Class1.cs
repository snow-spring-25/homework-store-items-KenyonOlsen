using System.Data.Common;
using Lab02Logic;


TaskManager Manager = new TaskManager();

void PrintUI()
{
    Console.Clear();
    Console.WriteLine("     ID  Task");
    Console.WriteLine("     --  ----");
    foreach (var task in Manager.TaskList)
    {
        Console.Write(" [");
        if (task.IsComplete)
        {
            Console.Write("X");
        }
        else
        {
            Console.Write(" ");
        }
        Console.Write("] ");
        Console.Write($"{task.ID}   ");
        Console.WriteLine(task.Title);
    }
    Console.WriteLine("Press '+' to add a task. Press 'i' to view a task's information. Press 'c' to complete a task.  ");
    string input = Console.ReadLine();
    if (input == "+")
    {
        CreateTask();
    }
    else if (input == "i")
    {
        Displayinfo();
    }
    else if (input == "c")
    {
        CompleteTask();
    }
}

void CreateTask()
{
    Console.WriteLine("Please enter the task title: ");
    string title = Console.ReadLine();
    Console.WriteLine("Please enter the task description: ");
    string description = Console.ReadLine();
    Manager.AddTask(title, description);
}

void Displayinfo()
{
    Console.WriteLine("Enter the ID of the task.");
    if (int.TryParse(Console.ReadLine(), out int IDnum))
    {
        Console.WriteLine($"{Manager.TaskList[IDnum-1].Title} {Manager.TaskList[IDnum - 1].Description}");
    }

}

void CompleteTask()
{
    Console.WriteLine("Enter the ID of the task.");
    if (int.TryParse(Console.ReadLine(), out int IDnum))
    {
        Manager.ToggleTaskComplete(IDnum);
    }

}
while (true)
{


    PrintUI();
    Console.WriteLine("Press any key to continue.");
    Console.ReadKey(true);
}