namespace Colors.Models
{
    /// <summary>
    /// Red Color
    /// </summary>
    public class Red : PrimaryColor
    {
        public Red()
        {
            Name = "RED";
            Hex = "#e74c3c";
        }

        /// <summary>
        /// Add another Color to this one.
        /// </summary>
        /// <param name="addition">Color to add to this one</param>
        /// <returns>New Color that is a combination of this color and the provided one</returns>
        public override IColor Add(IColor addition)
        {
            switch (addition.Name)
            {
                case "RED": return new Red();
                case "BLUE": return new Purple();
                case "YELLOW": return new Orange();
            }

            return null;
        }
    }
}