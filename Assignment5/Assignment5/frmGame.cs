using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class frmGame : Form
    {
        #region Attributes

        /// <summary>
        /// Container for clsGame class to be passed in
        /// </summary>
        clsGame game;

        clsUserObjectManager clsMyUserObjectManager;

        /// <summary>
        /// Timer
        /// </summary>
        Timer myTimer;

        /// <summary>
        /// Counter for timer
        /// </summary>
        private int counter = 0;

        /// <summary>
        /// Counts how many questions have been given
        /// </summary>
        private int questionCount = 0;

        /// <summary>
        /// Boolean true when the Start Game button is clicked.
        /// </summary>
        private bool isPlaying = false;

        /// <summary>
        /// Create soundplayer
        /// </summary>
        SoundPlayer simpleSound2;

        #endregion

        #region Methods
        /// <summary>
        /// Constructor for Game form.  clsGame and clsUserObjectManager are passed in
        /// </summary>
        /// <param name="classGame"></param>
        /// <param name="classManager"></param>
        public frmGame(clsGame classGame, clsUserObjectManager classManager)
        {
            try
            {
                InitializeComponent();
                game = classGame;
                clsMyUserObjectManager = classManager;
                lblOperation.Text = game.operation;

                //Hide final stuff
                btnReturn.Hide();
                lblTotal.Hide();
                lblCorrect.Text = "";

                //Set up the timer
                myTimer = new Timer();
                myTimer.Interval = 1000;
                myTimer.Tick += new EventHandler(MyTimer_Tick);

                pictureBoxDragon.Image = imageListDragon.Images[0];
                pictureBoxDragon.Size = new System.Drawing.Size(250, 250);
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// On load, resets correct Answers and incorrect answers from game class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGame_Load(object sender, EventArgs e)
        {
            try
            {
                game.correctAns = 0;
                game.incorrectAns = 0;

                simpleSound2 = new SoundPlayer(@"fight.wav");
                simpleSound2.Play();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// On click, begins timer and displays randomly generated numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBeginGame_Click(object sender, EventArgs e)
        {
            try
            {
                if (questionCount == 0)
                {
                    myTimer.Start();
                    game.generateNums();
                    lblNum1.Text = game.returnNum(0);
                    lblNum2.Text = game.returnNum(1);
                    isPlaying = true;
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Displays the time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MyTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                lblTimer.Text = counter.ToString();
                counter++;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                    MethodInfo.GetCurrentMethod().Name + " ->" + ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int answer;

                if (isPlaying && questionCount < 10)
                {
                    if (Int32.TryParse(txtAnswer.Text, out answer))
                        {
                        if (game.checkAnswer(answer))
                            {
                            lblCorrect.ForeColor = Color.Green;
                            lblCorrect.Text = "Correct!";
                            picKnight.Left += 40;
                        }
                        else
                        {
                            lblCorrect.ForeColor = Color.Red;
                            lblCorrect.Text = "Incorrect!";
                        }
                        questionCount++;

                        txtAnswer.Text = "";
                        game.generateNums();
                        lblNum1.Text = game.returnNum(0);
                        lblNum2.Text = game.returnNum(1);
                        }
                    else
                    {
                        lblCorrect.Text = "Please enter a number";
                    }
                }
                else
                {
                    myTimer.Stop();

                    //After the game ends, hide everything
                    lblNum1.Hide();
                    lblNum2.Hide();
                    lblOperation.Hide();
                    lblTimer.Hide();
                    txtAnswer.Hide();
                    btnBeginGame.Hide();
                    btnSubmit.Hide();
                    lblCorrect.Hide();
                    lblEquals.Hide();

                    //After the game ends, show the congratulations
                    lblTotal.Show();
                    btnReturn.Show();
                    lblTotal.Text = "Your final score was " + game.correctAns + " correct and " + game.incorrectAns + " incorrect.  Your final time was " + counter + " seconds.";

                    questionCount = 0;
                    if (game.correctAns >= 8)
                    {
                        pictureBoxDragon.Image = imageListDragon.Images[1];
                        SoundPlayer simpleSound = new SoundPlayer(@"dragondead.wav");
                        simpleSound.Play();
                        lblTotal.Text += "You slayed the Dragon.  The kingdom is saved!";
                    }
                    else
                    {
                        lblTotal.Text += "You did not defeat the Dragon.  Practice hard and try again!";
                    }

                    if (game.operation == "+")
                    {
                        clsMyUserObjectManager.lstUsers[clsMyUserObjectManager.currentUser].addScore = game.correctAns;
                        clsMyUserObjectManager.lstUsers[clsMyUserObjectManager.currentUser].addTimer = counter;
                    }
                    else if (game.operation == "-")
                    {
                        clsMyUserObjectManager.lstUsers[clsMyUserObjectManager.currentUser].subScore = game.correctAns;
                        clsMyUserObjectManager.lstUsers[clsMyUserObjectManager.currentUser].subTimer = counter;
                    }
                    else if (game.operation == "x")
                    {
                        clsMyUserObjectManager.lstUsers[clsMyUserObjectManager.currentUser].multScore = game.correctAns;
                        clsMyUserObjectManager.lstUsers[clsMyUserObjectManager.currentUser].multTimer = counter;
                    }
                    else if (game.operation == "/")
                    {
                        clsMyUserObjectManager.lstUsers[clsMyUserObjectManager.currentUser].divScore = game.correctAns;
                        clsMyUserObjectManager.lstUsers[clsMyUserObjectManager.currentUser].divTimer = counter;
                    }
                    isPlaying = false;
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSubmit_Click(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                    MethodInfo.GetCurrentMethod().Name + " ->" + ex.Message);
            }
        }

        /// <summary>
        /// On click, hides form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                simpleSound2.Stop();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Handles the error
        /// </summary>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine +
                                             "HandleError Exception: " + ex.Message);
            }
        }

        #endregion

    }
}
