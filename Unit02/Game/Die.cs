using System;



namespace Unit02.Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.
    // need attributes calle points and value. 
    public class Die
    {
        /// <summary>
        /// A small cube with a different number of spots on each of its six sides.
        /// 
        /// The responsibility of Die is to keep track of its currently rolled value and the points its
        /// worth.
        /// </summary> 
        public int points;
        public int value;


    // 2) Create the class constructor. Use the following method comment.
        public Die()
        {
        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        
        }
    // 3) Create the Roll() method. Use the following method comment.
        public void Roll()
        {
        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>
        /* Roll needs to call .rand for values 1-6, then an if statement for the values. 
        */
        Random random = new Random();
        value = random.Next(1, 7); //for ints
        if (value == 5)
        {
            points = 50;
        }
        else if (value == 1)
        {
            points = 100;
        }
        else
        {
            points = 0;
        }
        }
    }       
}