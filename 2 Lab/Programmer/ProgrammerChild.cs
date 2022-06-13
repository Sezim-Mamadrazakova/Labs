using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerModel
{
    public class ProgrammerChild : Programmer
    {
        public ProgrammerChild() : base()
        {
            CountOfRightProgram = 0;
        }

        public ProgrammerChild(string surname, int countOfProgram, int countOfProgrammingLanguage, int countOfRightProgram)
            : base(surname, countOfProgram, countOfProgrammingLanguage)
        {
            CountOfRightProgram = countOfRightProgram;
        }
        public int CountOfRightProgram { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"количество правильно написанных программ: {CountOfRightProgram}.";
        }
        public override double Quallity()
        {
            return base.Quallity() * (double)CountOfRightProgram / (double)CountOfProgram;
        }
    }
}
