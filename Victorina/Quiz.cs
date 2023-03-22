using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Victorina
{
    public class Quiz
    {
        public string Name { get; set; }
        public List<Question> questions;
        public Dictionary<string, List<int>> TopScore;
        public int Count
        {
            get { return questions.Count; }
        }
                
        public Quiz(string name)
        {
            questions = new List<Question>();
            Name = name;
            TopScore = new Dictionary<string, List<int>>();
            if(File.Exists($@"Quiz\{Name}.txt"))
                Load();
        }

        public void ScoreRecord(string name, int score)
        {
            if(TopScore.ContainsKey(name))
                TopScore[name].Add(score);
            else            
                TopScore.Add(name, new List<int>() { score });            
        }

        public List<string> ShowRecord(string username = "")
        {
            List<string> scores = new List<string>();            
            if(username != "")
            {
                if(TopScore.ContainsKey(username))
                {
                    for (int i = 0; i < TopScore[username].Count; i++)
                    {
                        scores.Add($"{TopScore[username][i]} {username} {this.Name}");
                    }
                }                
            }
            else
            {
                foreach (var item in TopScore)
                {
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        scores.Add($"{item.Value[i]} {item.Key} {this.Name}");
                    }
                }
            }
            scores.Sort();
            scores.Reverse();
                                       
            return scores;
        }

        public string UserRecord(string username)
        {
            string temp = string.Empty;
            if (TopScore.ContainsKey(username))
            {
                foreach (var item in TopScore[username])
                    temp += $"{this.Name} {item}";
            }
            return temp;
        }

        public void Add(Question newQuestion)
        {
            if (questions.Count < 20)
                questions.Add(newQuestion);
            else
                MessageBox.Show("Достигнуто максимальное количество вопросов в тесте - 20шт");
        }

        public Question GetQuestion(int index)
        {
            return questions[index];
        }

        public void Delete(Question question)//удаляет нужный вопрос благодаря методу Question.Equals по тексту вопроса
        {
            questions.Remove(question);
        }

        public void Delete(int index)
        {
            if(index < this.Count)
                questions.RemoveAt(index);
        }

        public void Save()
        {
            using(FileStream fs = new FileStream($@"Quiz\{Name}.txt", FileMode.Create))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(questions.Count.ToString());//запишем в начале файла количество сохранённых вопросов в викторине

                    foreach(var item in questions)
                    {
                        sw.WriteLine(item.SaveData());
                    }

                    foreach(var item in TopScore)
                    {
                        string temp = string.Empty;
                        foreach (var v in item.Value)//запишем в одну строку все результаты
                            temp += $"{v} ";

                        sw.WriteLine($"{item.Key} {temp}");
                    }
                }
            }
        }
        
        public void Load()
        {
            using(FileStream fs = new FileStream($@"Quiz\{Name}.txt", FileMode.Open))
            {
                using(StreamReader sr = new StreamReader(fs))
                {
                    string question = "";
                    List<string> answers = new List<string>();
                    char[] correctChars;
                    int[] correct;
                    int score = 0;
                    int questionCount = int.Parse(sr.ReadLine());                    

                    for (int i = 0; i < questionCount; i++)//цикл для считывания вопросов целиком
                    {
                        answers.Clear();
                        question = sr.ReadLine();//читаем вопрос                        
                        int answersCount = int.Parse(sr.ReadLine());//получаем количество вариантов ответа
                        
                        for(int j = 0; j < answersCount; j++)//читаем варианты ответов
                        {
                            answers.Add(sr.ReadLine());
                        }

                        correctChars = sr.ReadLine().ToCharArray();//получаем правильные ответы из строки

                        correct = new int[correctChars.Length];
                        for (int j = 0; j < correct.Length; j++)
                        {
                            correct[j] = Convert.ToInt32(correctChars[j]) - 48;
                        }

                        score = Convert.ToInt32(sr.ReadLine());

                        questions.Add(new Question(question, answers.ToArray(), correct, score));
                    }

                    while(!sr.EndOfStream)//Получаем TopScore
                    {
                        string temp = sr.ReadLine();
                        string[] splitted = temp.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        string key;
                        List<int> values = new List<int>();
                        key = splitted[0];

                        for (int i = 1; i < splitted.Length; i++)
                        { 
                            values.Add(int.Parse(splitted[i]));
                        }

                        TopScore.Add(key, values);
                    }
                }
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Quiz quiz &&
                   Name == quiz.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, questions);
        }

        public void AddScore(string userName, int score)
        {
            if (TopScore.ContainsKey(userName))
                TopScore[userName].Add(score);
            else
                TopScore.Add(userName, new List<int>() { score });
        }
    }
}
