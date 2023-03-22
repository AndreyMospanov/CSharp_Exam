namespace CSharp_Exam_Mospanov
{
    public partial class DictionaryEditorForm : Form
    {
        MyDictionary? active;
        string message = "system state";
        public DictionaryEditorForm(List<string> dictionaries)
        {
            InitializeComponent();
            foreach(string name in dictionaries)
            {
                comboBox1.Items.Add(name);
            }
        }

        private void DictionaryEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void Debug(string message)
        {
            MessageBox.Show($"DEBUG: {message}");
        }

        private bool activeIsNull(string mess = "")
        {
            if (active == null)
                MessageBox.Show($"Вы не выбрали словарь. Операция {mess} невозможна");
            return active == null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//сменилось название словаря в comboBox
        {  
            if (active != null)
                active.Save();
            
            message = comboBox1.SelectedItem.ToString();
            stateLabel.Text = $"{message} словарь выбран";
            active = new MyDictionary(message);
        }
        
        private void CreateDict_Btn_Click(object sender, EventArgs e)//Создание словаря
        {
            message = comboBox1.Text;
            stateLabel.Text = $"{message} словарь создан";
            comboBox1.Items.Add(message);
            active = new MyDictionary(message);
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)//Если перевод слова существует, то он отобразится справа
        {
            if (!activeIsNull())
            {
                Translated_Word.DataSource = null;
                if (active.Contains(textBox1.Text.ToLower()))
                    Translated_Word.DataSource = active.Find(textBox1.Text).Split();
                Translated_Word.Refresh();
                Translated_Word.Show();
                message = String.Empty;
            }            
        }

        
        private void DeleteWord_Btn_Click(object sender, EventArgs e)//Удалить слово с переводами
        {
            message = textBox1.Text;
            stateLabel.Text = $"{message} с переводами удалено";
            active.Remove(message);
            textBox1.Text = String.Empty;
            Translated_Word.DataSource = null;
            Translated_Word.Refresh();
        }

       
        private void DeleteTranslate_Btn_Click(object sender, EventArgs e) //Удалить один из переводов слова
        {
            message = Translated_Word.SelectedValue.ToString();
            stateLabel.Text = $"{message} удалено из переводов слова {textBox1.Text}";
            active.RemoveTranslate(textBox1.Text, message);
            Translated_Word.DataSource = active.Find(textBox1.Text).Split();
            Translated_Word.Refresh();
        }


        private void Translated_Word_ValueMemberChanged(object sender, EventArgs e)//актуализирует колонку с переводами при изменении значений
        {
            Translated_Word.Items.AddRange(active.Find(textBox1.Text).Split());
            stateLabel.Text = String.Empty;
        }


        private void Change_Btn_Click(object sender, EventArgs e)//Исправление иностранного слова
        {
            active.ChangeWord(textBox1.Text, textBox2.Text);
        }

        private void DictionaryEditorForm_FormClosing(object sender, FormClosingEventArgs e)//автосохранение последнего словаря при закрытии формы
        {
            if(!activeIsNull("автосохранения словаря"))
                active.Save();
        }

        private void AddTranslate_Btn_Click(object sender, EventArgs e)//Добавление перевода
        {
            active.Add(textBox1.Text, textBox3.Text);            
            message = $"{textBox3.Text} добавлено вкачестве перевода {textBox1.Text}";
            stateLabel.Text = message;
            textBox3.Text = String.Empty;
            Translated_Word.DataSource = active.Find(textBox1.Text).Split();
            Translated_Word.Refresh();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if (!activeIsNull())
            {
                active.Save();
                stateLabel.Text = "Словарь сохранён";
            }
            else
            {
                stateLabel.Text = "Не выбран активный словарь!";
            }  
        }
    }
}
