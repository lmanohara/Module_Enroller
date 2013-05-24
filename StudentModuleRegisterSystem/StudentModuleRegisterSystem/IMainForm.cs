using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentModuleRegisterSystem
{
    public interface IMainForm
    {
        void addModuleToList(Module module);
        void setController(ModuleController controller);
        void setModuleController(StudentController controller);
        string getIdOfAvailableModuleInList();
        void selectedModule(string module);
        string getIdOfSelectedModuleList();
        void removeFromList(string module);
        

        string Code { get; set; }
        string Semester { get; set; }
        string Prerequisite { get; set; }
        //string info;
        string LectureTime { get; set; }
        string TutorialTime { get; set; }
        string ModuleName { get; set; }

        string Mon_9_11 { get; set; }
        string Mon_11_1 { get; set; }
        string Mon_2_4 { get; set; }
        string Mon_4_6 { get; set; }

        string Tue_9_11{ get; set; }
        string Tue_11_1 { get; set; }
        string Tue_2_4 { get; set; }
        string Tue_4_6 { get; set; }

        string Thu_9_11 { get; set; }
        string Thu_11_1 { get; set; }
        string Thu_2_4 { get; set; }

        void setVisibleMon_9_11(bool visible);
        void setVisibleMon_11_1(bool visible);
        void setVisibleMon_2_4(bool visible);
        void setVisibleMon_4_6(bool visible);
        void setVisibleTue_9_11(bool visible);
        void setVisibleTue_11_1(bool visible);
        void setVisibleTue_2_4(bool visible);
        void setVisibleTue_4_6(bool visible);
        void setVisibleThu_9_11(bool visible);
        void setVisibleThu_11_1(bool visible);
        void setVisibleThu_2_4(bool visible);

        string FirstName { get; set; }

        string SurName { get; set; }
        
        string StudentId { get; set; }

        List<Module> selectedModuleList { set; }

        string ModuleCount { get; set; }

        


    }


}
