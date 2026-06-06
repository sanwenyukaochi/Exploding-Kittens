using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmOwnerDefault
	{
		[SerializeField]
		private OwnerDefaultOption ownerOption;

		[SerializeField]
		private FsmGameObject gameObject;

		public OwnerDefaultOption OwnerOption
		{
			get
			{
				return default(OwnerDefaultOption);
			}
			set
			{
			}
		}

		public FsmGameObject GameObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmOwnerDefault()
		{
		}

		public FsmOwnerDefault(FsmOwnerDefault source)
		{
		}
	}
}
