public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Step 1: Create an array of the given length
        double[] result = new double[length];

        // Step 2: Loop through the array to populate it with multiples of the number
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1); // (i + 1) ensures starting from the first multiple
        }
        
        return result; // return the populated array
    }

        //return []; // replace this return statement with your own
    

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {

        // Step 1: Handle edge case if list is empty or only one element
        if (data.Count <= 1)
            return;

        // Step 2: Ensure amount is within valid range using modulo
        amount = amount % data.Count;

        // Step 3: Split the list into two parts: last 'amount' elements and the rest
        List<int> part1 = data.GetRange(data.Count - amount, amount);  // Last 'amount' elements
        List<int> part2 = data.GetRange(0, data.Count - amount);        // Remaining elements

        // Step 4: Modify original list by clearing it and adding rotated parts
        data.Clear();
        data.AddRange(part1);
        data.AddRange(part2);
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
