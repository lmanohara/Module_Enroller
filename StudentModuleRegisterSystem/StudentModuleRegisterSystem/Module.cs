using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentModuleRegisterSystem
{

    public enum TimeSlot
    {

        //_0 9-11 slot, _1 11-1pm slot , _2 2-4pm slot, _3 4-6pm slot
        NULL = -1,

        Monday_9_11 = 0,
        Monday_11_1 = 1,
        Monday_2_4 = 2,
        Monday_4_6 = 3,

        Tuesday_9_11 = 4,
        Tuesday_11_1 = 5,
        Tuesday_2_4 = 6,
        Tuesday_4_6 = 7,

        Thursday_9_11 = 8,
        Thursday_11_1 = 9,
        Thursday_2_4 = 10

    }

    public class Module
    {

        String[] timeSlotNames = {
            "Monday 9 to 11", "Monday 11 to 1","Monday 2 to 4", "Monday 4 to 6",
            "Tuesday 9 to 11", "Tuesday 11 to 1", "Tuesday 2 to 4", "Tuesday 4 to 6",
            "Thursday 9 to 11", "Thursday 11 to 1", "Thursday 2 to 4" 
        };
       


        private string code;
        private string name;
        private string semester;
        private string prerequisite;
        private string info;
        private TimeSlot lectureTime;
        private TimeSlot tutorialTime;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public string Semester
        {
            get { return semester; }
            set { semester = value; }

        }


        public string Prerequisite
        {
            get { return prerequisite; }
            set { prerequisite = value; }
        }

        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        public TimeSlot LectureTime
        {
            get { return lectureTime; }
            set { lectureTime = value; }
        }

        public TimeSlot TutorialTime {

            get { return TutorialTime; }
            set { TutorialTime = value; }
        }

       public Module(string _code, string _name, string _semester, string _prerequisite,TimeSlot _lectureTime, TimeSlot _tutorialTime,  string _info)
        {
            Code = _code;
            Name = _name;
            Semester = _semester;
            Prerequisite = _prerequisite;
            Info = _info;
            lectureTime = _lectureTime;
            tutorialTime = _tutorialTime;

        }

       public string getTutorialSlot()
       {
           return timeSlotNames[(int)tutorialTime];
       }


       public string getLectureSlot()
       {
           return timeSlotNames[(int)lectureTime];
       }

        public Module() { 
        
        }
    }
}
