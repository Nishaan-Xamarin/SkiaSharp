﻿using System;
using Android.Content;
using Android.Opengl;
using Xamarin.Forms;

using SKFormsView = SkiaSharp.Views.Forms.SKGLView;
using SKNativeView = SkiaSharp.Views.Android.SKGLSurfaceView;

[assembly: ExportRenderer(typeof(SKFormsView), typeof(SkiaSharp.Views.Forms.SKGLViewRenderer))]

namespace SkiaSharp.Views.Forms
{
	public class SKGLViewRenderer : SKGLViewRendererBase<SKFormsView, SKNativeView>
	{
		public SKGLViewRenderer(Context context)
			: base(context)
		{
		}

		[Obsolete("This constructor is obsolete as of version 2.5. Please use SKGLViewRenderer(Context) instead.")]
		public SKGLViewRenderer()
			: base()
		{
		}

		protected override void SetupRenderLoop(bool oneShot)
		{
			if (oneShot)
			{
				Control.RequestRender();
			}

			Control.RenderMode = Element.HasRenderLoop
				? Rendermode.Continuously
				: Rendermode.WhenDirty;
		}
	}
}
