public class Fraction
{
    // 1. Private fields (Attributes from the diagram)
    private int _top;
    private int _bottom;

    // 2. Constructors
    
    // Default constructor: defaults to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor for a whole number (e.g., 5 becomes 5/1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor for both top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        
        // Validation: prevent division by zero
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            _bottom = 1; // Fallback default
        }
    }

    // 3. Explicit Getters and Setters

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            Console.WriteLine("Error: Bottom number cannot be zero.");
        }
    }

    // 4. Representation Methods

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        // Cast to double to ensure precise decimal calculation
        return (double)_top / _bottom;
    }
}