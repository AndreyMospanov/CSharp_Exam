/*Создавать словарь. При создании нужно указать тип словаря.
Например, англо-русский или русско-английский.
■ Добавлять слово и его перевод в уже существующий словарь. Так как у слова может быть несколько переводов, необходимо поддерживать возможность создания 
нескольких вариантов перевода.
■ Заменять слово или его перевод в словаре.
■ Удалять слово или перевод. Если удаляется слово, все его переводы удаляются 
вместе с ним. Нельзя удалить перевод слова, если это последний вариант перевода.
■ Искать перевод слова.
■ Словари должны храниться в файлах.
■ Слово и варианты его переводов можно экспортировать в отдельный файл результата.
■ При старте программы необходимо показывать меню для работы с программой. 
Если выбор пункта меню открывает подменю, то тогда в нем требуется предусмотреть возможность возврата в предыдущее меню.*/
using System.Text;

namespace CSharp_Exam_Mospanov
{
    internal class MyDictionary
    {
        private Dictionary<string, List<string>> dictDB;
        public string Name { get; set; }

        public MyDictionary (string name)
        {
            dictDB = new Dictionary<string, List<string>>();
            Name = name;
            Load();
        }

        public void Save()
        {            
            DirectoryInfo dir = new DirectoryInfo(Name);
            if(!dir.Exists)
                dir.Create();
            //Записываем файл 1 языка (с которого переводим)
            using (FileStream fs = new FileStream($@"{Name}\1.txt", FileMode.Create))
            {
                using(StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    foreach (string key in dictDB.Keys)
                    {
                        sw.WriteLine(key.ToLower());
                    }
                }
            }
            //Записываем файл 2 языка (на который переводим)
            using (FileStream fs = new FileStream($@"{Name}\2.txt", FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    foreach (List<string> value in dictDB.Values)
                    {
                        for (int i = 0; i < value.Count; i++)
                            sw.Write($"{value[i].ToLower()} "); 
                        sw.WriteLine();
                    }
                }
            }
        }
        private void Load()
        {   
            List<string> temp = new List<string> ();
            //загрузка языка 1 (с которого переводим)
            FileInfo file = new FileInfo(@$"{Name}\1.txt");            
            if (file.Exists)
            {
                using (FileStream fs = new FileStream($@"{Name}\1.txt", FileMode.OpenOrCreate))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                    {
                        while(sr.Peek() >= 0)
                            dictDB.Add(sr.ReadLine(), new List<string>());
                    }
                }
                //загрузка языка 2 (на который переводим)
                using (FileStream fs = new FileStream($@"{Name}\2.txt", FileMode.OpenOrCreate))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                    {                        
                        while(sr.Peek() >= 0)
                        {
                            temp.Add(sr.ReadLine());
                        }

                        int index = 0;

                        foreach(var value in dictDB.Values)
                        {
                            value.AddRange(temp[index++].Split(' ', StringSplitOptions.RemoveEmptyEntries));
                        }
                    }
                }
            }
            else //при создании словаря, когда нечего загружать, минуем загрузку и создаём файлы
            {
                Save();
            }
        }

        public string TranslatePhrase(string[] phrase)
        {
            string result = string.Empty;
            foreach (string word in phrase)
                result += $"{Find(word)}";
            return result;
        }       

        public string Find(string word)
        {
            string translate = string.Empty;
            string[] phrase = word.Split(new char[] { ' ', '.', ',', '!', '?', '&', '-', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (phrase.Length > 1)
            {               
                return TranslatePhrase(phrase);
            }
            else
            {
                word = word.ToLower();
                try
                {
                    if (dictDB.ContainsKey(word))
                    {
                        for (int i = 0; i < dictDB[word].Count; i++)
                        {                           
                            translate += $"{dictDB[word][i]} ";
                        }                        
                        return translate;
                    }
                    else
                        throw new Exception("Перевода_нет ");
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }   
        }

        public void Add(string key, string value)
        {
            if (key == "" || value == "")
                MessageBox.Show("Вы не ввели одно из значений. Операция невозможна");
            else
            {
                if (!dictDB.ContainsKey(key))
                    dictDB.Add(key, new List<string>());

                dictDB[key].AddRange(value.Split(' ', StringSplitOptions.RemoveEmptyEntries));
            }
        }

        public void Remove(string key)
        {
            dictDB.Remove(key);
        }

        public void RemoveTranslate(string key, string value)
        {
            try
            {
                if (dictDB[key].Count > 1)
                {
                    if (dictDB[key].Contains(value))
                        dictDB[key].Remove(value);
                    else
                        throw new Exception("перевод не выбран");
                }
                else
                    throw new Exception("Нельзя удалить единственный перевод слова");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ChangeWord(string oldKey, string newKey)
        {
            List<string> temp = new List<string>();
            string tempstr = String.Empty;
            if (dictDB.ContainsKey(oldKey))
            {
                temp.AddRange(dictDB[oldKey]);
                Remove(oldKey);
                foreach(string key in temp)
                {
                    tempstr += key + " ";
                }
                Add(newKey, tempstr);
            }
            else
            {
                throw new Exception($"в словаре нет слова {oldKey}");
            }
        }

        public void ExportToFile(string fileName, string key)
        {
            if(dictDB.ContainsKey(key))
            {
                using(FileStream fs = new FileStream($"{fileName}.txt", FileMode.Create))
                {
                    using(StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                    {
                        sw.Write($"{key} перевод: ");
                        foreach(string value in dictDB[key])
                        {
                            sw.Write($"{value} ");
                        }
                    }
                }
            }
        }

        public bool Contains(string word)
        {
            return dictDB.ContainsKey(word);
        }
    }
}
