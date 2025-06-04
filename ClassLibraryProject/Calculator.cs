namespace ClassLibraryProject
{
    #region Calculator
    public class Calculator
    {
        /// <summary>
        /// Return addition of Two Numbers :  number1 + number2
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int AddTwoNumber(int number1, int number2)
        {
            return number1 + number2;
        }

        /// <summary>
        /// Substract TwoNumber
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int SubstractTwoNumber(int number1, int number2)
        {
            return number1 - number2;
        }

        /// <summary>
        /// Multiply TwoNumber
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int MultiplyTwoNumber(int number1, int number2)
        {
            return number1 * number2;
        }
    }
    #endregion
}
