using System.Drawing;

namespace CollisionDetector
{
    /// <summary>
    /// The structure we use for representing objects in game
    /// </summary>
    public class Hex
    {
        /// <summary>
        /// X and Y coordinates in the game system
        /// </summary>
        public PointF Center { get; set; }

        /// <summary>
        /// The size of the object represented in dimension-free coordinate units
        /// </summary>
        public float Radius { get; set; }

        /// <summary>
        /// Constructor for Hex object
        /// </summary>
        /// <param name="center">The x and y coords of the object</param>
        /// <param name="radius">The size of the object</param>
        private Hex(PointF center, float radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        /// <summary>
        /// Static factory method to create hex
        /// </summary>
        /// <param name="center">The x and y coords of the object</param>
        /// <param name="radius">The size of the object</param>
        /// <returns></returns>
        public static Hex CreateHex(PointF center, float radius)
        {
            return new Hex(center, radius);
        }
    }
}