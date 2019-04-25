using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Task_Manager
{
    public class Project
    {
        [XmlArray("TaskList")]
        [XmlArrayItem("TaskListItem")]
        public List<Task> Tasks = new List<Task>();

        public delegate void TaskAddedEvent(Task task);
        public event TaskAddedEvent OnTaskAdded;

        public delegate void TaskRemovedEvent(int index);
        public event TaskRemovedEvent OnTaskRemoved;

        public delegate void ProjectSavedEvent(Project project);
        public event ProjectSavedEvent OnProjectSaved;

        public delegate void ProjectLoadedEvent(Project project);
        public event ProjectLoadedEvent OnProjectLoaded;

        //Adds a new task to the task list
        //Invokes the task added event
        //Returns the newly created task
        public Task AddTask()
        {
            //Add task to the projects list
            Tasks.Add(new Task());

            //If at least one subscription to the on task added event exists
            if(OnTaskAdded != null)
            {
                //Invoke the on task added event
                OnTaskAdded.Invoke(Tasks.Last());
            }

            //Return the task
            return Tasks.Last();
        }

        //Removes the task at the specified index in the task list
        public bool RemoveTask(int index)
        {
            //If the specified index in inside the bounds of the task list
            if (index >= 0 && index < Tasks.Count)
            {
                //Remove the task at the specified index in the task list
                Tasks.RemoveAt(index);

                //If at least one subscription to the on task removed event exists
                if(OnTaskRemoved != null)
                {
                    //Invoke the on task removed event
                    OnTaskRemoved.Invoke(index);
                }

                //Successfully removed task
                return true;
            }

            //Failed to remove task
            return false;
        }

        //Removes the specified task from the task list
        public bool RemoveTask(Task task)
        {
            //Find the index of the specified task
            int index = Tasks.IndexOf(task);

            //Remove the task
            return RemoveTask(index);
        }

        //Saves the project to the specified filepath
        //filepath - Directory, name and file extension (Example: './My Project.xml')
        public bool Save(string filepath)
        {
            try
            {
                //Create XML serializer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>));

                //Create stream writer
                using (StreamWriter streamWriter = new StreamWriter(filepath))
                {
                    //Serialize project tasks and write to the filepath
                    xmlSerializer.Serialize(streamWriter, Tasks);
                }

                //If at least one subscription to the on project saved event exists
                if(OnProjectSaved != null)
                {
                    //Invoke the on project saved event
                    OnProjectSaved.Invoke(this);
                }

                //Successfully saved
                return true;
            }
            catch(Exception exception)
            {
                //Display exception message
                MessageBox.Show(exception.Message);

                //Failed to save
                return false;
            }
        }

        //Loads the project from the specified filepath
        //filepath - Directory, name and file extension (Example './My Project.xml')
        public bool Load(string filepath)
        {
            //If the filepath is valid
            if (File.Exists(filepath))
            {
                try
                {
                    //Create XML serializer
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Task>));

                    //Create stream reader
                    using (StreamReader streamReader = new StreamReader(filepath))
                    {
                        //Deserialize project tasks
                        Tasks = (List<Task>)xmlSerializer.Deserialize(streamReader);
                    }

                    //If at least one subscription to the on project loaded event exists
                    if(OnProjectLoaded != null)
                    {
                        //Invoke the on project loaded event
                        OnProjectLoaded.Invoke(this);
                    }

                    //Successfully loaded
                    return true;
                }
                catch(Exception exception)
                {
                    //Display exception message
                    MessageBox.Show(exception.Message);
                }
            }

            //Failed to load
            return false;
        }
    }
}
