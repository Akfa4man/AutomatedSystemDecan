using System;

namespace Приложение_для_деканата_v1
{
    public class StudentsClass
    {
        private int id;
        public int Id 
        {
            get { return id; }
            set 
            {
                if (value <= -1) throw new ArgumentOutOfRangeException("Невозможное значение ID студента!"); id = value;
            }
        }
        public string Fullname { get; set; }
        public bool Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string IdGroup { get; set; }
        public StudentsClass() 
        {
            id = -1;
            Fullname = null;
            Gender = false;
            Birthday = new DateTime();
            IdGroup = null;
        }
        public StudentsClass(int idStudent,string fullname,bool gender,DateTime birthday, string idGroup)
        {
            Id = idStudent;
            Fullname = fullname;
            Gender = gender;
            Birthday = birthday;
            IdGroup = idGroup;
        }
    }
}
