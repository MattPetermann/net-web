namespace Colors.Models
{
    /// <summary>
    /// Parent class to all primary colors.
    /// These colors can be added to other colors.
    /// </summary>
    public abstract class PrimaryColor : IColor
    {
        public string Name { get; set; }
        public string Hex { get; set; }

        public abstract IColor Add(IColor addition);
    }
}