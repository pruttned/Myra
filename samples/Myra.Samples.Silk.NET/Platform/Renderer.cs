﻿using System;
using System.Drawing;
using System.Numerics;
using FontStashSharp;
using FontStashSharp.Interfaces;
using Myra.Graphics2D;
using Myra.Platform;
using Silk.NET.OpenGL;

namespace Myra.Samples.AllWidgets
{
	internal class Renderer: IMyraRenderer
	{
		private bool _beginCalled;
		
		private readonly Texture2DManager _textureManager = new Texture2DManager();
		private readonly QuadBatch _batch = new QuadBatch();

		private TextureFiltering _filtering;

		private Rectangle _scissor;

		public RendererType RendererType => RendererType.Quad;

		public ITexture2DManager TextureManager => _textureManager;

		public Rectangle Viewport
		{
			get => _batch.Viewport;
			set
			{
				_batch.Viewport = value;
				Env.Gl.Viewport(value.X, value.Y, (uint)value.Width, (uint)value.Height);
			}
		}

		public Rectangle Scissor
		{
			get
			{
				return _scissor;
			}

			set
			{
				Flush();

				value.X += Viewport.X;
				value.Y += Viewport.Y;

				// TripplyGL Scissor Rect has y-axis facing upwards
				// Hence we require some transforms
				var result = new Rectangle(value.X, Viewport.Height - value.Height - value.Y, value.Width, value.Height);
				Env.Gl.Scissor(result.X, result.Y, (uint)result.Width, (uint)result.Height);

				_scissor = value;
			}
		}

		public void Begin(TextureFiltering textureFiltering)
		{
			Env.Gl.Enable(EnableCap.ScissorTest);
			GLUtility.CheckError();

			_batch.Begin();

			_beginCalled = true;
			_filtering = textureFiltering;
		}

		public void End()
		{
			_batch.End();
			_beginCalled = false;

			Env.Gl.Disable(EnableCap.ScissorTest);
			GLUtility.CheckError();
		}

		public void DrawQuad(object texture, ref VertexPositionColorTexture topLeft, ref VertexPositionColorTexture topRight, ref VertexPositionColorTexture bottomLeft, ref VertexPositionColorTexture bottomRight)
		{
			_batch.DrawQuad(texture, ref topLeft, ref topRight, ref bottomLeft, ref bottomRight);
		}

		public void DrawSprite(object texture, Vector2 pos, Rectangle? src, FSColor color, float rotation, Vector2 scale, float depth)
		{
			throw new NotImplementedException();
		}

		private void Flush()
		{
			if (_beginCalled)
			{
				End();
				Begin(_filtering);
			}
		}
	}
}
