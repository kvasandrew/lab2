using Lab3TaskManager;

Console.WriteLine("TaskManager is starting");
var taskManager = new TaskManagement();
var task = new Lab3TaskManager.Task();
var task2 = new Lab3TaskManager.Task("Test", "Test", "Low", false);
taskManager.AddTask(task);
taskManager.AddTask(task2);

Console.WriteLine("Adding tasks to taskmanager:");
taskManager.GetAllTasks();

taskManager.AddTaskPriority(task.Title, "High");
Console.WriteLine($"Change Prioriry for task: {task.Title}");
taskManager.ShowTask(0);

taskManager.RemoveTaskPriority(task.Title);
Console.WriteLine($"Remove Prioriry for task: {task.Title}");
taskManager.ShowTask(0);

taskManager.AddTaskToFavorite(task.Title);
Console.WriteLine($"Adding task {task.Title} to Favorite ");
taskManager.ShowTask(0);

taskManager.RemoveTaskFromFavorite(task.Title);
Console.WriteLine($"Removing task {task.Title} from Favorite ");
taskManager.ShowTask(0);

taskManager.RemoveTask(task.Title);
Console.WriteLine($"Removing task {task.Title} from List:");
taskManager.GetAllTasks();

Console.WriteLine("All Tests Done!");