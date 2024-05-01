using System;

public class Resume
    {
        public string _name;
        public List<Job> _jobs = new List<Job>();


        public void GetDisplay()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Work Experience: ");
            Console.WriteLine();

            foreach (Job job in _jobs)
            {
                job.GetDisplay();
            }

        }

    }
