using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Constructor
{
    /// <summary>
    /// Describes a class
    /// </summary>

    public class Constructor
    {
        #region Fields 
        int lengthOfClass;//length
        public int Count { get; set; }

        public int Length
        {
            get
            {
                return lengthOfClass;
            }

            set
            {
                lengthOfClass = value;
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// dadf
        /// </summary>
        /// <param name="lengthOfClass">asdf</param>
        /// <param name="name">asdf</param>
        public int CallingMethod(int lengthOfClass,
                                     int a,
                                     int b,
                                     string asdf,

                                     string name = "bhagatr")
        {
            int count = 0;
            string fname = string.Empty;
            try
            {
                if (asdf == null)
                {
                    return count;
                }
                asdf.Contains("as");

                int y = 4 / count;
                fname = "bhagar";
                fname = fname.Substring(2);

                StringBuilder mess = new StringBuilder(string.Empty);
                //"This class length is of 789 characat. sos"
                mess.ToString();

                for (int i = fname.Length-1; i >= 0; i--)
                {
                    if (i == 2)
                    {
                        continue;
                    }
                }
                IEnumerable<string> names = new List<string> { "c", "b","asdf"};
                foreach (var item in names)
                {
                    
                }
               
                
                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return count;
        }

        public void Factorial(params int[] numbers)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Private Methods
        private int Test2(int a) {
            return 9;
        }
    }
        #endregion
    }


}
