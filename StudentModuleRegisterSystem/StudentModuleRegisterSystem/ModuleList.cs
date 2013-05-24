using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace StudentModuleRegisterSystem
{
    static class ModuleList
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainForm view = new MainForm();
            view.Visible = false;

            Module[] module = new Module[16];
            XmlTextReader xmlReader = new XmlTextReader("D:" + "\\XMLModule.xml");
            string code = "";
            string name = "";
            string semester = "";
            string prerequisite = "";
            TimeSlot lecture_Slot = TimeSlot.NULL;
            TimeSlot tutorial_Slot = TimeSlot.NULL;
            string info = "";
            int count = 0;
            while (xmlReader.Read())
            {
                
                
                //move to fisrt element
                xmlReader.MoveToElement();
              
                //if element name is <code>
                if (xmlReader.Name == "Code")
                {


                    //found the desired element so read the next node
                    xmlReader.Read();
                    XmlNodeType nType = xmlReader.NodeType;

                    if (nType == XmlNodeType.Text)
                    {

                        code = xmlReader.ReadContentAsString();

                    }

                   
                }

                else if (xmlReader.Name == "Name")
                {
                    xmlReader.Read();
                    XmlNodeType nType = xmlReader.NodeType;

                    if (nType == XmlNodeType.Text)
                    {

                        name = xmlReader.ReadContentAsString();
                        
                    }
                }


                else if (xmlReader.Name == "Semester")
                {
                    xmlReader.Read();
                    XmlNodeType nType = xmlReader.NodeType;

                    if (nType == XmlNodeType.Text)
                    {

                        semester = xmlReader.ReadContentAsString();

                    }
                }

                else if (xmlReader.Name == "Prerequisite")
                {
                    xmlReader.Read();
                    XmlNodeType nType = xmlReader.NodeType;

                    if (nType == XmlNodeType.Text)
                    {

                        prerequisite = xmlReader.ReadContentAsString();

                    }
                }

                else if (xmlReader.Name == "Lecture_Slot")
                {
                    xmlReader.Read();
                    XmlNodeType nType = xmlReader.NodeType;

                    if (nType == XmlNodeType.Text)
                    {

                        lecture_Slot = (TimeSlot)xmlReader.ReadContentAsInt();

                    }
                }

                else if (xmlReader.Name == "Tutorial_Slot")
                {
                    xmlReader.Read();
                    XmlNodeType nType = xmlReader.NodeType;

                    if (nType == XmlNodeType.Text)
                    {

                        tutorial_Slot = (TimeSlot)xmlReader.ReadContentAsInt();
                        module[count] = new Module(code, name, semester, prerequisite, lecture_Slot, tutorial_Slot, info);
                        count++;
                    }
                }

                else if (xmlReader.Name == "Info")
                {

                    xmlReader.Read();
                    XmlNodeType nType = xmlReader.NodeType;

                    if (nType == XmlNodeType.Text)
                    {

                        info = xmlReader.Value;
                        
                        

                    }


                }


                
            }

          
            ModuleController moduleController = new ModuleController(view, module);
            StudentController studentController = new StudentController(view);
            moduleController.loadView();
            view.ShowDialog();

        }
    }
}
