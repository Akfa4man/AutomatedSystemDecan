using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClass
{
    public class ExaminersClass
    {
        private int id;
        public int ID
        {
            get { return id; }
            set
            {
                if(value <= -1) throw new ArgumentOutOfRangeException("Невозможное значение ID!");
                id = value;
            }
        }
        public string Fullname { get; set; }
        public bool Gender { get; set; }
        public DateTime Birthday { get; set; }

        public ExaminersClass()
        {
            id = -1;
            Fullname = null;
            Gender = false;
            Birthday = new DateTime();
        }
        public ExaminersClass(int id, string fullname, bool gender, DateTime birthday)
        {
            ID = id;
            Fullname= fullname;
            Gender = gender;
            Birthday = birthday;
        }
    }
}
