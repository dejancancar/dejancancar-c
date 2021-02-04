using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tasks.Models
{

    public class TaskList
    {
        private const string FILE_SEPARATOR_CHARACTERS = "|||";
        //This is where our working list of tasks is stored
        private List<Task> taskList = new List<Task>();
        private int maxId = 0;

        /// <summary>
        /// Public access to the list of tasks
        /// </summary>
        public Task[] List
        {
            get
            {
                return this.taskList.ToArray();
            }
        }

        public int Count
        {
            get
            {
                return this.taskList.Count;
            }
        }

        /// <summary>
        /// This points to the file that persistently holds our tasks.
        /// </summary>
        public string Path { get; }
        /// <summary>
        /// Creates a new TaskList object
        /// </summary>
        /// <param name="path">Path to the file that stores task info</param>
        public TaskList(string path)
        {
            this.Path = path;
            Load();
        }

        /// <summary>
        /// Saves all the Tasks that are in the list into a file at Path
        /// </summary>
        /// <returns></returns>
        private bool Save()
        {
            try
            {
                //Open the file for overwrite
                using(StreamWriter writer = new StreamWriter(Path, false))
                {
                    foreach (Task task in this.taskList)
                    {
                        string outputLine = string.Join(FILE_SEPARATOR_CHARACTERS, task.TaskId, task.TaskName, task.DueDate, task.IsCompleted);
                        writer.WriteLine(outputLine);
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Open the file at Path and read it to create Task instances to load into taskList
        /// </summary>
        /// <returns></returns>
        private bool Load ()
        {
            this.taskList.Clear();
            this.maxId = 0;
            try
            {
                //Use StreamReader to open and read the file
                using (StreamReader reader = new StreamReader(Path))
                {
                    while(!reader.EndOfStream)
                    {
                        string inputLine = reader.ReadLine();

                        string[] fields = inputLine.Split(FILE_SEPARATOR_CHARACTERS);
                        //Create a Task from the data
                        Task task = new Task(int.Parse(fields[0]), fields[1], DateTime.Parse(fields[2]), bool.Parse(fields[4]));

                        //See if this is the highest Id
                        this.maxId = Math.Max(this.maxId, task.TaskId);
                        // add the task to the list
                        this.taskList.Add(task);
                    }
                    
                }
                return true;
            }
            catch(Exception)
            {
                //Log to some error log... eventually
                return false;

            }
        }

        public Task AddTask(Task task)
        {
            //fill in the id if needed
            if(task.TaskId == 0)
            {
                task.TaskId = GetNextId();
                task.IsCompleted = false;
            }

            this.taskList.Add(task);
            //Make sure the list is saved to the file
            Save();
            return task;
        }
        private int GetNextId()
        {
            this.maxId++;
            return this.maxId;
        }

    }
}
