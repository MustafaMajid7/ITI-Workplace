﻿namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question q1 = new Question(1, "Question", "is orange a color or fruit?");
            Question q2 = new Question(2, "Question", "What is your favourite sport?");
            Question q3 = new Question(3, "Question", "is egypt an african or asian country?");

            List<Answer> Q1ASR = new List<Answer>();

            Q1ASR.Add(new Answer(1, "Yes"));
            Q1ASR.Add(new Answer(2,"No"));

            List<Answer> Q2ASR = new List<Answer>();

            Q2ASR.Add(new Answer(1, "Football"));
            Q2ASR.Add(new Answer(2, "Handball"));
            Q2ASR.Add(new Answer(3, "Tennis"));
            Q2ASR.Add(new Answer(4, "Gymanstics"));

            List<Answer> Q3ASR = new List<Answer>();

            Q3ASR.Add(new Answer(1, "Africa"));
            Q3ASR.Add(new Answer(2, "Asia"));
            Q3ASR.Add(new Answer(3, "both"));
            Q3ASR.Add(new Answer(4, "none from the above"));

            Dictionary<Question,List<Answer> > exam = new Dictionary<Question, List<Answer>>();

            exam.Add(q1, Q1ASR);
            exam.Add(q2, Q2ASR);
            exam.Add(q3, Q3ASR);

            foreach (KeyValuePair<Question, List<Answer>> item in exam)
            {
                Console.WriteLine(item.Key);
                foreach (Answer answer in item.Value)
                {
                    Console.WriteLine(answer);
                }
                Console.WriteLine();
            }

        }
    }
}