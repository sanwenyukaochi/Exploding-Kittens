using System.Collections.Generic;
using System.IO;

namespace Spine
{
	public class SkeletonJson
	{
		private AttachmentLoader attachmentLoader;

		public float Scale { get; set; }

		public SkeletonJson(params Atlas[] atlasArray)
		{
		}

		public SkeletonJson(AttachmentLoader attachmentLoader)
		{
		}

		public SkeletonData ReadSkeletonData(string path)
		{
			return null;
		}

		public SkeletonData ReadSkeletonData(TextReader reader)
		{
			return null;
		}

		private Attachment ReadAttachment(Skin skin, string name, Dictionary<string, object> map)
		{
			return null;
		}

		private float[] GetFloatArray(Dictionary<string, object> map, string name, float scale)
		{
			return null;
		}

		private int[] GetIntArray(Dictionary<string, object> map, string name)
		{
			return null;
		}

		private float GetFloat(Dictionary<string, object> map, string name, float defaultValue)
		{
			return 0f;
		}

		private int GetInt(Dictionary<string, object> map, string name, int defaultValue)
		{
			return 0;
		}

		private bool GetBoolean(Dictionary<string, object> map, string name, bool defaultValue)
		{
			return false;
		}

		private string GetString(Dictionary<string, object> map, string name, string defaultValue)
		{
			return null;
		}

		private float ToColor(string hexString, int colorIndex)
		{
			return 0f;
		}

		private void ReadAnimation(string name, Dictionary<string, object> map, SkeletonData skeletonData)
		{
		}

		private void ReadCurve(CurveTimeline timeline, int frameIndex, Dictionary<string, object> valueMap)
		{
		}
	}
}
