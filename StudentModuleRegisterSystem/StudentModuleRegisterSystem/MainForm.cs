using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentModuleRegisterSystem
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            
            
        }
        
        ModuleController _controller;
        private void MainForm_Load(object sender, EventArgs e)
        {
            //string[] timeSlot = {"9","10","11","12","13","14","15","16","17","18"};

            //for (int i = 0; i < 9; i++)
            //{
            //    dataGridView1.Rows.Add();
            //    dataGridView1.Rows[i].HeaderCell.Value = timeSlot[i];
            //}
            
            
            

        }


        public void addModuleToList(Module module)
        {


            listBox1.Items.Add(module.Name);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._controller.selectedModuleChange((string)this.listBox1.SelectedItem);
        }



        public void setController(ModuleController controller)
        {
            _controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._controller.selectAvailableModule();
        }



        public string getIdOfAvailableModuleInList()
        {


            string reqModule = (string)this.listBox1.SelectedItem;
            return reqModule;


        }

       public void selectedModule(string module) {

            listBox2.Items.Add(module);
        }

      

       private void button2_Click(object sender, EventArgs e)
       {
           this._controller.removeModule();

       }



       public string getIdOfSelectedModuleList()
       {
           string removeModule = (string)this.listBox2.SelectedItem;
           return removeModule;
       }


       public void removeFromList(string module)
       {
           this.listBox2.Items.Remove(module);
       }


       public string Code
       {
           get{return this.labelCode.Text; }
           set{this.labelCode.Text = value; }
       }

       public string Semester
       {
           get { return this.labelSemester.Text; }
           set { this.labelSemester.Text = value; }
       }

       public string Prerequisite
       {
           get { return this.labelPerequisite.Text; }
           set { this.labelPerequisite.Text = value; }
           
       }

       public string LectureTime
       {
           get { return this.labelLectureSlot.Text; }
           set { this.labelLectureSlot.Text = value; }
      
       }

       public string TutorialTime
       {
           get { return this.labelTutorialSlot.Text; }
           set { this.labelTutorialSlot.Text = value; }
     
       }

       public string ModuleName {
           get { return this.labelName.Text; }
           set { this.labelName.Text = value; }
       }

       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
       {
           this._controller.timeTableSmesterChange(this.comboBoxSemester.SelectedIndex);
       }



       public string Mon_9_11
       {
           get
           {
               return this.labelMonday1.Text;
           }
           set
           {
               this.labelMonday1.Text = value;
               
           }
       }

       public string Mon_11_1
       {
           get
           {
               return this.labelMonday2.Text;
           }
           set
           {
               this.labelMonday2.Text = value;
           }
       }

       public string Mon_2_4
       {
           get
           {
               return this.labelMonday3.Text;
           }
           set
           {
               this.labelMonday3.Text = value;
           }
       }

       public string Mon_4_6
       {
           get
           {
               return this.labelMonday4.Text;
           }
           set
           {
               this.labelMonday4.Text = value;
           }
       }

       public string Tue_9_11
       {
           get
           {
               return this.labelTue1.Text;
           }
           set
           {
               this.labelTue1.Text = value;
           }
       }

       public string Tue_11_1
       {
           get
           {
               return this.labelTue2.Text;
           }
           set
           {
               this.labelTue2.Text = value;
           }
       }

       public string Tue_2_4
       {
           get
           {
               return this.labelTue3.Text;
           }
           set
           {
               this.labelTue3.Text = value;
           }
       }

       public string Tue_4_6
       {
           get
           {
               return this.labelTue4.Text;
           }
           set
           {
               this.labelTue4.Text = value;
           }
       }

       public string Thu_9_11
       {
           get
           {
               return this.labelThu1.Text;
           }
           set
           {
               this.labelThu1.Text = value;
           }
       }

       public string Thu_11_1
       {
           get
           {
               return this.labelThu2.Text;
           }
           set
           {
               this.labelThu2.Text = value;
           }
       }

       public string Thu_2_4
       {
           get
           {
               return this.labelThu3.Text; ;
           }
           set
           {
               this.labelThu3.Text = value;
           }
       }


       public void setVisibleMon_9_11(bool visible)
       {
           labelMonday1.Visible = visible;
           rectangleShapeMon1.Visible = visible;
       }

       public void setVisibleMon_11_1(bool visible)
       {
           labelMonday2.Visible = visible;
           rectangleShapeMon2.Visible = visible;
       }

       public void setVisibleMon_2_4(bool visible)
       {
           labelMonday3.Visible = visible;
           rectangleShapeMon3.Visible = visible;
       }

       public void setVisibleMon_4_6(bool visible)
       {
           labelMonday4.Visible = visible;
           rectangleShapeMon4.Visible = visible;
       }

       public void setVisibleTue_9_11(bool visible)
       {
           labelTue1.Visible = visible;
           rectangleShapeTue1.Visible = visible;
       }

       public void setVisibleTue_11_1(bool visible)
       {
           labelTue2.Visible = visible;
           rectangleShapeTue2.Visible = visible;
       }

       public void setVisibleTue_2_4(bool visible)
       {
           labelTue3.Visible = visible;
           rectangleShapeTue3.Visible = visible;
       }

       public void setVisibleTue_4_6(bool visible)
       {
           labelTue4.Visible = visible;
           rectangleShapeTue4.Visible = visible;
       }

       public void setVisibleThu_9_11(bool visible)
       {
           labelThu1.Visible = visible;
           rectangleShapeThu1.Visible = visible;
       }

       public void setVisibleThu_11_1(bool visible)
       {
           labelThu2.Visible = visible;
           rectangleShapeThu2.Visible = visible;
       }

       public void setVisibleThu_2_4(bool visible)
       {
           labelThu3.Visible = visible;
           rectangleShapeThu3.Visible = visible;
       }

       StudentController _studentController;
       private void buttonSubmit_Click(object sender, EventArgs e)
       {
           this._studentController.setModuleRegisterDetails();
           
       }


      



       public string FirstName
       {
           get
           {
               return this.textBoxFName.Text;
           }
           set
           {
               this.textBoxFName.Text = value;
           }
       }

       public string SurName
       {
           get
           {
               return this.textBoxSurName.Text;
           }
           set
           {
               this.textBoxSurName.Text = value;
           }
       }

       public string StudentId
       {
           get
           {
               return this.textBoxId.Text;
           }
           set
           {
               this.textBoxId.Text = value;
           }
       }


       public void setModuleController(StudentController controller)
       {
           _studentController = controller;
           
       }


       public List<Module> selectedModuleList
       {
           set { _studentController.setModuleList = value; }
       }


       public string ModuleCount
       {
           get
           {
               return this.labelCount.Text;
           }
           set
           {
               this.labelCount.Text = value;
           }
       }
    }
}

    

