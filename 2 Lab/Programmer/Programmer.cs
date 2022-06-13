using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerModel
{
    public class Programmer
    {
        public Programmer()
        {
            Surname = "";
            CountOfProgrammingLanguage = 0;
            CountOfProgram = 0;
        }

        public Programmer(string surname, int countOfProgram, int countOfProgrammingLanguage)
        {
            Surname = surname;
            CountOfProgram = countOfProgram;
            CountOfProgrammingLanguage = countOfProgrammingLanguage;
        }
        public string Surname { get; set; } = "";
        public int CountOfProgram { get; set; }
        public int CountOfProgrammingLanguage { get; set; }

        public virtual double Quallity()
        {
            return CountOfProgrammingLanguage * CountOfProgram; 
        }

        public override string ToString() 
        {
            return $"Фамилия: {Surname}, количество написанных программ: {CountOfProgram}, количество языков программирования: {CountOfProgrammingLanguage} ";
        }
    }
}
