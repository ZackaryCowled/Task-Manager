using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_Manager
{
    public static class ProjectIO
    {
        //Saves the project to the filepath
        //filepath - The directory, name and file extension to save the project (Example: ./ProjectName.xml)
        //project - The project to save
        public static bool Save(string filepath, Project project)
        {
            try
            {
                //Create XML serializer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Project));

                //Create stream writer
                using (StreamWriter streamWriter = new StreamWriter(filepath))
                {
                    //Serialize tasks and write into the file
                    xmlSerializer.Serialize(streamWriter, project);
                }

                //If the file exists
                if (File.Exists(filepath))
                {
                    //Saved project successfully
                    return true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            //Failed to save project
            return false;
        }

        //Loads the project from the filepath
        //filepath - The directory, name and file extension to load the project (Example: ./ProjectName.xml)
        public static Project Load(string filepath)
        {
            //Create null project
            Project project;

            //If the project file exists
            if(File.Exists(filepath))
            {
                //Create XML serializer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Project));

                //Create stream reader
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    //Deserialize tasks and store into the project variable
                    project = (Project)xmlSerializer.Deserialize(streamReader);
                }

                //Return the project
                return project;
            }
            else
            {
                //Failed to load project
                return null;
            }
        }
    }
}
