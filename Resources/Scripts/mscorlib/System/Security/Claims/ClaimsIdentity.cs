using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Principal;

namespace System.Security.Claims
{
	[Serializable]
	[ComVisible(true)]
	public class ClaimsIdentity : IIdentity
	{
		[CompilerGenerated]
		private sealed class _003Cget_Claims_003Ed__51 : IEnumerable<Claim>, IEnumerable, IEnumerator<Claim>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private Claim _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public ClaimsIdentity _003C_003E4__this;

			private int _003Ci_003E5__2;

			private IEnumerator<Claim> _003C_003E7__wrap2;

			Claim IEnumerator<Claim>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_Claims_003Ed__51(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<Claim> IEnumerable<Claim>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[NonSerialized]
		private byte[] m_userSerializationData;

		[NonSerialized]
		private List<Claim> m_instanceClaims;

		[NonSerialized]
		private Collection<IEnumerable<Claim>> m_externalClaims;

		[NonSerialized]
		private string m_nameType;

		[NonSerialized]
		private string m_roleType;

		[OptionalField(VersionAdded = 2)]
		private string m_version;

		[OptionalField(VersionAdded = 2)]
		private ClaimsIdentity m_actor;

		[OptionalField(VersionAdded = 2)]
		private string m_authenticationType;

		[OptionalField(VersionAdded = 2)]
		private object m_bootstrapContext;

		[OptionalField(VersionAdded = 2)]
		private string m_label;

		[OptionalField(VersionAdded = 2)]
		private string m_serializedNameType;

		[OptionalField(VersionAdded = 2)]
		private string m_serializedRoleType;

		[OptionalField(VersionAdded = 2)]
		private string m_serializedClaims;

		public virtual string AuthenticationType => null;

		public ClaimsIdentity Actor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual IEnumerable<Claim> Claims
		{
			[IteratorStateMachine(typeof(_003Cget_Claims_003Ed__51))]
			get
			{
				return null;
			}
		}

		public virtual string Name => null;

		public ClaimsIdentity()
		{
		}

		public ClaimsIdentity(IEnumerable<Claim> claims)
		{
		}

		public ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType)
		{
		}

		internal ClaimsIdentity(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType)
		{
		}

		protected ClaimsIdentity(SerializationInfo info, StreamingContext context)
		{
		}

		public virtual ClaimsIdentity Clone()
		{
			return null;
		}

		private void SafeAddClaims(IEnumerable<Claim> claims)
		{
		}

		private void SafeAddClaim(Claim claim)
		{
		}

		public virtual Claim FindFirst(string type)
		{
			return null;
		}

		[OnSerializing]
		private void OnSerializingMethod(StreamingContext context)
		{
		}

		[OnDeserialized]
		private void OnDeserializedMethod(StreamingContext context)
		{
		}

		[OnDeserializing]
		private void OnDeserializingMethod(StreamingContext context)
		{
		}

		protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		private void DeserializeClaims(string serializedClaims)
		{
		}

		private string SerializeClaims()
		{
			return null;
		}

		private bool IsCircular(ClaimsIdentity subject)
		{
			return false;
		}

		private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext)
		{
		}
	}
}
