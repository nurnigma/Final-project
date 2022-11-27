namespace Final_project
{

    public partial class GameField : Form
    {
        public struct Question //��������� ������� �� 3 ����� ��� ������, ������ � ���������� �����
        {
            public string question;
            public string[] answers;
            public int isCorrect;
        };

        Question [] test = new Question [20];
        int count = 0;
        int answer = 0;


        void LoadFromFile()
        {
            using StreamReader fs = new StreamReader("Resources\\������� � ������.txt"); //�� ����� ������� ��������� ����

            while (count < 20)
            {
                
                test[count].question = fs.ReadLine();
                test[count].answers = new string[4]; //������ ��������

                for (int a = 0; a < 4; a++) //���������
                {
                    test[count].answers[a] = fs.ReadLine();
                }
                test[count].isCorrect = Convert.ToInt32(fs.ReadLine());
                fs.ReadLine();
                count++;
            }
            count = 0;
            LoadQuestion();
            MoneyTree.SelectedIndex = 19;
        }
        /// <summary>
        /// ��������� �������
        /// </summary>
        void LoadQuestion()
        {
            textOfQuestion.Text = test[count].question;
            answer1.Text = test[count].answers[0];
            answer2.Text = test[count].answers[1];
            answer3.Text = test[count].answers[2];
            answer4.Text = test[count].answers[3];
        }

        public GameField()
        {
            InitializeComponent();
        }

        private void GameField_Load(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        
        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            answer = Convert.ToInt32(((Button)sender).Tag); //����� ����������� �� ����, � ���� ����� ������
            if (test[count].isCorrect == answer) // ���� ����� ����������
            {
                MessageBox.Show("����� ����������!");
                count++; 
                var selectIndex = 20 - count - 1;
                
               
                if(selectIndex == -1)
                {
                    VictoryWindow victoryWindow = new VictoryWindow();
                    victoryWindow.Show();
                    this.Hide();
                }
                else
                {
                    MoneyTree.SelectedIndex = selectIndex;
                    LoadQuestion();
                }
                
            }
            else // ����� ��������
            {
            
                
            if (MoneyTree.SelectedIndex <= 13 && MoneyTree.SelectedIndex > 7) //����������� ����������� �����
            {
                        
                MessageBox.Show("����� ��������! ���� ��������!" + "\n ��� ������� ����������: " + MoneyTree.Items[13].ToString().Substring(2));
                    this.Close();
            }
             else 
             if(MoneyTree.SelectedIndex <=7 && MoneyTree.SelectedIndex != 0)
            {
                    MessageBox.Show("����� ��������! ���� ��������!" + "\n ��� ������� ����������: " + MoneyTree.Items[7].ToString().Substring(2));
                    this.Close();
            }
            
            else
            MessageBox.Show(String.Format("����� ��������! ���� ��������!\n ��� ������� ����������: {0:C0}", 0)); // �� ���� ���������� ����������� �����
            this.Close();
            }
            this.Focus(); // ����� �� ������ ��� ��������� ������
            answer1.Visible = true;
            answer2.Visible = true;
            answer3.Visible = true; 
            answer4.Visible = true;
        }


        #region ���������: 50/50, ������ �����, �������� ���.

        private void lifeline_fifthy(object sender, EventArgs e)
        {
            
            bool isNotCorrect(Button button) //�� ������ ������ 
            {
                var result =  Convert.ToInt32(button.Tag) != test[count].isCorrect;
                return result;
            }

            List<Button> list = new List<Button> { answer1, answer2, answer3, answer4 }; // ���� �� ���� �������
            list = list.Where(isNotCorrect).ToList(); // ������ �� ������ ������� ��������
            list.ForEach(f => f.Visible = false); // ��� �������� ������ ������� ������
            int rand = new Random().Next(0, 2); //�������� ���� �� ���� �������� �������
            list[rand].Visible = true; //������ ��� �������
            
            Fifty.Image = global::Final_project.Properties.Resources.fifty_used; //��������� ����� �� �������
            Fifty.Enabled = false; // ����� ������������� ���������� ����������������
        }

        private void lifeline_callfriend(object sender, EventArgs e)
        {
            int chance = new Random().Next(0, 3); // ����� ������ ��������
            MessageBox.Show("��� ���� �������, ��� ���������� ����� ��� " + test[count].answers[chance]);
            CallFriends.Image = global::Final_project.Properties.Resources.call_used;
            CallFriends.Enabled= false;
        }

        private void lifeline_audiance(object sender, EventArgs e)
        {
            int sum = 100; // ���������
            int[] values = new int[4]; //4 ��������
            for(int a =0; a < 3; a++)
            {
                if(a + 1 == test[count].isCorrect) // a+1 ������ ��� ������� � 1 ����������, � ������ � 0
                {

                    values[a] = new Random().Next(Convert.ToInt32(sum / 3), sum); // ������ �� 33 �� 100 ����� ����������� ����������� ������ ���� ����
                    sum -= values[a]; // ����� ����� �� ���� ������ ��� �� ����������
                }

                else //���� ����� �� ������ �� ����������� ����
                {
                    values[a] = new Random().Next(Convert.ToInt32(sum / 3));
                    sum-= values[a];
                }
            }
            values[3] = sum;

            BarOfAudience barOfAudience = new BarOfAudience();

            barOfAudience.audiance(values[0], values[1], values[2], values[3]); // ���������� �������� ������ �������� � �������� ���
            barOfAudience.Show();
            Audience.Image = global::Final_project.Properties.Resources.audiance_used;
            Audience.Enabled = false;

        }
        #endregion
        private void Exit_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void MoneyTree_SelectedIndexChanged(object sender, EventArgs e) //���������� � ����������� �����
        {
            if (MoneyTree.SelectedIndex == 12 || MoneyTree.SelectedIndex == 7 || MoneyTree.SelectedIndex == 0)
            {
                MessageBox.Show("��c�������� �����!");
            }
            else MoneyTree.Focus();
        }

    }
}
