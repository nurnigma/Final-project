namespace Final_project
{

    public partial class GameField : Form
    {
        public struct Question //структура состоит из 3 полей сам вопрос, ответы и правильный ответ
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
            using StreamReader fs = new StreamReader("Resources\\вопросы и ответы.txt"); //из файла ресурсы считываем файл

            while (count < 20)
            {
                
                test[count].question = fs.ReadLine();
                test[count].answers = new string[4]; //четыре варианта

                for (int a = 0; a < 4; a++) //считываем
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
        /// Загружаем вопросы
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
            answer = Convert.ToInt32(((Button)sender).Tag); //ответ формируется по тегу, в теге номер ответа
            if (test[count].isCorrect == answer) // если ответ правильный
            {
                MessageBox.Show("Ответ правильный!");
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
            else // ответ неверный
            {
            
                
            if (MoneyTree.SelectedIndex <= 13 && MoneyTree.SelectedIndex > 7) //проверяются несгораемые суммы
            {
                        
                MessageBox.Show("Ответ неверный! Игра окончена!" + "\n Ваш выигрыш составляет: " + MoneyTree.Items[13].ToString().Substring(2));
                    this.Close();
            }
             else 
             if(MoneyTree.SelectedIndex <=7 && MoneyTree.SelectedIndex != 0)
            {
                    MessageBox.Show("Ответ неверный! Игра окончена!" + "\n Ваш выигрыш составляет: " + MoneyTree.Items[7].ToString().Substring(2));
                    this.Close();
            }
            
            else
            MessageBox.Show(String.Format("Ответ неверный! Игра окончена!\n Ваш выигрыш составляет: {0:C0}", 0)); // не была достигнута несгораемая сумма
            this.Close();
            }
            this.Focus(); // фокус на кнопку при наведение мышкой
            answer1.Visible = true;
            answer2.Visible = true;
            answer3.Visible = true; 
            answer4.Visible = true;
        }


        #region Подсказки: 50/50, звонок другу, спросить зал.

        private void lifeline_fifthy(object sender, EventArgs e)
        {
            
            bool isNotCorrect(Button button) //не верные ответы 
            {
                var result =  Convert.ToInt32(button.Tag) != test[count].isCorrect;
                return result;
            }

            List<Button> list = new List<Button> { answer1, answer2, answer3, answer4 }; // лист из всех ответов
            list = list.Where(isNotCorrect).ToList(); // только те ответы которые неверные
            list.ForEach(f => f.Visible = false); // все неверные кнопки ответов скрыть
            int rand = new Random().Next(0, 2); //выбираем один из трех неверных ответов
            list[rand].Visible = true; //делает его видимым
            
            Fifty.Image = global::Final_project.Properties.Resources.fifty_used; //загрузить фотку на главную
            Fifty.Enabled = false; // после использования становится недействительным
        }

        private void lifeline_callfriend(object sender, EventArgs e)
        {
            int chance = new Random().Next(0, 3); // ответ выдает рандомно
            MessageBox.Show("Ваш друг считает, что правильный ответ это " + test[count].answers[chance]);
            CallFriends.Image = global::Final_project.Properties.Resources.call_used;
            CallFriends.Enabled= false;
        }

        private void lifeline_audiance(object sender, EventArgs e)
        {
            int sum = 100; // процентов
            int[] values = new int[4]; //4 значения
            for(int a =0; a < 3; a++)
            {
                if(a + 1 == test[count].isCorrect) // a+1 потому что вопросы с 1 начинаются, а массив с 0
                {

                    values[a] = new Random().Next(Convert.ToInt32(sum / 3), sum); // рандом от 33 до 100 чтобы вероятность корректного ответа была выше
                    sum -= values[a]; // чтобы сумма не была больше ста не получалась
                }

                else //если ответ не верный то вероятность ниже
                {
                    values[a] = new Random().Next(Convert.ToInt32(sum / 3));
                    sum-= values[a];
                }
            }
            values[3] = sum;

            BarOfAudience barOfAudience = new BarOfAudience();

            barOfAudience.audiance(values[0], values[1], values[2], values[3]); // показываем проценты выбора аудитори в прогресс бар
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

        private void MoneyTree_SelectedIndexChanged(object sender, EventArgs e) //информация о несгораемой сумме
        {
            if (MoneyTree.SelectedIndex == 12 || MoneyTree.SelectedIndex == 7 || MoneyTree.SelectedIndex == 0)
            {
                MessageBox.Show("Неcгораемая сумма!");
            }
            else MoneyTree.Focus();
        }

    }
}
