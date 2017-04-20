using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Assignment5
{
    public class clsUser
    {
        #region Attributes

        /// <summary>
        /// String to hold player's first name
        /// </summary>
        public String userFirstName { get; set; } = "";

        /// <summary>
        /// String to hold player's last name
        /// </summary>
        public String userLastName { get; set; } = "";

        /// <summary>
        /// int to hold player's age
        /// </summary>
        public int userAge { get; set; } = 0;

        /// <summary>
        /// High Score for addition game
        /// </summary>
        public int addScore { get; set; } = 0;

        /// <summary>
        /// Best time for addition game
        /// </summary>
        public int addTimer { get; set; } = 0;

        /// <summary>
        /// High Score for subtraction game
        /// </summary>
        public int subScore { get; set; } = 0;

        /// <summary>
        /// Best time for subtraction game
        /// </summary>
        public int subTimer { get; set; } = 0;

        /// <summary>
        /// High Score for division game
        /// </summary>
        public int divScore { get; set; } = 0;

        /// <summary>
        /// Best time for division game
        /// </summary>
        public int divTimer { get; set; } = 0;

        /// <summary>
        /// High Score for multiplication game
        /// </summary>
        public int multScore { get; set; } = 0;

        /// <summary>
        /// Best time for multiplication game
        /// </summary>
        public int multTimer { get; set; } = 0;

        #endregion

        #region Methods
        public string DisplayText
        {
            get
            {
                try
                {
                    return userFirstName + " " + userLastName;
                }
                catch (Exception ex)
                {
                    throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                        MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Override ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            try
            {
                return userFirstName + " " + userLastName;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        #endregion
    }
}
