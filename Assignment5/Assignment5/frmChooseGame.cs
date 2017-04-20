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
    public partial class frmChooseGame : Form
    {
        #region Attributes

        /// <summary>
        /// Initialize clsGame class
        /// </summary>
        clsGame game;

        /// <summary>
        /// Initialize clsUserObjectManager class
        /// </summary>
        clsUserObjectManager clsMyUserObjectManager;

        /// <summary>
        /// Initialize frmGame form
        /// </summary>
        frmGame frmGameForm;

        #endregion

        #region Methods

        /// <summary>
        /// Constructor, passes in UserObjectManager class
        /// </summary>
        /// <param name="clsObjectManager"></param>
        public frmChooseGame(clsUserObjectManager clsObjectManager)
        {
            try
            {
                InitializeComponent();
                game = new clsGame();
                clsMyUserObjectManager = clsObjectManager;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void frmChooseGame_Load(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"dragon.wav");
                simpleSound.Play();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// On click, plays addition game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddGame_Click(object sender, EventArgs e)
        {
            try
            {
                game.operation = "+";
                frmGameForm = new frmGame(game, clsMyUserObjectManager);
                this.Hide();
                frmGameForm.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// On click, plays subtraction game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubGame_Click(object sender, EventArgs e)
        {
            try
            {
                game.operation = "-";
                frmGameForm = new frmGame(game, clsMyUserObjectManager);
                this.Hide();
                frmGameForm.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// On click, plays multiplication game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultGame_Click(object sender, EventArgs e)
        {
            try
            {
                game.operation = "x";
                frmGameForm = new frmGame(game, clsMyUserObjectManager);
                this.Hide();
                frmGameForm.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// On click, plays division game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDivideGame_Click(object sender, EventArgs e)
        {
            try
            {
                game.operation = "/";
                frmGameForm = new frmGame(game, clsMyUserObjectManager);
                this.Hide();
                frmGameForm.ShowDialog();
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
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine +
                                             "HandleError Exception: " + ex.Message);
            }
        }

        /// <summary>
        /// Returns to the main screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
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
