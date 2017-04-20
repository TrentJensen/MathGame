using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Media;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class frmMainMenu : Form
    {
        #region Attributes

        /// <summary>
        /// Stores class UserObjectManager
        /// </summary>
        clsUserObjectManager clsMyUserObjectManager;

        /// <summary>
        /// Class that shows high scores
        /// </summary>
        frmHighScores frmHighScoresForm;

        /// <summary>
        /// Class to enter user data
        /// </summary>
        frmUserData frmUserDataForm;

        /// <summary>
        /// Class where game is played
        /// </summary>
        frmChooseGame frmChooseGameForm;

        #endregion


        #region Methods

        /// <summary>
        /// Constructor
        /// </summary>
        public frmMainMenu()
        {
            try
            {
                InitializeComponent();

                //Instantiate the UserObjectManager
                clsMyUserObjectManager = new clsUserObjectManager();

                frmHighScoresForm = new frmHighScores(clsMyUserObjectManager);
                frmUserDataForm = new frmUserData(clsMyUserObjectManager);
                frmChooseGameForm = new frmChooseGame(clsMyUserObjectManager);
                lblWelcome.Text = "Welcome!  Please sign in!";
                lblError.Text = "";
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Starts playing sound on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"fanfare.wav");
            simpleSound.Play();

        }

        /// <summary>
        /// Click on the User Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserData_Click(object sender, EventArgs e)
        {
            try
            {
                //Hide this menu
                this.Hide();
                //Show the User Data Form
                frmUserDataForm.ShowDialog();
                //Show this form again
                this.Show();
                lblWelcome.Text = "Hello, " + clsMyUserObjectManager.lstUsers[clsMyUserObjectManager.currentUser].userFirstName + "!";
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// On click, opens the ChooseGame form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGame_Click(object sender, EventArgs e)
        {
            try
            {
                if (clsMyUserObjectManager.lstUsers.Any())
                {
                    this.Hide();
                    frmChooseGameForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    lblError.Text = "Please create a new player";
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// On click, opens the Scores form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScores_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmHighScoresForm.ShowDialog();
                this.Show();
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
            catch(Exception ex)
            {
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine +
                                             "HandleError Exception: " + ex.Message);
            }
        }

        /// <summary>
        /// Changes button imageindex to open treasure on mouse hover
        /// </summary>
        private void btnUserData_MouseHover(object sender, EventArgs e)
        {
            btnUserData.ImageIndex = 1;
        }

        /// <summary>
        /// Changes button imageindex to open treasure on mouse leave
        /// </summary>
        private void btnUserData_MouseLeave_1(object sender, EventArgs e)
        {
            btnUserData.ImageIndex = 0;
        }

        /// <summary>
        /// Changes button imageindex to open treasure on mouse hover
        /// </summary>
        private void btnGame_MouseHover(object sender, EventArgs e)
        {
            btnGame.ImageIndex = 1;
        }

        /// <summary>
        /// Changes button imageindex to open treasure on mouse leave
        /// </summary>
        private void btnGame_MouseLeave(object sender, EventArgs e)
        {
            btnGame.ImageIndex = 0;
        }

        /// <summary>
        /// Changes button imageindex to open treasure on mouse hover
        /// </summary>
        private void btnScores_MouseHover(object sender, EventArgs e)
        {
            btnScores.ImageIndex = 1;
        }

        /// <summary>
        /// Changes button imageindex to open treasure on mouse leave
        /// </summary>
        private void btnScores_MouseLeave(object sender, EventArgs e)
        {
            btnScores.ImageIndex = 0;
        }

        #endregion


    }
}
