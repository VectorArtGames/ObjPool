using ObjPool.Core.Game.Master;
using System.Threading;
using System.Threading.Tasks;

namespace ObjPool
{
	class Program
	{
		static void Main(string[] args)
		{
			Task.Run(Game.Initialize);
			Thread.Sleep(-1);
		}
	}
}
