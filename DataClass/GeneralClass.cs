using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Приложение_для_деканата_v1
{
    public class GeneralClass
    {
        public readonly bool UpdateStudents;
        public readonly bool SelectStudents;

        public readonly bool UpdateGroup;
        public readonly bool SelectGroup;

        public readonly bool SelectSubjects;

        public readonly bool SelectExaminers;
        public readonly bool UpdateExaminers;

        public readonly bool SelectEvaluations;
        public readonly bool InsertEvaluations;
        public readonly bool DeleteEvaluations;
        public readonly bool UpdateEvaluations;

        public GeneralClass(bool UpdateStudents, bool SelectStudents, bool UpdateGroup, bool SelectGroup,
            bool SelectSubjects,
            bool SelectExaminers,
            bool SelectEvaluations,
            bool InsertEvaluations,
            bool DeleteEvaluations,
            bool UpdateEvaluations,
            bool UpdateExaminers) 
        {
            this.UpdateStudents = UpdateStudents;
            this.SelectStudents = SelectStudents;
            this.SelectGroup = SelectGroup;
            this.UpdateGroup = UpdateGroup;
            this.SelectSubjects = SelectSubjects;
            this.SelectExaminers = SelectExaminers;
            this.InsertEvaluations = InsertEvaluations;
            this.DeleteEvaluations = DeleteEvaluations;
            this.UpdateEvaluations = UpdateEvaluations;
            this.SelectEvaluations = SelectEvaluations;
            this.UpdateExaminers = UpdateExaminers;
        }
    }
}
