using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[UsedByNativeCode]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	public sealed class ParticleSystem : Component
	{
		public struct MainModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool loop => false;

			public MinMaxGradient startColor
			{
				[NativeThrows]
				set
				{
				}
			}

			internal MainModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			[SpecialName]
			private static bool get_loop_Injected(ref MainModule _unity_self)
			{
				return false;
			}

			[SpecialName]
			private static void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value)
			{
			}
		}

		public struct EmissionModule
		{
			internal ParticleSystem m_ParticleSystem;

			public bool enabled
			{
				[NativeThrows]
				set
				{
				}
			}

			internal EmissionModule(ParticleSystem particleSystem)
			{
				m_ParticleSystem = null;
			}

			[SpecialName]
			private static void set_enabled_Injected(ref EmissionModule _unity_self, bool value)
			{
			}
		}

		[RequiredByNativeCode("particleSystemParticle", Optional = true)]
		public struct Particle
		{
			private Vector3 m_Position;

			private Vector3 m_Velocity;

			private Vector3 m_AnimatedVelocity;

			private Vector3 m_InitialVelocity;

			private Vector3 m_AxisOfRotation;

			private Vector3 m_Rotation;

			private Vector3 m_AngularVelocity;

			private Vector3 m_StartSize;

			private Color32 m_StartColor;

			private uint m_RandomSeed;

			private uint m_ParentRandomSeed;

			private float m_Lifetime;

			private float m_StartLifetime;

			private int m_MeshIndex;

			private float m_EmitAccumulator0;

			private float m_EmitAccumulator1;

			private uint m_Flags;

			[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", false)]
			public float lifetime
			{
				set
				{
				}
			}

			public Vector3 position
			{
				set
				{
				}
			}

			public Vector3 velocity
			{
				set
				{
				}
			}

			public float remainingLifetime
			{
				set
				{
				}
			}

			public float startLifetime
			{
				set
				{
				}
			}

			public Color32 startColor
			{
				set
				{
				}
			}

			public uint randomSeed
			{
				set
				{
				}
			}

			public float startSize
			{
				set
				{
				}
			}

			public Vector3 rotation3D
			{
				set
				{
				}
			}

			public Vector3 angularVelocity3D
			{
				set
				{
				}
			}
		}

		[Serializable]
		[NativeType(CodegenOptions.Custom, "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		public struct MinMaxGradient
		{
			[SerializeField]
			private ParticleSystemGradientMode m_Mode;

			[SerializeField]
			private Gradient m_GradientMin;

			[SerializeField]
			private Gradient m_GradientMax;

			[SerializeField]
			private Color m_ColorMin;

			[SerializeField]
			private Color m_ColorMax;

			public MinMaxGradient(Color color)
			{
				m_Mode = default(ParticleSystemGradientMode);
				m_GradientMin = null;
				m_GradientMax = null;
				m_ColorMin = default(Color);
				m_ColorMax = default(Color);
			}

			public static implicit operator MinMaxGradient(Color color)
			{
				return default(MinMaxGradient);
			}
		}

		public struct EmitParams
		{
			[NativeName("particle")]
			private Particle m_Particle;

			[NativeName("positionSet")]
			private bool m_PositionSet;

			[NativeName("velocitySet")]
			private bool m_VelocitySet;

			[NativeName("axisOfRotationSet")]
			private bool m_AxisOfRotationSet;

			[NativeName("rotationSet")]
			private bool m_RotationSet;

			[NativeName("rotationalSpeedSet")]
			private bool m_AngularVelocitySet;

			[NativeName("startSizeSet")]
			private bool m_StartSizeSet;

			[NativeName("startColorSet")]
			private bool m_StartColorSet;

			[NativeName("randomSeedSet")]
			private bool m_RandomSeedSet;

			[NativeName("startLifetimeSet")]
			private bool m_StartLifetimeSet;

			[NativeName("meshIndexSet")]
			private bool m_MeshIndexSet;

			[NativeName("applyShapeToPosition")]
			private bool m_ApplyShapeToPosition;
		}

		[Obsolete("loop property is deprecated. Use main.loop instead.", false)]
		public bool loop => false;

		[Obsolete("enableEmission property is deprecated. Use emission.enabled instead.", false)]
		public bool enableEmission
		{
			set
			{
			}
		}

		[Obsolete("startColor property is deprecated. Use main.startColor instead.", false)]
		public Color startColor
		{
			set
			{
			}
		}

		public MainModule main => default(MainModule);

		public EmissionModule emission => default(EmissionModule);

		[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color)
		{
		}

		[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(Particle particle)
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = true)]
		public void Play([DefaultValue("true")] bool withChildren)
		{
		}

		public void Play()
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = true)]
		public void Stop([DefaultValue("true")] bool withChildren, [DefaultValue("ParticleSystemStopBehavior.StopEmitting")] ParticleSystemStopBehavior stopBehavior)
		{
		}

		public void Stop([DefaultValue("true")] bool withChildren)
		{
		}

		public void Stop()
		{
		}

		[FreeFunction(Name = "ParticleSystemScriptBindings::IsAlive", HasExplicitThis = true)]
		public bool IsAlive([DefaultValue("true")] bool withChildren)
		{
			return false;
		}

		[RequiredByNativeCode]
		public void Emit(int count)
		{
		}

		[NativeName("SyncJobs()->Emit")]
		private void Emit_Internal(int count)
		{
		}

		[NativeName("SyncJobs()->EmitParticlesExternal")]
		public void Emit(EmitParams emitParams, int count)
		{
		}

		[NativeName("SyncJobs()->EmitParticleExternal")]
		private void EmitOld_Internal(ref Particle particle)
		{
		}

		private void Emit_Injected(ref EmitParams emitParams, int count)
		{
		}
	}
}
