namespace CSharp_Exam_Mospanov
{
    public partial class Form1 : Form
    {
        MyDictionary? active;
        public Form1()
        {
            InitializeComponent();
            InitResourses();
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
                
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//��� ����� �������� ������� � Combo Box, �������� ������� ����������
        {
            active = new MyDictionary(comboBox1.SelectedItem.ToString());
        }

        
        private void InitResourses()//��������� ����� � ���������� ��������, ��������� �������� � ComboBox �� ������ ��������
        {
            DirectoryInfo dir = new DirectoryInfo(".");
            DirectoryInfo[] subDirs = dir.GetDirectories();
            comboBox1.Items.Clear(); 
            foreach(DirectoryInfo subDir in subDirs)
            {
                comboBox1.Items.Add(subDir.Name);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)//������ ��������
        {            
            TranslatedText.Text = active?.Find(ForeignText.Text);
        }

        private void EditBtn_Click(object sender, EventArgs e)//������� � ����� �������������� ��������
        {
            List<string> list = new List<string>();
            foreach(string item in comboBox1.Items)
            {
                list.Add(item);
            }
            DictionaryEditorForm def = new DictionaryEditorForm(list);
            def.Show();
            
        }
        
        private void Export_Btn_Click(object sender, EventArgs e)//������� �������� � ����
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // �������� ��������� ����
            string filename = saveFileDialog1.FileName;
            // ��������� ����� � ����
            active?.ExportToFile(filename, ForeignText.Text);
        }

        private void comboBox1_DropDown(object sender, EventArgs e)//��� �������������� ������ ����������� ������� �� ������� �����
        {
            InitResourses();
        }
    }
}