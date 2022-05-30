namespace First;

/// <summary>
/// Can be used to calculate values.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Gets or sets the first input number.
    /// </summary>
    public int FirstNumber { get; set; }

    /// <summary>
    /// Gets or sets the second input number.
    /// </summary>
    public int SecondNumber { get; set; }

    /// <summary>
    /// Adds the two numbers.
    /// </summary>
    /// <returns>The sum of the two numbers.</returns>
    public int Add()
    {
        return FirstNumber + SecondNumber;
    }

    /// <summary>
    /// Subtracts the two numbers.
    /// </summary>
    /// <returns>The difference of the two numbers.</returns>
    public int Subtract()
    {
        return FirstNumber - SecondNumber;
    }
}
