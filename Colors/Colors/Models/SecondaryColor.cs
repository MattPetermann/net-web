namespace Colors.Models
{
    /// <summary>
    /// Parent class to all secondary colors.
    /// These colors can be displayed only.
    /// </summary>
    public class SecondaryColor : IColor
    {
        public string Name { get; set; }
        public string Hex { get; set; }
    }
}