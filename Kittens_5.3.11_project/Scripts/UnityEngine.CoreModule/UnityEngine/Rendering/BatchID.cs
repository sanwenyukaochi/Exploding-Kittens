using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeClass("BatchID")]
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	public struct BatchID : IEquatable<BatchID>
	{
		public static readonly BatchID Null;

		public uint value;

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(BatchID other)
		{
			return false;
		}
	}
}
