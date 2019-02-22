namespace Colors.Models
{
    /// <summary>
    /// Yellow Color
    /// </summary>
    public class Yellow : PrimaryColor
    {
        public Yellow()
        {
            Name = "YELLOW";
            Hex = "#f1c40f";
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
                case "RED": return new Orange();
                case "BLUE": return new Green();
                case "YELLOW": return new Yellow();
            }

            return null;
        }
    }
}