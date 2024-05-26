using System;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score;
    private int _pointsTotal;

    public GoalManager()
    {

    }

    public void Start()
    {
        string menuSelected = "";

        while (menuSelected != "6") 
        {
            Console.WriteLine($"You have {_pointsTotal} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            menuSelected = Console.ReadLine();

            switch (menuSelected) 
            {
                case "1":

                    Console.WriteLine("The Types of Goals are: ");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    switch (goalType) 
                    {
                        case "1":
                            SimpleGoal newSimpleGoal = new SimpleGoal();
                            newSimpleGoal.CreateChildGoal();
                            goals.addGoal(newSimpleGoal);
                            break;
                        
                        case "2":
                            EternalGoal newEternalGoal = new EternalGoal();
                            newEternalGoal.CreateChildGoal();
                            goals.addGoal(newEternalGoal);
                            break;

                        case "3":
                            ChecklistGoal newChecklistGoal = new ChecklistGoal();
                            newChecklistGoal.CreateChildGoal();
                            goals.addGoal(newChecklistGoal);
                            break;
                        
                        default:
                            Console.WriteLine("Invalid goal type. Please try again.");
                            break;
                    }
                    break;

                case "2":
                    goals.ListGoals();
                    break;

                case "3":
                    goals.SaveGoals();
                    break;

                case "4":
                    goals.LoadGoals();
                    break;

                case "5":
                    goals.RecordEventInTracker();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please select a valid number from the menu options.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int totalAGP = _pointsTotal;
            outputFile.WriteLine(totalAGP.ToString());
            
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresenatation());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear(); 

        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _pointsTotal = Convert.ToInt32(lines[0]);

        for (int i = 1; i < lines.Count(); i++ )
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal") {

                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                _goals.Add(simpleGoal);             

            } else if (parts[0] == "EternalGoal") {

                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                _goals.Add(eternalGoal);

            } else if (parts[0] == "ChecklistGoal") {
                
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]));
                _goals.Add(checklistGoal);

            }
        }
    }
}