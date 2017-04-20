using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Assignment5
{
    public class clsUserObjectManager
    {

        #region Attributes
        
        /// <summary>
        /// Create a list of clsUsers 
        /// </summary>
        public List<clsUser> lstUsers { get; set; }

        /// <summary>
        /// The number of the current user
        /// </summary>
        public int currentUser = -1;

        #endregion

        #region Methods

        /// <summary>
        /// Constructor
        /// </summary>
        public clsUserObjectManager()
        {
            try
            {
                lstUsers = new List<clsUser>();
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                    MethodInfo.GetCurrentMethod().Name + " ->" + ex.Message);
            }
        }

        /// <summary>
        /// Adds new user to the list
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        public void AddNewUser(string firstName, string lastName, int age)
        {
            try
            {
                lstUsers.Add(new Assignment5.clsUser { userFirstName = firstName, userLastName = lastName, userAge = age });
                currentUser++;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                    MethodInfo.GetCurrentMethod().Name + " ->" + ex.Message);
            }
        }

        #endregion
    }
}
