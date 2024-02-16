using System;
using System.Collections;

namespace ImageLoadExample
{
	/// <summary>
	/// The flyweight abstract class.
	/// </summary>
	abstract class BaseImage
	{
		/// <summary>
		/// Display the image.
		/// </summary>
		/// <param name="x">The x-coordinate of the position of the image.</param>
		/// <param name="y">The y-coordinate of the position of the image.</param>
		/// <param name="width">The width of the image.</param>
		/// <param name="height">The height of the image.</param>
		public abstract void Display(int x, int y, int width, int height);
	}
	
}
