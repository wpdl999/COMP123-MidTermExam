using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
    Author name : Wooram Moon
    Author's student number : 301098673
    Date last Modified : July 17th, 2020
    Program description : Lottery random numbers
    1st Revision : July 15th, 2020
    2nd Revision : July 16th, 2020
    3rd Revision : July 17th, 2020
 */

namespace COMP123_MidTermExam
{
    /**
    * <summary>
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            :base(7,49)
        {
            
        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {
            for (int i = 1; i < 7; i++)
            {
                this.PickElements();
                Console.Write($"Ticket   {i}: ");
                Console.WriteLine(this.ToString());
            }
        }
    }
}