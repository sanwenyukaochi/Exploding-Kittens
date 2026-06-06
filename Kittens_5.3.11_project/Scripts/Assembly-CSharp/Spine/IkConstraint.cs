using System;

namespace Spine
{
	public class IkConstraint
	{
		private const float radDeg = 180f / (float)Math.PI;

		internal IkConstraintData data;

		internal ExposedList<Bone> bones;

		internal Bone target;

		internal int bendDirection;

		internal float mix;

		public IkConstraintData Data => null;

		public ExposedList<Bone> Bones => null;

		public Bone Target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int BendDirection
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float Mix
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public IkConstraint(IkConstraintData data, Skeleton skeleton)
		{
		}

		public void apply()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static void apply(Bone bone, float targetX, float targetY, float alpha)
		{
		}

		public static void apply(Bone parent, Bone child, float targetX, float targetY, int bendDirection, float alpha)
		{
		}
	}
}
