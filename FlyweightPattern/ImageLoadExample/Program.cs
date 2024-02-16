using System;

namespace ImageLoadExample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// instantiate and render a web page
			var renderer = new WebPageRenderer ();
			renderer.Render ();
		}
	}
}
