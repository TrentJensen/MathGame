using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class frmHighScores : Form
    {

        clsUserObjectManager clsMyUserObjectManager;

        /// <summary>
        /// Constructor.  UserObjectManager class is passed in
        /// </summary>
        /// <param name="objectManager"></param>
        public frmHighScores(clsUserObjectManager objectManager)
        {
            try
            {
                InitializeComponent();

                clsMyUserObjectManager = objectManager;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Sets the textbox when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHighScores_Load(object sender, EventArgs e)
        {
            try
            {
                txtScores.Text = string.Format("Name\t\tAge\t+ Score\t+ Time\t- Score\t- Time\tX Score\tX Time\t\u00F7 Score\t\u00F7 Time");
                scoreReport();
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                    MethodInfo.GetCurrentMethod().Name + " ->" + ex.Message);
            }
        }

        public void scoreReport()
        {
            try
            {
                foreach (var user in clsMyUserObjectManager.lstUsers)
                {
                    txtScores.Text += string.Format("\r\n" + user.userFirstName + " " + user.userLastName + "\t" +
                        user.userAge + "\t" + user.addScore + "\t" + user.addTimer + "\t" + user.subScore + "\t" +
                        user.subTimer + "\t" + user.multScore + "\t" + user.multTimer + "\t" + user.divScore +
                        "\t" + user.divTimer);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                    MethodInfo.GetCurrentMethod().Name + " ->" + ex.Message);
            }

        }

        /// <summary>
        /// Returns to main menu
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

    }
}
