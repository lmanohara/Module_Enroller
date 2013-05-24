using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentModuleRegisterSystem
{
    public class StudentController
    {

        IMainForm _view;
        Student student = new Student();
        List<Module> module;

        public StudentController(IMainForm view) {
            _view = view;
            _view.setModuleController(this);
        }
        public StudentController() { 
        
        }

        public List<Module> setModuleList {
            set { module = value; }
            get { return module; }
        }
        

        public void setModuleRegisterDetails() {
            if (module != null)
            {
                updateStudentWithEnteredValue();
            }
            else {
                System.Windows.Forms.MessageBox.Show("Module list is empty");
            }
            
        }

        public void updateStudentWithEnteredValue() {
            student.FirstName = _view.FirstName;
            student.SurName = _view.SurName;
            student.StudentId = _view.StudentId;
            student.SelectedModule = setModuleList;
            student.wiriteDtaToXml();
        }

    }
}
