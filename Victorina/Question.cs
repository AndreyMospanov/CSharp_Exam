using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victorina
{
    public class Question
    {
        public string question { get; set; }
        public string[] answers { get; set; }
        public int[] correct { get; set; }
        public int score { get; set; }

        public Question(string question, string[] answers, int[] correct, int score)
        {
            this.question = question;
            this.answers = answers;
            this.correct = correct;
            this.score = score;
        }

        public Question() { }

        public void Edit(string question, string[] answers, int[] correct, int score)//редактирование вопроса
        {
            this.question = question;
            this.answers = answers;
            this.correct = correct;
            this.score = score;
        }

        public int Solve(int[] answers)//решение вопроса викторины
        {
            int rightShots = 0;
            for (int i = 0; i < correct.Length; i++)
            {
                for (int j = 0; j < answers.Length; j++)
                {
                    if (correct[i] == answers[j])
                        rightShots++;
                }
            }

            if (rightShots == correct.Length)
                return score;
            else
                return 0;
        }

        public string SaveData()
        {
            string correctStr = string.Empty;
            string answersStr = string.Empty;
            for (int i = 0; i < correct.Length; i++)
            {
                correctStr += correct[i].ToString();
            }

            for (int i = 0; i < answers.Length; i++)
            {
                answersStr += $"{answers[i]}\n";
            }
            answersStr.Remove(answersStr.Length - 2);
            return $"{question}\n{answers.Length}\n{answersStr}{correctStr}\n{score}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Question question &&
                   this.question == question.question;
        }
    }
}
