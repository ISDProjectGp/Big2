using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GameControllerCode;
using System.Drawing;
using System.IO;

namespace Big2GameApplication
{
    public partial class UserControl2 : UserControl
    {
        private ComponentResourceManager resources;
        private GameController gameController;
        private List<MyBox> pictureBoxList13 = new List<MyBox>();
        private List<MyBox> HandList = new List<MyBox>();
        List<MyBox> ReleaseList = new List<MyBox>();
        List<MyBox> LastList = new List<MyBox>();
        List<PictureBox> icon = new List<PictureBox>();
        private PictureBox player1;
        private PictureBox player1text;
        private PictureBox player0;
        private PictureBox player0text;
        private PictureBox player2;
        private PictureBox player2text;
        private PictureBox player3;
        private PictureBox player3text;
        private PictureBox nowplay;
        private PictureBox pass;

        private string fileName = "";                                 // store fileName 
        private bool succRead = false;                                // a boolean indicate the user success load file //
        private int[] intarray = new int[4];                          // score array // 

        // init the usercontrol2 // 
        public UserControl2()
        {
            // init the interface 
            InitializeComponent();
            // init the game controller //
            gameController = new GameController();

            // shuffling the cards // 
            gameController.shuffleAndDual();           

            // init the poker // 
            for (int i = 0; i < 52; i++)
            {
                MyBox a = new MyBox("poker" + i, i);
                a.BackgroundImage = System.Drawing.Image.FromFile("Poker/photo" + i + ".jpg");
                a.MouseClick += picOneFaceUpA_Click;
                a.Hide();
                pictureBoxList13.Add(a);
            }

            // init the player emoji icon //
            for (int i = 0; i < 4; i++)
            {
                PictureBox pb = new PictureBox();
                pb.BackgroundImage = System.Drawing.Image.FromFile("Poker/player" + i + ".png");
                pb.BackColor = System.Drawing.Color.Transparent;
                pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                pb.Size = new System.Drawing.Size(60, 60);
                pb.TabIndex = 1;
                pb.TabStop = false;
                pb.Hide();
                icon.Add(pb);
            }
            
            // start the suffling animation //
            shufflingAnimation();
        }

        // set the file path if the player have load the score//
        public void setFileName(String path)
        {
            fileName = path;
        }

        // set the score 
        public void setScore(int[] score)
        {
            for (int i = 0; i < 4; i++)
            {
                intarray[i] = score[i];
            }
        }

        // set if the player have load the score file //
        public void setSuccRead()
        {
            succRead = true;
        }

        // set the score 
        public void SetConScore()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("succRead");
                if (succRead == true)
                {
                    gameController.setScore(intarray[i], i);
                }
            }
        }

        // the method for writing the score into the text //
        private void boolWriteToFile()
        {
            using (StreamWriter sw = new StreamWriter(fileName))   //小寫TXT     
            {
                // Add some text to the file.
                sw.WriteLine("Score");
                for (int i = 0; i < 4; i++)
                {
                    sw.WriteLine("player"+i);
                    sw.WriteLine(gameController.getScore(i));
                }
                MessageBox.Show("Already save to: (You can load the score next time)" + fileName);
                // Arbitrary objects can also be written to the file.

            }
        }

        // The method for saving the score of the player
        private void SaveScore()
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.Title = "Save an Score";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                fileName = saveFileDialog1.FileName;
                boolWriteToFile();
                succRead = true;
            }
         }

        // the method to check it is integer //
        private bool isInteger(String x)
        {
            int value;
            if (int.TryParse(x, out value))
            {
                return true;
            }
            return false;
        }

    }
}
