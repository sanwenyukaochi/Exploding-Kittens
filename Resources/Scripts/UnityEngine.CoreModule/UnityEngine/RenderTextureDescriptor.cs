using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine
{
	public struct RenderTextureDescriptor
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _003CmipCount_003Ek__BackingField;

		private GraphicsFormat _graphicsFormat;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private GraphicsFormat _003CstencilFormat_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ShadowSamplingMode _003CshadowSamplingMode_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private VRTextureUsage _003CvrUsage_003Ek__BackingField;

		private RenderTextureCreationFlags _flags;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private RenderTextureMemoryless _003Cmemoryless_003Ek__BackingField;

		public int width { get; set; }

		public int height { get; set; }

		public int msaaSamples { get; set; }

		public int volumeDepth { get; set; }

		public int mipCount
		{
			[CompilerGenerated]
			set
			{
				_003CmipCount_003Ek__BackingField = value;
			}
		}

		public GraphicsFormat graphicsFormat
		{
			get
			{
				return default(GraphicsFormat);
			}
			set
			{
			}
		}

		public GraphicsFormat depthStencilFormat { get; set; }

		public int depthBufferBits
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public TextureDimension dimension { get; set; }

		public ShadowSamplingMode shadowSamplingMode
		{
			[CompilerGenerated]
			set
			{
				_003CshadowSamplingMode_003Ek__BackingField = value;
			}
		}

		public VRTextureUsage vrUsage
		{
			[CompilerGenerated]
			set
			{
				_003CvrUsage_003Ek__BackingField = value;
			}
		}

		public RenderTextureMemoryless memoryless
		{
			[CompilerGenerated]
			set
			{
				_003Cmemoryless_003Ek__BackingField = value;
			}
		}

		internal bool createdFromScript
		{
			set
			{
			}
		}

		public bool useDynamicScale
		{
			set
			{
			}
		}

		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
		{
			this.width = 0;
			this.height = 0;
			msaaSamples = 0;
			volumeDepth = 0;
			_003CmipCount_003Ek__BackingField = 0;
			_graphicsFormat = default(GraphicsFormat);
			_003CstencilFormat_003Ek__BackingField = default(GraphicsFormat);
			this.depthStencilFormat = default(GraphicsFormat);
			dimension = default(TextureDimension);
			_003CshadowSamplingMode_003Ek__BackingField = default(ShadowSamplingMode);
			_003CvrUsage_003Ek__BackingField = default(VRTextureUsage);
			_flags = default(RenderTextureCreationFlags);
			_003Cmemoryless_003Ek__BackingField = default(RenderTextureMemoryless);
		}

		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
		{
			this.width = 0;
			this.height = 0;
			msaaSamples = 0;
			volumeDepth = 0;
			this._003CmipCount_003Ek__BackingField = 0;
			_graphicsFormat = default(GraphicsFormat);
			_003CstencilFormat_003Ek__BackingField = default(GraphicsFormat);
			this.depthStencilFormat = default(GraphicsFormat);
			dimension = default(TextureDimension);
			_003CshadowSamplingMode_003Ek__BackingField = default(ShadowSamplingMode);
			_003CvrUsage_003Ek__BackingField = default(VRTextureUsage);
			_flags = default(RenderTextureCreationFlags);
			_003Cmemoryless_003Ek__BackingField = default(RenderTextureMemoryless);
		}

		private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag)
		{
		}
	}
}
