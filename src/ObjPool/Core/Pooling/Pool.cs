using ObjPool.Core.Objects;
using System.Linq;

namespace ObjPool.Core.Pooling
{
	public class Pool
	{
		public const int POOL_SIZE = 100;
		public static GameObject[] PoolingObjects { get; }
		 = new GameObject[POOL_SIZE];

		public static GameObject Spawn()
		{
			var o = PoolingObjects.FirstOrDefault(x => !x.InUse);
			return o;
		}
	}
}
