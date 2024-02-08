namespace CollisionDetector
{
    /// <summary>
    /// Static class wrapper for collision logic
    /// </summary>
    public static class Detector
    {
        /// <summary>
        /// Returns a true if the hexes overlap, false if not
        /// </summary>
        /// <param name="hex1">The first hex to compare</param>
        /// <param name="hex2">The second hex to compare</param>
        /// <returns>True if colliding, false if not</returns>
        public static bool DetectionCollision(Hex hex1, Hex hex2)
        {
            var distance = Math.Sqrt(Math.Pow(hex2.Center.X - hex1.Center.X, 2) + Math.Pow(hex2.Center.Y - hex1.Center.Y, 2));

            var sumOfRadii = hex1.Radius + hex2.Radius;

            return distance <= sumOfRadii;
        }
    }
}
