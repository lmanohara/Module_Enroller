using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace StudentModuleRegisterSystem
{
    class Student
    {
        private string firstName;
        private string sureName;
        private string studentId;
        private List<Module> selectedModule;

        public string FirstName {
            get { return firstName; }
            set { firstName = value; }

        }

        public string SurName {
            get { return sureName; }
            set { sureName = value; }
        }


        public string StudentId{
            get { return studentId; }
            set { studentId = value; }
        }


        public List<Module> SelectedModule
        {
            get { return selectedModule; }
            set { selectedModule = value; }
        }

        public void wiriteDtaToXml() {
            string fileName = "D:"+@"\" + StudentId+"_timetable.xml";

            XmlTextWriter xmlWriter = new XmlTextWriter(fileName,null);

            //open the document
            xmlWriter.WriteStartDocument();

            //write first element
            xmlWriter.WriteStartElement("Student");
            //write Name element
            xmlWriter.WriteStartElement("Name", "");
            xmlWriter.WriteString(FirstName + "" + SurName);
            xmlWriter.WriteEndElement();

            //write student id 
            xmlWriter.WriteStartElement("Student_ID", "");
            xmlWriter.WriteString(StudentId);
            xmlWriter.WriteEndElement();

            //write Modules element
            xmlWriter.WriteStartElement("Modules");
            foreach (Module module in SelectedModule)
            {
                //write each module element
                xmlWriter.WriteStartElement("Module");
                //write module detalis
                xmlWriter.WriteStartElement("ModuleName", "");
                xmlWriter.WriteString(module.Name);
                xmlWriter.WriteEndElement();

                //semester
                xmlWriter.WriteStartElement("Semester", "");
                xmlWriter.WriteString(module.Semester);
                xmlWriter.WriteEndElement();

                //lecture_slot
                xmlWriter.WriteStartElement("Lecture_Slot", "");
                xmlWriter.WriteString(module.getLectureSlot());
                xmlWriter.WriteEndElement();

                //tutorial slot
                xmlWriter.WriteStartElement("Tutorial_Slot", "");
                xmlWriter.WriteString(module.getTutorialSlot());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }
            xmlWriter.Close();
            System.Windows.Forms.MessageBox.Show("D:" + @"\" + StudentId + "_timetable.xml" + " genarated!");

        }


    }
}
