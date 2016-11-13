using System;
using System.IO;
using System.Windows.Forms;

namespace Big2GameApplication
{
    public partial class UserControl1 : UserControl
    {
        string Filename = "";
        int[] playerscore = new int[4];
        bool succRead = true;

        public event EventHandler UserControlButtonClicked;

        private void OnUserControlButtonClick()
        {
            if (UserControlButtonClicked != null)
            {
                UserControlButtonClicked(this, EventArgs.Empty);
            }
        }

        public string getFileName()
        {
            return Filename;
        }

        public bool getsuccRead()
        {
            return succRead;
        }

        public int[] getplayerscore()
        {
            return playerscore;
        }

        public UserControl1()
        {
            InitializeComponent();
        }    

        private void button1hover(object sender, EventArgs e)
        {

        }

        private void button1leave(object sender, EventArgs e)
        {

        }

        private void button1Onclick(object sender, MouseEventArgs e)
        {
            succRead = false;
            OnUserControlButtonClick();
        }

        private void LoadScore()
        {
            OpenFileDialog dialog1 = new OpenFileDialog();
            dialog1.Filter = "txt files (*.txt)|*.txt";
            if (dialog1.ShowDialog(this) == DialogResult.Cancel)
            {
                succRead = false;
                Console.WriteLine("Log : Cancel action");
            }
            else
            {
                Filename = dialog1.FileName;
                int counter = 0;

                string tempString = "";
                string[] line = new string[9];

                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader(Filename);
                while ((tempString = file.ReadLine()) != null)
                {
                    if (counter < 9)
                    {
                        line[counter] = tempString;
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                file.Close();
                if (counter < 9)
                {
                    succRead = false;
                    Console.WriteLine("Log : Wrong number of words are read from the score file");
                }

                if (line[0] == "Score" && succRead == true)
                {
                    int count = 0;
                    for (int i = 1; i < 9; i++)
                    {
                        if (i % 2 == 0)
                        {
                            if (isInteger(line[i]))
                            {
                                playerscore[count] = Int32.Parse(line[i]);
                                count += 1;
                            }
                            else
                            {
                                succRead = false;
                                Console.WriteLine("Log : Not a integer in" + i);
                            }
                        }
                    }
                }
                else
                {
                    succRead = false;
                }
                if (succRead == false)
                {
                    MessageBox.Show("Wong Score File");
                    succRead = true;
                    Filename = "";
                }
                else
                {
                    Console.WriteLine("Log : Succ Read");
                    for (int i = 0; i < 4; i++ )
                    {
                        Console.WriteLine("Log : player" + i + " " + playerscore[i]);
                    }
                    OnUserControlButtonClick();
                }
            }
        }

        private bool isInteger(String x)
        {
            int value;
            if (int.TryParse(x, out value))
            {
                return true;
            }
            return false;
        }

        private void loadScoreMouseKick(object sender, MouseEventArgs e)
        {
            LoadScore();
        }

        private void Aboutuskick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Our development team , \n53975370 Chen Xing Quan , Hansen , \n54439417 Cheng Chi Fung , \n54451615 Chiu Kuwn Hung , \n54437215 Lam Tsz Kwan , \n54420558 Wong Kit Ming"); //WinForms
        }
    }
}
