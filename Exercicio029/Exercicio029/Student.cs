using System;
using System.Globalization;

namespace Exercicio029
{
    class Student
    {
        public string Name;
        public double Score1, Score2, Score3;


        public double FinalScore()
        {
            return Score1 + Score2 + Score3;
        }

        public bool Approved()
        {
            if (FinalScore() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Failed()
        {
            if (Approved())
            {
                return 0;
            }
            else
            {
                return 60 - FinalScore();
            }

        }
    }
}
