namespace CMP1005_CreateWebAPILogic;

public static class CreateWebAPILogic
{
    /*
     * Method to Add two numbers
     * params: left: Double , right: Double
     * return: double
     */
    public static double Add(double left, double right)
    {
        return left + right;
    }

    /*
     * Method to Subtract two numbers
     * params: left: Double , right: Double
     * return: double
     */
    public static double Subract(double left, double right)
    {
        return left - right;
    }

    /*
     * Method to Multiply two numbers
     * params: left: Double , right: Double
     * return: double
     */
    public static double Multiply(double left, double right)
    {
        return left * right;
    }

    /*
     * Method to Divide two numbers
     * params: left: Double , right: Double
     * return: double
     */
    public static double Divide(double left, double right)
    {
        try
        {
            return left / right;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Exception caught: {0}", e);
        }
        finally
        {
            Console.WriteLine("Result: {0}", 0);
        }
        return 0;
    }
}

