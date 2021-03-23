using System;

namespace calcLib
{
    internal class Calculation
    {
        internal int square(int num1)
        {
            int result = 0;
            try
            {
                result = num1 * num1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error", ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the program");
            }
            return result; 
        }

        internal int cube(int num1)
        {
            int result = 0;
            try
            {
                result = num1 * num1 *num1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error", ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the program");
            }
            return result;
        }
        internal int squareroot(int num1)
        {
            int result = 0;
            try
            {
                result = (int)Math.Sqrt(num1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error", ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the program");
            }
            return result;
        }

        
        }
    }
}