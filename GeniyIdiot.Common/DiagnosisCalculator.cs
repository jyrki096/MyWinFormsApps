using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class DiagnosisCalculator
    {
        public static void GetDiagnosis(User user, int questionsAmount)
        {

            var diagnoses = new List<string>()
            {
                "кретин",
                "идиот",
                "дурак",
                "нормальный",
                "талант",
                "гений"
            };

            int diagnosesIndex = 0;
            var rightSolutionPercent = user.CountRightAnswers / (double)questionsAmount * 100;

            if (rightSolutionPercent >= 20 && rightSolutionPercent < 40)
                diagnosesIndex = 1;
            else if (rightSolutionPercent >= 40 && rightSolutionPercent < 60)
                diagnosesIndex = 2;
            else if (rightSolutionPercent >= 60 && rightSolutionPercent < 80)
                diagnosesIndex = 3;
            else if (rightSolutionPercent >= 80 && rightSolutionPercent < 99)
                diagnosesIndex = 4;
            else if (rightSolutionPercent == 100)
                diagnosesIndex = 5;

            user.Diagnosis = diagnoses[diagnosesIndex];

        }
    }
}
