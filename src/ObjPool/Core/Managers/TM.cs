using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjPool.Core.Managers
{
	/// <summary>
	/// Title Manager
	/// </summary>
	public class TM
	{
		/// <summary>
		/// Set Title of Window
		/// </summary>
		/// <param name="title">Title of Window</param>
		public static void SetTitle(string title)
		{
			Console.Title = $"{title} - ObjPool";
		}
	}
}
