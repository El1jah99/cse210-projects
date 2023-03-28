using System;
namespace GoalSetter
{
    public class Program
        {
            public static void Main(string[] args)
            {
                Dictionary<String, Command> commands = new Dictionary<string, Command>();

                Repository repo = new InMemoryRepository();
                
                commands["1"] = new GoalCommand(repo);
                

                Command c = new Command(repo);
                c.Execute();

                Goal SimpleGoal = new SimpleGoal("Exercise",
                "I will exerise tomorrow", 1000);


                repo.Add(SimpleGoal);
                int numberOfGoals = repo.GetAll().Count;

                Console.WriteLine($"There are {numberOfGoals} in the system");

                SimpleGoal.MarkComplete(
                    Console.WriteLine(SimpleGoal.ToString())
                );
            }
        }
}