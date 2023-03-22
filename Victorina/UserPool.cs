using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Victorina
{
    public class UserPool
    {
        public List<User> Users { get; set; }

        public UserPool()
        {
            Users = new List<User>();
            Load();
        }

        private void Load()
        {
            string filename = "Users.txt";
            if(File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] line = sr.ReadLine().Split(' ');
                            int recordsCount = int.Parse(sr.ReadLine());
                            Dictionary<string, List<int>> score = new Dictionary<string, List<int>>();
                            if(recordsCount > 0)
                            {
                                for (int i = 0; i < recordsCount; i++)//загрузка рекордов
                                {
                                    string[] splitted = sr.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                    int[] scoreNums = new int[splitted.Length - 1];
                                    for (int j = 0; j < scoreNums.Length; j++)
                                    {
                                        scoreNums[j] = Convert.ToInt32(splitted[j + 1]);
                                    }
                                    score.Add(splitted[0].Replace('_',' '), scoreNums.ToList());
                                }
                            }
                            
                            Users.Add(new User(line[0], line[1], line[2], score));
                        }
                    }
                }
            }            
        }

        public void Save()
        {
            string filename = "Users.txt";
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    foreach (User u in Users)
                    {
                        sw.WriteLine(u.SaveData());                        
                    }  
                }
            }
        }

        public void Register(string name, string password, string birthdate, Dictionary<string, List<int>> score)
        {
            try
            {
                if (name == "")
                    throw new Exception("Вы не ввели логин");
                if(Users.Count > 0)
                {
                    foreach (User u in Users)
                    {
                        if (u.Name == name)
                            throw new Exception("Пользователь с таким именем уже есть. Придумайте другое имя");
                    }
                }                

                if (password == "")
                    throw new Exception("Вы не ввели пароль");
                if (password.Length < 8)
                    throw new Exception("Длина пароля должна быть не менее 8 символов");

                Users.Add(new User(name, password, birthdate, score));
                MessageBox.Show($"Пользователь {name} зарегистрирован");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public User? Authorize(string login, string password)
        {
            foreach(User user in Users)
            {
                if(login == user.Name)
                {
                    if(user.CheckPassword(password))
                        return user;
                }
            } 
            MessageBox.Show("Такого логина не существует");
            return null;            
        }

        public void DeleteUser(User u)
        {
            if(Users.Contains(u))
                Users.Remove(u);
        }

        public User LastRegistered()
        {
            return Users[Users.Count - 1];
        }
    }
}
