﻿using System.IO;

#if !XENKO
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#else
using Xenko.Core.Mathematics;
using Xenko.Graphics;
using ITexture = Xenko.Graphics.Texture;
#endif

namespace Myra.Utility
{
	internal static class CrossEngineStuff
	{
		public static ITexture CreateITexture(int width, int height)
		{
#if !XENKO
			return new ITexture(MyraEnvironment.GraphicsDevice, width, height, false, SurfaceFormat.Color);
#else
			return ITexture.New2D(MyraEnvironment.GraphicsDevice, width, height, false, PixelFormat.R8G8B8A8_UNorm, TextureFlags.ShaderResource);
#endif
		}

		public static void SetData<T>(ITexture texture, T[] data) where T: struct
		{
#if !XENKO
			texture.SetData(data);
#else
			var commandList = MyraEnvironment.Game.GraphicsContext.CommandList;

			texture.SetData(commandList, data);
#endif
		}

		public static int LineSpacing(SpriteFont font)
		{
#if !XENKO
			return font.LineSpacing;
#else
			return (int)font.Size;
#endif
		}

		public static Rectangle GetScissor()
		{
#if !XENKO
			var rect = MyraEnvironment.GraphicsDevice.ScissorRectangle;

			rect.X -= MyraEnvironment.GraphicsDevice.Viewport.X;
			rect.Y -= MyraEnvironment.GraphicsDevice.Viewport.Y;

			return rect;
#else
			return MyraEnvironment.Game.GraphicsContext.CommandList.Scissor;
#endif
		}

		public static void SetScissor(Rectangle rect)
		{
#if !XENKO
			rect.X += MyraEnvironment.GraphicsDevice.Viewport.X;
			rect.Y += MyraEnvironment.GraphicsDevice.Viewport.Y;
			MyraEnvironment.GraphicsDevice.ScissorRectangle = rect;
#else
			MyraEnvironment.Game.GraphicsContext.CommandList.SetScissorRectangle(rect);
#endif
		}

		public static Point ViewSize(this GraphicsDevice device)
		{
#if !XENKO
			return new Point(device.Viewport.Width, device.Viewport.Height);
#else
			return new Point(device.Presenter.BackBuffer.Width, device.Presenter.BackBuffer.Height);
#endif
		}
	}
}
