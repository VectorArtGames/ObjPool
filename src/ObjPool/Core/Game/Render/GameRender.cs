using ObjPool.Core.Managers;
using System;
using static System.Console;
using static System.ConsoleColor;

namespace ObjPool.Core.Game.Render
{
	public class GameRender
	{
		public int SizeX { get; set; }
		public int SizeY { get; set; }
		public GameRender(int sizeX, int sizeY)
		{
			TM.SetTitle("Loading ..");
			SizeX = sizeX;
			SizeY = sizeY;
			Render();
		}

		public void Render()
		{
			BackgroundColor = Yellow;
			Write(' ');
		}
	}
}
