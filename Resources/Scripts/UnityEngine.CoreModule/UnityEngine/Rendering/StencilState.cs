using System;

namespace UnityEngine.Rendering
{
	public struct StencilState : IEquatable<StencilState>
	{
		private byte m_Enabled;

		private byte m_ReadMask;

		private byte m_WriteMask;

		private byte m_Padding;

		private byte m_CompareFunctionFront;

		private byte m_PassOperationFront;

		private byte m_FailOperationFront;

		private byte m_ZFailOperationFront;

		private byte m_CompareFunctionBack;

		private byte m_PassOperationBack;

		private byte m_FailOperationBack;

		private byte m_ZFailOperationBack;

		public bool enabled
		{
			set
			{
			}
		}

		public byte readMask
		{
			set
			{
			}
		}

		public byte writeMask
		{
			set
			{
			}
		}

		public CompareFunction compareFunctionFront
		{
			set
			{
			}
		}

		public StencilOp passOperationFront
		{
			set
			{
			}
		}

		public StencilOp failOperationFront
		{
			set
			{
			}
		}

		public StencilOp zFailOperationFront
		{
			set
			{
			}
		}

		public CompareFunction compareFunctionBack
		{
			set
			{
			}
		}

		public StencilOp passOperationBack
		{
			set
			{
			}
		}

		public StencilOp failOperationBack
		{
			set
			{
			}
		}

		public StencilOp zFailOperationBack
		{
			set
			{
			}
		}

		public bool Equals(StencilState other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
