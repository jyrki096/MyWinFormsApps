namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private int mapSize;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private Player player;
        private int bestScore = PlayersResultsStorage.GetBestScore();



        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            player = new Player(welcomeForm.Name);
            bestScoreLabel.Text = bestScore.ToString();
            mapSize = welcomeForm.MatrixSize;
            InitMap();
            GenerateNumber();
            ShowScore();
        }

        private void ShowScore()
        {
            scoreLabel.Text = player.Score.ToString();
        }

        private void GenerateNumber()
        {
            var numbers = new int[4] { 2, 2, 2, 4 };

            while (true)
            {
                if (IsFull())
                    break;

                var randomNumberIndex = random.Next(numbers.Length);
                var randomNumberLable = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLable / mapSize;
                var indexColumn = randomNumberLable % mapSize;
                var cell = labelsMap[indexRow, indexColumn];
                if (cell.Text == string.Empty)
                {
                    labelsMap[indexRow, indexColumn].Text = numbers[randomNumberIndex].ToString();
                    break;
                }
            }
        }

        private void InitMap()
        {
            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLable = CreateLabel(i, j, i * mapSize + j);
                    Controls.Add(newLable);
                    labelsMap[i, j] = newLable;
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn, int number)
        {
            label = new Label();

            label.BackColor = Color.BurlyWood;
            label.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = Color.Black;

            int x = 10 + indexColumn * 76;
            int y = 70 + indexRow * 76;
            label.Location = new Point(x, y);

            label.Size = new Size(70, 70);
            label.TabIndex = 0;
            label.TextAlign = ContentAlignment.MiddleCenter;

            label.TextChanged += Label_TextChanged;

            return label;
        }

        private void Label_TextChanged(object? sender, EventArgs e)
        {
            SetBackColorLabel((Label)sender);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                PressRight();

            if (e.KeyCode == Keys.Left)
                PressLeft();

            if (e.KeyCode == Keys.Up)
                PressUp();

            if (e.KeyCode == Keys.Down)
                PressDown();

            ShowBestScore();
            ShowScore();

            if (Win())
            {
                PlayersResultsStorage.SavePlayerResult(player);
                MessageBox.Show("Поздравляем!!! Вы прошли игру 2048!");
                return;
            }

            if (Lose())
            {
                PlayersResultsStorage.SavePlayerResult(player);
                MessageBox.Show($"{player.Name}, вы проиграли");
            }
        }

        private void ShowBestScore()
        {
            if (player.Score > bestScore)
            {
                bestScoreLabel.Text = player.Score.ToString();
                return;
            }
            bestScoreLabel.Text = bestScore.ToString();
        }

        private bool Win()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "2048")
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
        private bool Lose()
        {
            if (!IsFull())
                return false;
            
            for (int i = 0; i < mapSize - 1; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text == labelsMap[i, j + 1].Text || labelsMap[i, j].Text == labelsMap[i + 1, j].Text)
                        return false;
                }
            }

            return true;
        }
        private void PressDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    player.Score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            GenerateNumber();
        }

        private void PressUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    player.Score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            GenerateNumber();
        }

        private void PressLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    player.Score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            GenerateNumber();
        }

        private void PressRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    player.Score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            GenerateNumber();
        }

        private bool IsFull()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void newGameMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
             "Уверены, что хотите начать новую игру?",
             "Начало новой игры",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
            );
            if (dialog == DialogResult.Yes)
            {
                PlayersResultsStorage.SavePlayerResult(player);
                Application.Restart();
            }

        }

        private void rulesMenuButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Соединяй числа и получи плитку 2048!\n" +
                $"КАК ИГРАТЬ:\n" +
                $"Используйте стрелки на клавиатуре, чтобы перемещать плитки. Когда две плитки с одинаковыми цифрами соприкасаются, они сливаются в одну!", "Правила игры");
        }

        private void exitMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
             "Уверены, что хотите выйти из игры!\nТекущий прогресс может быть потерян!",
             "Выход",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
            );
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void resultsMenuItem_Click(object sender, EventArgs e)
        {
            PlayersResults playersResults = new PlayersResults();
            playersResults.Show();
        }

        private void SetBackColorLabel(Label label)
        {
            if (label.Text == string.Empty)
            {
                label.BackColor = Color.BurlyWood;
                return;
            }



            int num = int.Parse(label.Text);

            switch (num)
            {
                case 2:
                    label.BackColor = Color.Gainsboro;
                    break;
                case 4:
                    label.BackColor = Color.Silver;
                    break;
                case 8:
                    label.BackColor = Color.LightCoral;
                    break;
                case 16:
                    label.BackColor = Color.Coral;
                    break;
                case 32:
                    label.BackColor = Color.IndianRed;
                    break;
                case 64:
                    label.BackColor = Color.Red;
                    break;
                case 128:
                    label.BackColor = Color.FromArgb(255, 255, 192);
                    break;
                case 256:
                    label.BackColor = Color.FromArgb(255, 255, 128);
                    break;
                case 512:
                    label.BackColor = Color.Yellow;
                    break;
                case 1024:
                    label.BackColor = Color.Goldenrod;
                    break;
                case 2048:
                    label.BackColor = Color.Gold;
                    break;
            }
        }

        

        
    }


}