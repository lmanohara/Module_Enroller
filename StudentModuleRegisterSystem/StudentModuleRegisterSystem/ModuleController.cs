using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentModuleRegisterSystem
{
    public class ModuleController
    {
        Module[] _module;
        IMainForm _view;
        int count = 0;
        List<Module> selectedModule = new List<Module>();
        StudentController studentController = new StudentController();
        

        public ModuleController(IMainForm view, Module[] module)
        {

            _view = view;
            _module = module;
            view.setController(this);

        }

        //the default view 
        public void loadView()
        {
            foreach (Module module in _module)
                _view.addModuleToList(module);


        }

        //to select module on the available list (remove on the select module )
        public void selectAvailableModule()
        {
            string selectModule = this._view.getIdOfAvailableModuleInList();
            
            foreach (Module module in this._module)
            {

                if (module.Name == selectModule)
                {

                    
                    setStudentSelectModule(module);
                    
                }
            }
            

        }

        //to remove item from selected items
        public void removeModule()
        {

            string removeModule = this._view.getIdOfSelectedModuleList();
            for(int i = selectedModule.Count - 1; i >= 0; i--) {
                if (selectedModule[i].Name == removeModule)
                {
                    
                    if (selectedModule[i].Prerequisite == "core")
                    {
                        System.Windows.Forms.MessageBox.Show("can not remove core module");
                    }
                    else {
                        selectedModule.RemoveAt(i);
                        this._view.removeFromList(removeModule);
                        countModule--;
                        this._view.ModuleCount = countModule.ToString();
                    }
                    
                }
            }
            
            updatedModuleList();

        }


        //update with user selected module
        private void updateViewDetailValue(Module module)
        {
            _view.Code = module.Code;
           _view.ModuleName = module.Name;
            _view.Prerequisite = module.Prerequisite;
            _view.Semester = module.Semester;
            _view.LectureTime = module.getLectureSlot();
            _view.TutorialTime = module.getTutorialSlot();
        }

        //to selected module change details
        public void selectedModuleChange(string selectedModuleName)
        {
            
            foreach (Module module in this._module)
            {

                if (module.Name == selectedModuleName)
                {
                    
                    updateViewDetailValue(module);
                    
                }
            }

        }


        //select timetable semester1 and semester2
        public void timeTableSmesterChange(int selectedSemesterIndex)
        {
            clearTimeTable();
            foreach (Module module in selectedModule)
            {

                if (!isFull()) {
                    System.Windows.Forms.MessageBox.Show("Module list is not full");
                    break;
                }
                else if (module.Semester == "1" && selectedSemesterIndex == 0)
                {
                    setTimetableSlots(module);
                }
                else if (module.Semester == "2" && selectedSemesterIndex == 1)
                {
                    setTimetableSlots(module);
                }
            }
             
            
        }

        //update timetable slot 

        public void setTimetableSlots(Module module) {
            String lec = " L";
            String tut = " T";

            if (module.getLectureSlot() == "Monday 9 to 11") { _view.Mon_9_11 = module.Name + lec; _view.setVisibleMon_9_11(true); }
            if (module.getTutorialSlot() == "Monday 9 to 11") { _view.Mon_9_11 = module.Name + tut; _view.setVisibleMon_9_11(true); }
            if (module.getLectureSlot() == "Monday 11 to 1") { _view.Mon_11_1 = module.Name + lec; _view.setVisibleMon_11_1(true); }
            if (module.getTutorialSlot() == "Monday 11 to 1") { _view.Mon_11_1 = module.Name + tut; _view.setVisibleMon_11_1(true); }
            if (module.getLectureSlot() == "Monday 2 to 4") { _view.Mon_2_4 = module.Name + lec; _view.setVisibleMon_2_4(true); }
            if (module.getTutorialSlot() == "Monday 2 to 4") { _view.Mon_2_4 = module.Name + tut; _view.setVisibleMon_2_4(true); }
            if (module.getLectureSlot() == "Monday 4 to 6") { _view.Mon_4_6 = module.Name + lec; _view.setVisibleMon_4_6(true); }
            if (module.getTutorialSlot() == "Monday 4 to 6") { _view.Mon_4_6 = module.Name + tut; _view.setVisibleMon_4_6(true); }

            if (module.getLectureSlot() == "Tuesday 9 to 11") { _view.Tue_9_11 = module.Name + lec; _view.setVisibleTue_9_11(true); }
            if (module.getTutorialSlot() == "Tuesday 9 to 11") { _view.Tue_9_11 = module.Name + tut; _view.setVisibleTue_9_11(true); }
            if (module.getLectureSlot() == "Tuesday 11 to 1") { _view.Tue_11_1 = module.Name + lec; _view.setVisibleTue_11_1(true); }
            if (module.getTutorialSlot() == "Tuesday 11 to 1") { _view.Tue_11_1 = module.Name + tut; _view.setVisibleTue_11_1(true); }
            if (module.getLectureSlot() == "Tuesday 2 to 4") { _view.Tue_2_4 = module.Name + lec; _view.setVisibleTue_2_4(true); }
            if (module.getTutorialSlot() == "Tuesday 2 to 4") { _view.Tue_2_4 = module.Name + tut; _view.setVisibleTue_2_4(true); }
            if (module.getLectureSlot() == "Tuesday 4 to 6") { _view.Tue_4_6 = module.Name + lec; _view.setVisibleTue_4_6(true); }
            if (module.getTutorialSlot() == "Tuesday 4 to 6") { _view.Tue_4_6 = module.Name + tut; _view.setVisibleTue_4_6(true); }

            if (module.getLectureSlot() == "Thursday 9 to 11") { _view.Thu_9_11 = module.Name + lec; _view.setVisibleThu_9_11(true); }
            if (module.getTutorialSlot() == "Thursday 9 to 11") { _view.Thu_9_11 = module.Name + tut; _view.setVisibleThu_9_11(true); }
            if (module.getLectureSlot() == "Thursday 11 to 1") { _view.Thu_11_1 = module.Name + lec; _view.setVisibleThu_11_1(true); }
            if (module.getTutorialSlot() == "Thursday 11 to 1") { _view.Thu_11_1 = module.Name + tut; _view.setVisibleThu_11_1(true); }
            if (module.getLectureSlot() == "Thursday 2 to 4") { _view.Thu_2_4 = module.Name + lec; _view.setVisibleThu_2_4(true); }
            if (module.getTutorialSlot() == "Thursday 2 to 4") { _view.Thu_2_4 = module.Name + tut; _view.setVisibleThu_2_4(true); }
        }
       

        //setSelected module for students

        public void setStudentSelectModule(Module module) {

            Prerequisite(module);
            
             if (!checkMultiAddSameModule(module)) {
                System.Windows.Forms.MessageBox.Show("can not add same module again");

            }
            else if (!checkCoreModule(module))
            {
                System.Windows.Forms.MessageBox.Show("Add core module first");
            }
             else if (!checkTimeTableCrash(module)) 
             {
                 System.Windows.Forms.MessageBox.Show("Time table clashes");
             }
             else if (!CheckPrerequisite)
             {
                 System.Windows.Forms.MessageBox.Show("Prerequisite " + module.Prerequisite);
             }
             else if (isFull()) {
                 System.Windows.Forms.MessageBox.Show("Module list is full");
             }
             else
             {
                 selectedModule.Add(module);
                 this._view.selectedModule(module.Name);
                 updatedModuleList();
                 count++;
                 countModule++;
                 this._view.ModuleCount = countModule.ToString();
             }
            

        }

        //clear timetable value
        public void clearTimeTable() {
            _view.Mon_9_11 = "";
            _view.Mon_11_1 = "";
            _view.Mon_4_6 = "";
            _view.Mon_2_4 = "";
            _view.Tue_9_11 = "";
            _view.Tue_11_1 = "";
            _view.Tue_2_4 = "";
            _view.Tue_4_6 = "";
            _view.Thu_9_11 = "";
            _view.Thu_11_1 = "";
            _view.Thu_2_4 = "";

            _view.setVisibleMon_9_11(false);
            _view.setVisibleMon_11_1(false);
            _view.setVisibleMon_2_4(false);
            _view.setVisibleMon_4_6(false);
            _view.setVisibleTue_9_11(false);
            _view.setVisibleTue_11_1(false);
            _view.setVisibleTue_2_4(false);
            _view.setVisibleTue_4_6(false);
            _view.setVisibleThu_9_11(false);
            _view.setVisibleThu_11_1(false);
            _view.setVisibleThu_2_4(false);
        }

        public void updatedModuleList() {

            _view.selectedModuleList = selectedModule;
        }

        //validate user selection
        public bool checkCoreModule(Module module) {

           

            if (module.Prerequisite != "core" && !(count >= 2))
            {
                return false;
            }
            else
            {
                count++;
                return true;
            }

            
        }

        public bool checkMultiAddSameModule(Module module) {

            foreach (Module eachModule in selectedModule) {
                if (module == eachModule) {
                    return false;
                }
            }
            return true;
        
        }

        public bool checkTimeTableCrash(Module module) {

            foreach (Module eachModule in selectedModule) {
                if (module.Semester == "1" && eachModule.Semester == "1") {
                    if (eachModule.getLectureSlot() == module.getTutorialSlot() || eachModule.getTutorialSlot() == module.getLectureSlot())
                    {
                        return false;
                    }
                }
                else if (module.Semester == "2" && eachModule.Semester == "2") {
                    if (eachModule.getLectureSlot() == module.getTutorialSlot() || eachModule.getTutorialSlot() == module.getLectureSlot())
                    {
                        return false;
                    }
                }
            } return true;
        }

        public void Prerequisite(Module module)
        {
            prerequisite = true;
            foreach (Module eachModule in selectedModule)
            {
                if (module.Prerequisite != "core" && module.Prerequisite != "none")
                {
                    if (module.Prerequisite == eachModule.Code)
                    {
                        CheckPrerequisite = true;
                    }
                    else if (module.Prerequisite != eachModule.Code)
                    {
                        CheckPrerequisite = false;
                    }
                }


            }
        }
         

        private bool prerequisite = true;
        public bool CheckPrerequisite {
            get { return prerequisite ;}
            set { prerequisite = value; }
        }

        public int countModule = 0;
        public bool isFull() {
            if (countModule == 8)
            {
                return true;
            }
            else { return false; }
        }
    }
}
