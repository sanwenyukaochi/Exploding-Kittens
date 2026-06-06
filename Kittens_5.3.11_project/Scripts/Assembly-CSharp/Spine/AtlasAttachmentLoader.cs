namespace Spine
{
	public class AtlasAttachmentLoader : AttachmentLoader
	{
		private Atlas[] atlasArray;

		public AtlasAttachmentLoader(params Atlas[] atlasArray)
		{
		}

		public RegionAttachment NewRegionAttachment(Skin skin, string name, string path)
		{
			return null;
		}

		public MeshAttachment NewMeshAttachment(Skin skin, string name, string path)
		{
			return null;
		}

		public SkinnedMeshAttachment NewSkinnedMeshAttachment(Skin skin, string name, string path)
		{
			return null;
		}

		public BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name)
		{
			return null;
		}

		public AtlasRegion FindRegion(string name)
		{
			return null;
		}
	}
}
