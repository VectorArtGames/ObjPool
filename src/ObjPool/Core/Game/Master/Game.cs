using ObjPool.Core.Game.Render;
using ObjPool.Core.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjPool.Core.Game.Master
{
	public class Game
	{
		public static GameRender Render { get; set; }
		public static void Initialize()
		{
			TM.SetTitle("Loading ..");
			var render = Render = 
				new GameRender(Console.BufferWidth, 
				Console.BufferHeight);
		}
	}
}
