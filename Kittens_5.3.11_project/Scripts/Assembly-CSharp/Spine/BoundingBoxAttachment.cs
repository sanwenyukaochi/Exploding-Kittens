namespace Spine
{
	public class BoundingBoxAttachment : Attachment
	{
		internal float[] vertices;

		public float[] Vertices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BoundingBoxAttachment(string name)
			: base(null)
		{
		}

		public void ComputeWorldVertices(Bone bone, float[] worldVertices)
		{
		}
	}
}
