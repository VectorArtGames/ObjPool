using ObjPool.Core.Vectors;

namespace ObjPool.Core.Objects
{
	public class GameObject
	{
		public Vector2 Position = Vector2.Zero;
		public bool Active { get; set; }

		public virtual bool InUse =>
			Active;
	}
}
