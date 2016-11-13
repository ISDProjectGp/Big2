using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Big2GameApplication
{
    partial class UserControl2
    {

        // Gobal Flag // 
        private Timer t;                                                       //  Timer t for controller the event //
        private IContainer components = null;                                  //  The container of the components //
        private List<PictureBox> pictureBoxList3 = new List<PictureBox>();       
        private List<PictureBox> pictureBoxList2 = new List<PictureBox>();
        private List<CardBackgroundPictureBox> TempPictureBoxList;
        private PictureBox shufflingIcon;                                      // The picture box to hold the shuffling icon //
        private PictureBox releasebutton;                                      // The picture box to hold the relead button //
        private int cardnum = 0;                                               // Controlling flag 1 //
        private Boolean stop = false;                                          // Controlling flag 2 // 
        private int turn = 1;                                                  // Controlling flag 3 //
        private int counter = 0;                                               // Controlling flag 4 //
        private bool Onclick = false;                                          // The controlling flag for onclick //
        private int counter2 = 0;                                              // Controlling flag 5 //
        private Timer t2;                                                      // Timer t2 for contolling the even //
        private bool onecardleft = false;                                      // A controlling flag if one card left //  
        private List<CardBackgroundPictureBox> TempPictureBoxList2;            // player 1 cards back  //
        private List<CardBackgroundPictureBox> TempPictureBoxList3;            // player 2 cards back // 
        private List<CardBackgroundPictureBox> TempPictureBoxList1;            // player 3 cards back //                
        //!--Gobal Flag--// 

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        // Init the Component // 
        private void InitializeComponent()
        {
            // Init the resources manager // 
            resources = new ComponentResourceManager(typeof(UserControl2));
            this.shufflingIcon = new PictureBox();
            ((ISupportInitialize)(this.shufflingIcon)).BeginInit();
            this.SuspendLayout();

            // 
            // Init ShuffingIcon
            // 
            this.shufflingIcon.BackColor = Color.Transparent;
            this.shufflingIcon.BackgroundImage = ((Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.shufflingIcon.BackgroundImageLayout = ImageLayout.Stretch;
            this.shufflingIcon.Location = new Point(397, 232);
            this.shufflingIcon.Name = "shuffingIcon";
            this.shufflingIcon.Size = new Size(613, 165);
            this.shufflingIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            this.shufflingIcon.TabIndex = 0;
            this.shufflingIcon.TabStop = false;
            // 
            // Init Loading and ChessPage
            // 
            this.AutoScaleDimensions = new SizeF(8F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = ((Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.shufflingIcon);
            this.Name = "ChessPage";
            this.Size = new Size(1600, 1200);
            ((ISupportInitialize)(this.shufflingIcon)).EndInit();
            this.ResumeLayout(false);
            // 
            // Init release button
            // 
            releasebutton = new PictureBox()
            {
                Location = new Point(970, 500),
                Name = "release",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(140, 60),
                BackgroundImage = ((System.Drawing.Image)(resources.GetObject("release"))),
                TabIndex = 1,
                TabStop = false
            };
            releasebutton.Click += picOneFaceUpB_Click;

            // 
            // Init pass button
            // 
            pass = new PictureBox()
            {
                Location = new Point(970, 580),
                Name = "release",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(140, 60),
                BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pass"))),
                TabIndex = 1,
                TabStop = false
            };
            pass.Click += picOneFaceUpC_Click;

            // 
            // player1 icon 
            // 
            player1 = new PictureBox()
            {
                Location = new Point(20, 70),
                Name = "player",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(40, 40),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/player1.png"),
                TabIndex = 1,
                TabStop = false
            };

            // 
            // player1 text
            // 
            player1text = new PictureBox()
            {
                Location = new Point(60, 70),
                Name = "playertext",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(130, 50),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/player1text.png"),
                TabIndex = 1,
                TabStop = false
            };

            // 
            // player0 icon
            // 
            player0 = new PictureBox()
            {
                Location = new Point(20, 20),
                Name = "player",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(40, 40),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/player0.png"),
                TabIndex = 1,
                TabStop = false
            };

            // 
            // player0 text
            // 
            player0text = new PictureBox()
            {
                Location = new Point(60, 20),
                Name = "playertext",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(130, 50),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/player0text.png"),
                TabIndex = 1,
                TabStop = false
            };

            // 
            // player2 icon
            // 
            player2 = new PictureBox()
            {
                Location = new Point(20, 120),
                Name = "player",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(40, 40),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/player2.png"),
                TabIndex = 1,
                TabStop = false
            };

            // 
            // player2 text
            // 
            player2text = new PictureBox()
            {
                Location = new Point(60, 120),
                Name = "playertext",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(130, 50),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/player2text.png"),
                TabIndex = 1,
                TabStop = false
            };

            // 
            // player4 icon
            // 
            player3 = new PictureBox()
            {
                Location = new Point(20, 170),
                Name = "player",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(40, 40),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/player3.png"),
                TabIndex = 1,
                TabStop = false
            };

            // 
            // player3 text
            //
            player3text = new PictureBox()
            {
                Location = new Point(60, 170),
                Name = "playertext",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(130, 50),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/player3text.png"),
                TabIndex = 1,
                TabStop = false
            };

            // 
            // the sign to show the players in the now turn 
            //
            nowplay = new PictureBox()
            {
                Location = new Point(190, 20),
                Name = "nowplay",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(130, 50),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/nowplay.png"),
                TabIndex = 1,
                TabStop = false
            };
        }

        // Start the loading Animation // 
        private void shufflingAnimation()
        {
            // Init the loading cards //
            TempPictureBoxList = new List<CardBackgroundPictureBox>();
            for (int i = 0; i < 7; i++)
            {   
                CardBackgroundPictureBox pb = new CardBackgroundPictureBox("LoadingCard" + i, false);
                pb.BackgroundImage = ((Image)(resources.GetObject("playing-card-back")));
                pb.setLocation(550, 350);
                TempPictureBoxList.Add(pb);
                this.Controls.Add(pb);
            }

            // start the timer , to move the cards in each second // 
            t = new Timer();
            t.Interval = 10;
            t.Tick += new EventHandler(LoadingTimeTickAnimation);  //each one second do this action // 
            t.Start();                                             //start the timer // 
        }

        // Each time TimerTick in loading animation//
        void LoadingTimeTickAnimation(object sender, EventArgs e)
        {
            // The action of moving the cards in the suffling animation // 
            counter++;
            if (counter == 70)  // if the counter is equal 70 , stop the timer 
            {
                t.Stop();
                this.Controls.Clear();
                Start();        //-> start to display the cards // 
                return;
            }
            if (turn == 0)
            {
                if (stop == false)
                {
                    if (cardnum < 7)
                    {
                        for (int i = 0; i < cardnum; i++)
                        {
                            int newX = TempPictureBoxList[i].Location.X + 30;
                            TempPictureBoxList[i].Location = new Point(newX, TempPictureBoxList[i].Location.Y);
                        }
                        cardnum++;
                    }
                    else
                    {
                        stop = true;
                        cardnum = 0;
                    }
                }
                else
                {
                    if (cardnum < 6)
                    {
                        for (int i = 6; i > cardnum; i--)
                        {
                            int newX = TempPictureBoxList[i].Location.X + 30;
                            TempPictureBoxList[i].Location = new Point(newX, TempPictureBoxList[i].Location.Y);
                        }
                        cardnum++;
                    }
                    else
                    {
                        turn = 1;
                        stop = false;
                        cardnum = 0;
                    }
                }

            }
            else if (turn == 1)
            {
                if (stop == false)
                {
                    if (cardnum < 7)
                    {
                        for (int i = 0; i < cardnum; i++)
                        {
                            int newX = TempPictureBoxList[i].Location.X - 30;
                            TempPictureBoxList[i].Location = new Point(newX, TempPictureBoxList[i].Location.Y);
                        }
                        cardnum++;
                    }
                    else
                    {
                        stop = true;
                        cardnum = 0;
                    }
                }
                else
                {
                    if (cardnum < 6)
                    {
                        for (int i = 6; i > cardnum; i--)
                        {
                            int newX = TempPictureBoxList[i].Location.X - 30;
                            TempPictureBoxList[i].Location = new Point(newX, TempPictureBoxList[i].Location.Y);
                        }
                        cardnum++;
                    }
                    else
                    {
                        turn = 0;
                        stop = false;
                        cardnum = 0;
                    }
                }

            }
            // // // // // // // // // // // // // // // // // // /// // // // // 
        }

        // the process after the shuffling  animation , display the cards // 
        private void Start()
        {
            t = new Timer();
            t.Interval = 10;
            TempPictureBoxList2 = new List<CardBackgroundPictureBox>();        // store player 1 cards back  //
            TempPictureBoxList1 = new List<CardBackgroundPictureBox>();        // store player 2 cards back // 
            TempPictureBoxList3 = new List<CardBackgroundPictureBox>();        // store player 3 cards back // 
            t.Tick += new EventHandler(timer_Tick2);        // time_tick 2 -> the displaycard animation //
            TempPictureBoxList.Clear();                     // clear the cards in ceated during the shuffling animation //
            cardnum = 0;                                    // reset all the flag //
            counter = 0;     
            t.Start();                                      // start the display cards animation //
        }

        // Each time TimeTick in display cards animation //
        void timer_Tick2(object sender, EventArgs e)
        {
            // player1 card back // 
            CardBackgroundPictureBox pb = new CardBackgroundPictureBox("ChessCard" + counter,false);
            pb.BackgroundImage = ((Image)(resources.GetObject("playing-card-back")));
            pb.setLocation(470 + (10 * counter), 70);
            TempPictureBoxList2.Add(pb);
            this.Controls.Add(pb);

            // player0 card back  // 
            pb = new CardBackgroundPictureBox("ChessCard" + counter+12,false);
            pb.BackgroundImage = ((Image)(resources.GetObject("playing-card-back")));
            pb.setLocation(240 + (50 * counter), 500);
            TempPictureBoxList.Add(pb);
            this.Controls.Add(pb);

            // player2 card back // 
            pb = new CardBackgroundPictureBox("ChessCard" + counter+25, true);
            pb.BackgroundImage = ((Image)(resources.GetObject("playing-card-back2")));
            pb.setLocation(970, 250 + (10 * counter));
            TempPictureBoxList3.Add(pb);
            this.Controls.Add(pb);

            // player3 card back // 
            pb = new CardBackgroundPictureBox("ChessCard" + counter+37, true);
            pb.BackgroundImage = ((Image)(resources.GetObject("playing-card-back2")));
            pb.setLocation(70, 250 + (10 * counter));
            TempPictureBoxList1.Add(pb);
            this.Controls.Add(pb);

            // if display all cards // 
            counter++;
            if (counter == 13)
            {
                this.Controls.Add(player1);
                player1.Show();                      // show the player 1 icon // 
                this.Controls.Add(player1text);
                player1text.Show();                         // show the player 1 text // 
                this.Controls.Add(player0);
                player0.Show();                           // show the player 0 icon // 
                this.Controls.Add(player2text);
                player2text.Show();                      // show the player 2 text// 
                this.Controls.Add(player3text);
                player3text.Show();                       // show the player 3 text // 
                this.Controls.Add(player0text);
                player0text.Show();                       // show the player 0 text // 
                this.Controls.Add(player2);
                player2.Show();                            // show the player 2 icon // 
                this.Controls.Add(player3);
                player3.Show();                            // show the player 3 icon // 
                t.Stop();
                t = new Timer();                          // show the player 1 icon // 
                t.Interval = 10;
                t.Tick += new EventHandler(timer_Tick3);  // start show cards animation  // 
                cardnum = 0;
                counter = 0;
                t.Start();
            }

        }

        // Each time TimeTick in  hide the card back animation //
        private void timer_Tick5(object sender, EventArgs e)
        {
            // if the the controll flag is less than 12 //
            if (counter2 < 12)
            {
                TempPictureBoxList2[12 - counter2].Hide();
                TempPictureBoxList3[12 - counter2].Hide();
                TempPictureBoxList1[12 - counter2].Hide();
            }
            counter2++;
            if (counter2 == 13)
            {
                t2.Stop();
                t2 = new Timer();
                t2.Interval = 10;
                t2.Tick += new EventHandler(timer_Tick6);  // start the show player0 front cards animation  //
                counter2 = 0;
                t2.Start();
            }
        }

        // Each time TimeTick in  Refresh icon animation   //
        private void timer_Tick6(object sender, EventArgs e)
        {
            show(counter2);
            counter2++;
            if (counter2 == 13)
            {
                t2.Stop();
                counter2 = 0;
            }
        }

        // Each time Timetick in show now turn player cards front animation //
        private void timer_Tick4(object sender, EventArgs e)
        {
            // if not display all the cards of the now turn players have not been completely display //
            if (counter < gameController.getHandNo(gameController.getTurn()))
            {
                TempPictureBoxList[12 - counter].Show();
            }
 
            counter++;
            if (counter == 13)
            {
                t.Stop();
                for (int i = 0; i < HandList.Count; i++)
                {
                    HandList[i].Hide();
                }
                for (int i = 0; i < LastList.Count; i++)
                {
                    LastList[i].Show();
                }
                HandList.Clear();
                counter = 0;
                t = new Timer();
                t.Interval = 80;
                t.Tick += new EventHandler(timer_Tick3);
                t.Start();
            }
        }

        // Refresh the postion of the icon // 
        private void show(int counter)
        {
            if (gameController.getTurn() == 3)
            {
                if (counter < gameController.getHandNo(2)-1)
                    TempPictureBoxList1[counter].Show();
                if (counter < gameController.getHandNo(1)-1)
                    TempPictureBoxList2[counter].Show();
                if (counter < gameController.getHandNo(0)-1)
                    TempPictureBoxList3[counter].Show();
               
            }
            else if (gameController.getTurn() == 2)
            {
                if (counter+1<gameController.getHandNo(1))
                    TempPictureBoxList1[counter + 1].Show();
                if (counter + 1 < gameController.getHandNo(0))
                    TempPictureBoxList2[counter + 1].Show();
                if (counter + 1 < gameController.getHandNo(3))
                    TempPictureBoxList3[counter + 1].Show();
            }
            else if (gameController.getTurn() == 1)
            {
                 if (counter + 1 < gameController.getHandNo(0))
                    TempPictureBoxList1[counter + 1].Show();
                 if (counter + 1 < gameController.getHandNo(3))
                    TempPictureBoxList2[counter + 1].Show();
                 if (counter + 1 < gameController.getHandNo(2))
                    TempPictureBoxList3[counter + 1].Show();
            }
            else if (gameController.getTurn() == 0)
            {
                if (counter + 1 < gameController.getHandNo(3))
                    TempPictureBoxList1[counter + 1].Show();
                if (counter + 1 < gameController.getHandNo(2))
                    TempPictureBoxList2[counter + 1].Show();
                if (counter + 1 < gameController.getHandNo(1))
                    TempPictureBoxList3[counter + 1].Show();
            }

        }

        // Refresh the postion of the icon near the poker//
        private void showicon()
        {
            for (int i = 0; i < 4; i++)
            {
                this.Controls.Add(icon[i]);
                icon[i].Hide();
            }
            if (gameController.getTurn() == 3)
            {
                icon[1].Location = new System.Drawing.Point(565, 10);
                icon[2].Location = new System.Drawing.Point(1120, 315);
                icon[3].Location = new System.Drawing.Point(565, 640);
                icon[0].Location = new System.Drawing.Point(5, 315);
            }
            else if (gameController.getTurn() == 2)
            {
                icon[0].Location = new System.Drawing.Point(565, 10);
                icon[1].Location = new System.Drawing.Point(1120, 315);
                icon[2].Location = new System.Drawing.Point(565, 640);
                icon[3].Location = new System.Drawing.Point(5, 315);
            }
            else if (gameController.getTurn() == 1)
            {
                icon[3].Location = new System.Drawing.Point(565, 10);
                icon[0].Location = new System.Drawing.Point(1120, 315);
                icon[1].Location = new System.Drawing.Point(565, 640);
                icon[2].Location = new System.Drawing.Point(5, 315);
            }
            else if (gameController.getTurn() == 0)
            {
                icon[2].Location = new System.Drawing.Point(565, 10);
                icon[3].Location = new System.Drawing.Point(1120, 315);
                icon[0].Location = new System.Drawing.Point(565, 640);
                icon[1].Location = new System.Drawing.Point(5, 315);
            }
            for (int i = 0; i < 4; i++)
            {
                icon[i].Show();
            }

        }

        // Each time Timetick in hide cards animation after each turn //
        private void timer_Tick3(object sender, EventArgs e)
        {
            if (counter < gameController.getHandNo(gameController.getTurn()))
            {
                TempPictureBoxList[12 - counter].Hide();
                gameController.sortCard();

                HandList.Add(pictureBoxList13[gameController.DisplayCard(gameController.getTurn(), counter)]);
                HandList[counter].setLocation(840 - (50 * counter), 500);
                HandList[counter].Show();
                this.Controls.Add(HandList[counter]);
            }
            counter++;

            if (counter == 13)
            {
                t.Stop();
                Onclick = false;
                showicon();
                setnowplay(gameController.getTurn());
                this.Controls.Add(releasebutton);
                releasebutton.Show();
                this.Controls.Add(pass);
                pass.Show();
            }
        }
        
        // check the cards is selected 
        void picOneFaceUpA_Click(object sender, EventArgs e)
        {
          if (((MyBox)sender).getRelease() == false) { 
            if (((MyBox)sender).isSelected() == true )
            {
                ((MyBox)sender).Location = new System.Drawing.Point(((MyBox)sender).Location.X, ((MyBox)sender).Location.Y + 70);
                ((MyBox)sender).setSelected();
            }
            else
            {
                ((MyBox)sender).Location = new System.Drawing.Point(((MyBox)sender).Location.X, ((MyBox)sender).Location.Y - 70);
                ((MyBox)sender).setSelected();
            }
            }
        }

        // set the now turn player icon 
        void setnowplay(int player)
        {
            int y = 20; 
            switch (player)
            {
                case 0: y = 20; break;
                case 1: y = 70; break;
                case 2: y = 130; break;
                case 3: y = 170; break;

            }
            nowplay.Location = new System.Drawing.Point(nowplay.Location.X, y);
            this.Controls.Add(nowplay);
            nowplay.Show();
        }
       
        // the event handler of the pass button 
        void picOneFaceUpC_Click(object sender, EventArgs e)
        {
          
              if (Onclick == false)
              {
                Onclick = true;
                for (int i = 0; i < HandList.Count; i++)
                {
                    if (HandList[i].isSelected())
                    {
                        ReleaseList.Add(HandList[i]);
                    }
                }
                if (ReleaseList.Count == 0)
                {
                    if (gameController.release() == true)
                    {
                        if (gameController.checkWin() != true)
                        {
                            t = new Timer();
                            t.Interval = 80;
                            t.Tick += new EventHandler(timer_Tick4);
                            cardnum = 0;
                            counter = 0;
                            t.Start();

                            t2 = new Timer();
                            t2.Interval = 10;
                            t2.Tick += new EventHandler(timer_Tick5);
                            counter2 = 0;
                            t2.Start();
                        }
                        else
                        {
                            MessageBox.Show("The winner is player : " + gameController.getWinner() + " , Congradration !!");
                            ReleaseList.Clear();
                            Onclick = false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("You cannot pass, please release some cards");
                        Onclick = false;
                    }
                }
                else
                {
                    MessageBox.Show("If you want to pass, please don't select card!!");
                    ReleaseList.Clear();
                    Onclick = false;
                }
              }
        }

        // the event handler of the release button 
        void picOneFaceUpB_Click(object sender, EventArgs e)
        {        
                if (Onclick == false)
                {
                  Onclick = true;
                  for (int i = 0; i < HandList.Count; i++)
                  {
                    if (HandList[i].isSelected())
                    {
                        ReleaseList.Add(HandList[i]);
                    }
                  }
                  if (ReleaseList.Count > 0)
                  {
                   
                    if (ReleaseList.Count <= 5)
                    {
                        for (int i = 0; i < ReleaseList.Count; i++)
                        {

                            gameController.inputCard(ReleaseList[i].getValue());

                        }
                        if (gameController.release() == true)
                        {
                            for (int i = 0; i < LastList.Count; i++)
                            {
                                LastList[i].Hide();
                            }
                            if (ReleaseList.Count != 0)
                            {
                                LastList.Clear();
                            }
                            for (int i = 0; i < ReleaseList.Count; i++)
                            {
                                ReleaseList[i].Location = new Point(300 + (110 * i), 250);
                                ReleaseList[i].setRelease();
                                LastList.Add(ReleaseList[i]);
                            }
                            ReleaseList.Clear();
                            t.Stop();
                            if (gameController.checkWin() != true)
                            {
                               if (onecardleft == false) { 
                                for (int i = 0; i < 4; i++)
                                {
                                    if (gameController.isOneCard(i) == true)
                                    {
                                        PictureBox onecardword = new PictureBox()
                                        {
                                            Location = new Point(20, 450),
                                            Name = "playertext",
                                            BackColor = System.Drawing.Color.Transparent,
                                            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                                            Size = new System.Drawing.Size(300, 50),
                                            BackgroundImage = System.Drawing.Image.FromFile("Poker/onecardleft.png"),
                                            TabIndex = 1,
                                            TabStop = false
                                        };
                                        this.Controls.Add(onecardword);
                                        onecardleft = true;
                                        break;
                                    }
                                 }
                                }

                                t = new Timer();
                                t.Interval = 50;
                                t.Tick += new EventHandler(timer_Tick4);
                                cardnum = 0;
                                counter = 0;
                                t.Start();

                                t2 = new Timer();
                                t2.Interval = 10;
                                t2.Tick += new EventHandler(timer_Tick5);
                                counter2 = 0;
                                t2.Start();
                            }
                            else
                            {
                                DialogResult dialogResult = MessageBox.Show("In this round , the winner is player : " + gameController.getWinner() + " , Congratulation !!", "GoToLeaderBoard and Start a new Round OR Quit", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    onecardleft = false;
                                    restartAround();
                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    System.Environment.Exit(1);
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid cards format");
                            ReleaseList.Clear();
                            Onclick = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Maxium is five cards!!");
                        ReleaseList.Clear();
                        Onclick = false;
                    }
                }
                else
                {
                    MessageBox.Show("If you want to release , please select some cards!!");
                    ReleaseList.Clear();
                    Onclick = false;
                }
              }

           
            
        }

        // controll the process when restarting a round //
        private void restartAround()
        {
            gameController.caculatePenaltyScore();
            Console.WriteLine(gameController.getPenaltyScore(1));

            this.Controls.Clear();
            PictureBox leadb = new PictureBox()
            {
                Location = new Point(420, 50),
                Name = "release",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(300, 70),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/leaderboard.png"),
                TabIndex = 1,
                TabStop = false
            };
            this.Controls.Add(leadb);

            PictureBox cm = new PictureBox()
            {
                Location = new Point(540, 170),
                Name = "release",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(240, 50),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/CurrentMark.png"),
                TabIndex = 1,
                TabStop = false
            };

            this.Controls.Add(cm);

            PictureBox pm = new PictureBox()
            {
                Location = new Point(800, 170),
                Name = "release",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(240, 70),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/PenaltyMark.png"),
                TabIndex = 1,
                TabStop = false
            };

            this.Controls.Add(pm);

            player0.Location = new Point(370, 240);
            player1.Location = new Point(370, 300);
            player2.Location = new Point(370, 360);
            player3.Location = new Point(370, 420);

            player0text.Location = new Point(420, 240);
            player1text.Location = new Point(420, 300);
            player2text.Location = new Point(420, 360);
            player3text.Location = new Point(420, 420);

            this.Controls.Add(player0);
            this.Controls.Add(player1);
            this.Controls.Add(player2);
            this.Controls.Add(player3);
            this.Controls.Add(player0text);
            this.Controls.Add(player1text);
            this.Controls.Add(player2text);
            this.Controls.Add(player3text);

            int player0s = gameController.getScore(0);
            int player1s = gameController.getScore(1);
            int player2s = gameController.getScore(2);
            int player3s = gameController.getScore(3);

            string temps = player0s.ToString();
            for (int i = 0; i < temps.Length; i++)
            {               
                PictureBox ww = new PictureBox()
                {
                    Location = new Point(550 + (i * 60), 240),
                    Name = "release",
                    BackColor = System.Drawing.Color.Transparent,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                    Size = new System.Drawing.Size(70, 70),
                    BackgroundImage = System.Drawing.Image.FromFile("Poker/score" + temps[i] + ".png"),
                    TabIndex = 1,
                    TabStop = false
                };
                this.Controls.Add(ww);
            }

            temps = player1s.ToString();
            for (int i = 0; i < temps.Length; i++)
            {
                PictureBox ww = new PictureBox()
                {
                    Location = new Point(550 + (i * 60), 300),
                    Name = "release",
                    BackColor = System.Drawing.Color.Transparent,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                    Size = new System.Drawing.Size(70, 70),
                    BackgroundImage = System.Drawing.Image.FromFile("Poker/score" + temps[i] + ".png"),
                    TabIndex = 1,
                    TabStop = false
                };
                this.Controls.Add(ww);
            }

           temps = player2s.ToString();
            for (int i = 0; i < temps.Length; i++)
            {
                PictureBox ww = new PictureBox()
                {
                    Location = new Point(550 + (i * 60), 360),
                    Name = "release",
                    BackColor = System.Drawing.Color.Transparent,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                    Size = new System.Drawing.Size(70, 70),
                    BackgroundImage = System.Drawing.Image.FromFile("Poker/score" + temps[i] + ".png"),
                    TabIndex = 1,
                    TabStop = false
                };
                this.Controls.Add(ww);
            }

            temps = player3s.ToString();
            for (int i = 0; i < temps.Length; i++)
            {
                PictureBox ww = new PictureBox()
                {
                    Location = new Point(550 + (i * 60), 420),
                    Name = "release",
                    BackColor = System.Drawing.Color.Transparent,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                    Size = new System.Drawing.Size(70, 70),
                    BackgroundImage = System.Drawing.Image.FromFile("Poker/score" + temps[i] + ".png"),
                    TabIndex = 1,
                    TabStop = false
                };
                this.Controls.Add(ww);
            }

            player0s = gameController.getPenaltyScore(0);
            player1s = gameController.getPenaltyScore(1);
            player2s = gameController.getPenaltyScore(2);
            player3s = gameController.getPenaltyScore(3);

            temps = "-"+player0s.ToString();
            for (int i = 0; i < temps.Length; i++)
            {
                PictureBox ww = new PictureBox()
                {
                    Location = new Point(800 + (i * 60), 240),
                    Name = "release",
                    BackColor = System.Drawing.Color.Transparent,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                    Size = new System.Drawing.Size(70, 70),
                    BackgroundImage = System.Drawing.Image.FromFile("Poker/score" + temps[i] + ".png"),
                    TabIndex = 1,
                    TabStop = false
                };
                this.Controls.Add(ww);
            }

            temps = "-"+player1s.ToString();
            for (int i = 0; i < temps.Length; i++)
            {
                PictureBox ww = new PictureBox()
                {
                    Location = new Point(800 + (i * 60), 300),
                    Name = "release",
                    BackColor = System.Drawing.Color.Transparent,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                    Size = new System.Drawing.Size(70, 70),
                    BackgroundImage = System.Drawing.Image.FromFile("Poker/score" + temps[i] + ".png"),
                    TabIndex = 1,
                    TabStop = false
                };
                this.Controls.Add(ww);
            }

            temps = "-" + player2s.ToString();
            for (int i = 0; i < temps.Length; i++)
            {
                PictureBox ww = new PictureBox()
                {
                    Location = new Point(800 + (i * 60), 360),
                    Name = "release",
                    BackColor = System.Drawing.Color.Transparent,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                    Size = new System.Drawing.Size(70, 70),
                    BackgroundImage = System.Drawing.Image.FromFile("Poker/score" + temps[i] + ".png"),
                    TabIndex = 1,
                    TabStop = false
                };
                this.Controls.Add(ww);
            }

            temps = "-"+player3s.ToString();


            for (int i = 0; i < temps.Length; i++)
            {
                PictureBox ww = new PictureBox()
                {
                    Location = new Point(800 + (i * 60), 420),
                    Name = "release",
                    BackColor = System.Drawing.Color.Transparent,
                    BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                    Size = new System.Drawing.Size(70, 70),
                    BackgroundImage = System.Drawing.Image.FromFile("Poker/score" + temps[i] + ".png"),
                    TabIndex = 1,
                    TabStop = false
                };
                this.Controls.Add(ww);
            }

            PictureBox nextbutton = new PictureBox()
            {
                Location = new Point(370, 500),
                Name = "release",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(200, 60),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/NextRound.png"),
                TabIndex = 1,
                TabStop = false
            };
            gameController.caculateTotalScore();

            PictureBox savebutton = new PictureBox()
            {
                Location = new Point(600, 500),
                Name = "release",
                BackColor = System.Drawing.Color.Transparent,
                BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                Size = new System.Drawing.Size(200, 60),
                BackgroundImage = System.Drawing.Image.FromFile("Poker/save.png"),
                TabIndex = 1,
                TabStop = false
            };
            nextbutton.Click += picOneFaceUpd_Click;
            savebutton.Click += picOneFaceUpW_Click;

            this.Controls.Add(savebutton);
            this.Controls.Add(nextbutton);

        }
        
        // the event handler of the next round button //
        void picOneFaceUpd_Click(object sender, EventArgs e)
        {
            pictureBoxList13.Clear();
            HandList.Clear();
            ReleaseList.Clear();
            LastList.Clear();
            icon.Clear();
            pictureBoxList3.Clear();
            pictureBoxList2.Clear();
            TempPictureBoxList.Clear();
            counter2 = 0;
            cardnum = 0;
            stop = false;
            turn = 1;
            counter = 0;
            Onclick = false;

            this.Controls.Clear();
            gameController.play();
            InitializeComponent();
            gameController.shuffleAndDual();

            for (int i = 0; i < 52; i++)
            {
                MyBox a = new MyBox("poker" + i, i);
                a.BackgroundImage = System.Drawing.Image.FromFile("Poker/photo" + i + ".jpg");
                a.MouseClick += picOneFaceUpA_Click;
                a.Hide();
                pictureBoxList13.Add(a);
            }
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

            shufflingAnimation();

        }

        // the event handler of the save score button //
        void picOneFaceUpW_Click(object sender, EventArgs e)
        {
            if (succRead == true)
            {
                boolWriteToFile();
            }
            else
            {
                SaveScore();
            }

        }
    }       
    #endregion
}
