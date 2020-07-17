using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
     * @class Lotto649
     */
    public class Lotto649 : LottoGame, IGenerateLottoNumbers
    {
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public Lotto649()
            : base(6, 49)
        {

        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {

            for (int i = 1; i < 7; i++) {
                this.PickElements();
                Console.Write($"Ticket   {i}: ");
                Console.WriteLine(this.ToString());
            }

        }
    }
}
