using System;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _pointsTotal;

    // Moved this variable from Goal Manager to Goals and will add method to get the score to be called here.
    // private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        string menuSelected = "";

        while (menuSelected != "6") 
        {
            DisplayPlayerInfo();
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
                    CreateGoal();
                    break;

                case "2":
                    ListGoalNames();
                    break;

                case "3":
                    SaveGoals();
                    break;

                case "4":
                    LoadGoals();
                    break;

                case "5":
                    RecordEvent();
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
        // _pointsTotal = Goal.GetPointTotal();
        Console.WriteLine($"You have {_pointsTotal} points.");
        Console.WriteLine();
    }

    public void ListGoalNames()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("\nYour Goals are:");

            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }
        else
        {
            Console.WriteLine("\nYou currently have no goals!");
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("\nYour Goals are:");

            foreach (Goal goal in _goals)
            {
                goal.GetDetailsString();
            }
        }
        else
        {
            Console.WriteLine("\nYou currently have no goals!");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The Types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        switch (goalType) 
        {
            case "1":
                // Simple goal creation
                Console.WriteLine("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal? ");
                string description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                SimpleGoal newSimpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(newSimpleGoal);
                break;
            
            case "2":
                Console.WriteLine("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal? ");
                description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine());

                EternalGoal newEternalGoal = new EternalGoal(name, description, points);
                _goals.Add(newEternalGoal);
                break;

            case "3":
                Console.WriteLine("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal? ");
                description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                int numberTimes = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accomplishing completing each iteration of this goal? ");
                int bonus = int.Parse(Console.ReadLine());

                ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, points, numberTimes, bonus);
                _goals.Add(newChecklistGoal);
                break;
            
            default:
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
        }
    }

    public void RecordEvent()
    {
        int i = 1;
        foreach(Goal goal in _goals)
        {
            string goalName = goal.GetDetailsString();
            Console.WriteLine($"{i}. {goalName}");
            i++;
        }
        Console.WriteLine("Which goal number did you accomplish?");
        int workDone = int.Parse(Console.ReadLine()) - 1;

        _goals[workDone].RecordEvent();

        _pointsTotal += _goals[workDone].GetPointTotal();
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

            if (parts[0] == "SimpleGoal") 
            {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), parts[4]);
                _goals.Add(simpleGoal);             

            }
            else if (parts[0] == "EternalGoal") 
            {
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                _goals.Add(eternalGoal);
            }
            else if (parts[0] == "ChecklistGoal") 
            {    
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]));
                _goals.Add(checklistGoal);
            }
        }
    }
}