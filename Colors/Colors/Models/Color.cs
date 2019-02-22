namespace Colors.Models
{
    /// <summary>
    /// Base interface for all Color objects.
    /// Defines Name and Hex value requirements.
    /// </summary>
    public interface IColor
    {
        string Name { get; set; }
        string Hex { get; set; }
    }
}