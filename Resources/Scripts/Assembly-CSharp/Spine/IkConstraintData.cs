using System.Collections.Generic;

namespace Spine
{
	public class IkConstraintData
	{
		internal string name;

		internal List<BoneData> bones;

		internal BoneData target;

		internal int bendDirection;

		internal float mix;

		public string Name => null;

		public List<BoneData> Bones => null;

		public BoneData Target
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

		public IkConstraintData(string name)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
