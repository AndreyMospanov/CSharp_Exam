using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victorina
{
    public class User
    {
        public string Name { get; set; }
        private string password { get; set; }
        public string Birthdate { get; set; }
        public Dictionary<string, List<int>> myScore;

        public User(string name, string password, string birthdate, Dictionary<string, List<int>> myScore)
        {
            Name = name;
            this.password = password;
            Birthdate = birthdate;
            this.myScore = myScore;
        }

        public bool CheckPassword(string password)
        {
            if (password == this.password)
                return true;
            else
            {
                MessageBox.Show("Пароль неверный. Вы не авторизованы");
                return false;
            }  
        }

        public string SaveData()
        {
            string scores = string.Empty;
            foreach (var score in myScore)
            {
                string temp = score.Key.Replace(' ', '_');
                scores += $"\n{temp} ";
                foreach (var scoreNum in score.Value)
                    scores += $"{scoreNum} ";
            }
            return $"{Name} {password} {Birthdate}\n{myScore.Count}{scores}";
        }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   Name == user.Name;
        }

        public void AddScore(string quizName, int score)
        {
            if(myScore.ContainsKey(quizName))
                myScore[quizName].Add(score);
            else
                myScore.Add(quizName, new List<int> { score });
        }
    }
}
