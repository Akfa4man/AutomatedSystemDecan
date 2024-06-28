using System;
using System.Collections.Generic;

namespace Приложение_для_деканата_v1
{
    public class GroupClass
    {
        private string id_group;
        public string IdGroup
        {
            get { return id_group; }
            set
            {
                if (value == null || value == "") throw new ArgumentNullException("Невозможное значение ID группы");
                id_group = value;
            }
        }
        public int num_of_semester { get; set; }
        public int current_semester { get; set; }
        public Dictionary<string, bool> actionsStudents { get; private set; }
        //public Dictionary<string, bool> actionsSubjects { get; private set; }
        public GroupClass()
        {
            id_group = null;
            num_of_semester = 0;
            current_semester=0;
            LoadClass();
        }
        public GroupClass(string id_group, int num_of_semester, int current_semester)
        {
            this.id_group = id_group;
            this.num_of_semester=num_of_semester;
            this.current_semester=current_semester;
            LoadClass();
        }
        private void LoadClass()
        {
            actionsStudents = new Dictionary<string, bool>();
            //actionsSubjects = new Dictionary<string, bool>();
        }
        public void RecordCommand(Dictionary<string, bool> dic,string id, bool status)
        {
            if (dic.ContainsKey(id)) dic.Remove(id);
            else dic.Add(id, status);
        }
    }
}
