namespace Colors.Models
{
    /// <summary>
    /// Blue Color
    /// </summary>
    public class Blue : PrimaryColor
    {
        public Blue()
        {
            Name = "BLUE";
            Hex = "#3498db";
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
                case "RED": return new Purple();
                case "BLUE": return new Blue();
                case "YELLOW": return new Green();
            }

            return null;
        }
    }
}