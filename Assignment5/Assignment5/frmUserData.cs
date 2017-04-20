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
    public partial class frmUserData : Form
    {
        #region Attributes

        /// <summary>
        /// Container for clsUserObjectManager
        /// </summary>
        clsUserObjectManager clsMyUserObjectManager;

        #endregion

        #region Methods

        /// <summary>
        /// User Data form constructor
        /// </summary>
        /// <param name="UserObjectManager">UserObjectManager class passed in</param>
        public frmUserData(clsUserObjectManager UserObjectManager)
        {
            try
            {
                InitializeComponent();

                clsMyUserObjectManager = UserObjectManager;
                lblError.Text = "";
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Resets textbox values on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserData_Load(object sender, EventArgs e)
        {
            try
            {
                //Clear all inputs
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAge.Text = "";

                cboUser.DisplayMember = "DisplayText";
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// On click, checks that text is int, then passes to new user object in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                int iAge;

                if (Int32.TryParse(txtAge.Text, out iAge) && txtFirstName.Text != "")
                {
                    clsMyUserObjectManager.AddNewUser(txtFirstName.Text, txtLastName.Text, iAge);
                    cboUser.Items.Add(clsMyUserObjectManager.lstUsers[clsMyUserObjectManager.currentUser]);
                    this.Hide();
                }
                else
                {
                    lblError.Text = "Please enter your name and age.";
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Runs AddUserClick method if enter is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAge_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddUser_Click(this, new EventArgs());
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

        private void btnCombo_Click(object sender, EventArgs e)
        {
            try
            {
                clsMyUserObjectManager.currentUser = cboUser.SelectedIndex;

                this.Hide();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
    }

        #endregion

}
