using System;

namespace HutongGames.PlayMaker.Actions
{
	[Obsolete("Built-in support for Substance Designer materials has been deprecated and will be removed in Unity 2018.1. To continue using Substance Designer materials in Unity 2018.1, you will need to install a suitable third-party external importer from the Asset Store.")]
	[Tooltip("Set a named bool property in a Substance material. NOTE: Use Rebuild Textures after setting Substance properties.")]
	[ActionCategory("Substance")]
	public class SetProceduralBoolean : FsmStateAction
	{
		[Tooltip("The Substance Material.")]
		[RequiredField]
		public FsmMaterial substanceMaterial;

		[Tooltip("The named bool property in the material.")]
		[RequiredField]
		public FsmString boolProperty;

		[Tooltip("The value to set the property to.")]
		[RequiredField]
		public FsmBool boolValue;

		[Tooltip("NOTE: Updating procedural materials every frame can be very slow!")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetProceduralFloat()
		{
		}
	}
}
