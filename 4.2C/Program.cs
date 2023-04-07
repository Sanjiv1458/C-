using System;

namespace DuplicateCode
{
    class DuplicateCode
    {
        static void Main(string[] args)
        {
            string[] tasksIndividual = new string[0], tasksWork = new string[0], tasksFamilly = new string[0];

            while (true)
            {
                Console.Clear();
                int max = tasksIndividual.Length > tasksWork.Length ? tasksIndividual.Length : tasksWork.Length;
                max = max > tasksFamilly.Length ? max : tasksFamilly.Length;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(new string(' ', 12) + "CATEGORIES");
                Console.WriteLine(new string(' ', 10) + new string('-', 94));
                Console.WriteLine("{0,10}|{1,30}|{2,30}|{3,30}|", "item #", "Personal", "Work", "Family");
                Console.WriteLine(new string(' ', 10) + new string('-', 94));
                for (int i = 0; i < max; i++)
                {
                    Console.Write("{0,10}|", i);

                    if (tasksIndividual.Length > i)
                    {
                        Console.Write("{0,30}|", tasksIndividual[i]);
                    }
                    else
                    {
                        Console.Write("{0,30}|", "N/A");
                    }

                    if (tasksWork.Length > i)
                    {
                        Console.Write("{0,30}|", tasksWork[i]);
                    }
                    else
                    {
                        Console.Write("{0,30}|", "N/A");
                    }

                    if (tasksFamilly.Length > i)
                    {
                        Console.Write("{0,30}|", tasksFamilly[i]);
                    }
                    else
                    {
                        Console.Write("{0,30}|", "N/A");
                    }
                    Console.WriteLine();
                }

                Console.ResetColor();
                Console.WriteLine("\nWhich category do you want to place a new task? Type \'Personal\', \'Work\', or \'Family\'");
                Console.Write(">> ");
                string listName = Console.ReadLine().ToLower();
                Console.WriteLine("Describe your task below (max. 30 symbols).");
                Console.Write(">> ");
                string task = Console.ReadLine();
                if (task.Length > 30) task = task.Substring(0, 30);

                string[] goalsIndividualNew = null;
                if (listName == "personal")
                {
                    goalsIndividualNew = new string[tasksIndividual.Length + 1];
                    for (int j = 0; j < tasksIndividual.Length; j++)
                    {
                        goalsIndividualNew[j] = tasksIndividual[j];
                    }
                    goalsIndividualNew[goalsIndividualNew.Length - 1] = task;
                    tasksIndividual = goalsIndividualNew;
                }
                else if (listName == "work")
                {
                    string[] goalsWorkNew = new string[tasksWork.Length + 1];
                    for (int j = 0; j < tasksWork.Length; j++)
                    {
                        goalsWorkNew[j] = tasksWork[j];
                    }
                    goalsWorkNew[goalsWorkNew.Length - 1] = task;
                    tasksWork = goalsWorkNew;
                }
                else if (listName == "family")
                {
                    string[] goalsFamillyNew = new string[tasksFamilly.Length + 1];
                    for (int j = 0; j < tasksFamilly.Length; j++)
                    {
                        goalsFamillyNew[j] = tasksFamilly[j];
                    }
                    goalsFamillyNew[goalsFamillyNew.Length - 1] = task;
                    tasksFamilly = goalsFamillyNew;
                }
            }
        }
    }
    public class TaskModel
    {
        // Public properties
        public string Description { get; set; }

        public TaskImportance Importance { get; set; }

        public DateTime DueDate(get; set;}

    public TaskModel(string description, DateTime dueDate, TaskImportance importance TaskImportance.Medium)
    {
        Description description;
        Importance importance;
        DueDate dueDate;
    }
    public ConsoleColor GetColor()
    {
        switch (Importance)
        {
            case TaskImportance.Low:
                return ConsoleColor.Green;
            case TaskImportance.Medium:
                return ConsoleColor.Blue;
            case TaskImportance.High:
                return ConsoleColor.Red;
            case Taskimportance.complete:
            default:
                ConsoleColor.DarkGray;
        }
    }


    public class Tasklist
    {
        private List<TaskModel> _tasks;
        public TaskList()
        {
            _tasks - new List<TaskModel>();
        }
        public void AddTask(TaskModel task)
        {
            _tasks.Add(task);
        }
        public void DeleteTask(Taskfodel task)
        {
            _tasks.Remove(task);
        }
        public void Change Priority(int currentIndex, int newIndex)
        {
            TaskModel task new TaskPodel(
                _tasks[currentIndex].Description,
                _tasks[current Index].DueDate,
                _tasks[currentIndex].Importance
            );

            public int GetCount()
            {
                return _tasks.Count;
            }
            public TaskModel TaskAt(int index)
            {
                try
                {
                    return _tasks[index];
                }
                catch (IndexOutofRangeException)
                {
                    throw;
                }
            }
        }
        public class TaskListRepository
        {

            public TasklistRepository()
            {
                _repo new Dictionary<string, Tasklist>();
            }
            public void AddCategory(string category)
            {
                Tasklist tasks = new Tasklist();
                _repo.Add(category, tasks);
            }

            public void DeleteCategory(string category)
            {
                _repo.Remove(category);
            }
            MoveTask(TaskModel task, string current, string updated)
            {
                _repo[current].DeleteTask(task);
            }
        }
        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(new string('-', 12) + "CATEGORIES");
            Console.WriteLine(new string(' ', 10) + new string('-', 51 * _repo.Count));
            Console.Write("(0,10)1", "Item#");
            foreach (var category in _repo.Keys)// Print the category names
            {
                Console.Write("(e,-se)", category);
            }
            Console.WriteLine();
            Console.WriteLine(new string(' ', 10) + new string('-', 51 * _repo.Count));
            for (int i = 0; i < MaximumLength(); i++)
            {
                Console.Write("(0,10)|", 1 + 1);
                foreach (var list in _repo.Values)// Print the list of tasks
                {
                    if (list.GetCount() > 1)
                    {
                        Console.ForegroundColor - list.TaskAt(1).GetColor();
                        // Print white on red background if not complete and due
                        // today or overdue
                        if (list.Taskat(1).DueDate < -DateTime.Today
                              && list.TaskAt(1).Importance I - TaskImportance.Complete)
                        {
                            Console.BackgroundColor ConsoleColor.Red;
                            Console.ForegroundColor ConsoleColor.White;
                        }
                        Console.Write("{0,-30)(1,20)", list.TaskAt(1).Description,list.TaskAt(1).DueDate.Date.ToString("d"));
                        Console.ResetColor();
                        Console.ForegroundColor ConsoleColor.Blue;
                        Console.Write("");
                    }
                    else
                    {
                    Console.Write("(0,-50)|", "N/A");
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();
    }
        public void Run()
        {
    // Add initial default categories
    _taskRepo.AddCategory("work");
    _taskRepo.AddCategory("family");
    _taskRepo.AddCategory("personal");
    do
    {
        Console.Clear();
       _taskRepo.Print();
    PrintMenu();
    _action - ReadUserOption();
    switch (action)
    {
        case MenuOption.AddCategory:
            string category ConsoleInput.ReadString(
                "Name of the category");
            if (1taskRepo.ContainsKey(category))
                _taskRepo.AddCategory(category);
            break;
        case Penooption.Derecetategory:
                category-ConsoleInput.ReadString(
                "Name of the category"); key(category))
                deleteCategory(category);
            break;
}





