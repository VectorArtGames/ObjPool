namespace ObjPool.Core.Vectors
{
	/// <summary>
	/// Vector2 class - 2D Coordinate(s)
	/// </summary>
	public class Vector2
	{

		#region Properties

		/// <summary>
		/// X Coordinate
		/// </summary>
		public int X { get; set; }

		/// <summary>
		/// Y Coordinate
		/// </summary>
		public int Y { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		/// Vector2 - (x, y)
		/// </summary>
		/// <param name="x">X Coordinate</param>
		/// <param name="y">Y Coordinate</param>
		public Vector2(int x, int y) => 
			(X, Y) = (x, y);

		public Vector2() { }

		#endregion

		#region Operators

		public static Vector2 operator +(Vector2 l, Vector2 r) =>
			new Vector2(l.X + r.X, l.Y + r.Y);

		#endregion

		#region Variables

		public static Vector2 Zero = new Vector2(0, 0);

		#endregion
	}
}
