using System.IO;

namespace Spine
{
	public class SkeletonBinary
	{
		public const int TIMELINE_SCALE = 0;

		public const int TIMELINE_ROTATE = 1;

		public const int TIMELINE_TRANSLATE = 2;

		public const int TIMELINE_ATTACHMENT = 3;

		public const int TIMELINE_COLOR = 4;

		public const int TIMELINE_FLIPX = 5;

		public const int TIMELINE_FLIPY = 6;

		public const int CURVE_LINEAR = 0;

		public const int CURVE_STEPPED = 1;

		public const int CURVE_BEZIER = 2;

		private AttachmentLoader attachmentLoader;

		private char[] chars;

		private byte[] buffer;

		public float Scale { get; set; }

		public SkeletonBinary(params Atlas[] atlasArray)
		{
		}

		public SkeletonBinary(AttachmentLoader attachmentLoader)
		{
		}

		public SkeletonData ReadSkeletonData(string path)
		{
			return null;
		}

		public SkeletonData ReadSkeletonData(Stream input)
		{
			return null;
		}

		private Skin ReadSkin(Stream input, string skinName, bool nonessential)
		{
			return null;
		}

		private Attachment ReadAttachment(Stream input, Skin skin, string attachmentName, bool nonessential)
		{
			return null;
		}

		private float[] ReadFloatArray(Stream input, float scale)
		{
			return null;
		}

		private int[] ReadShortArray(Stream input)
		{
			return null;
		}

		private int[] ReadIntArray(Stream input)
		{
			return null;
		}

		private void ReadAnimation(string name, Stream input, SkeletonData skeletonData)
		{
		}

		private void ReadCurve(Stream input, int frameIndex, CurveTimeline timeline)
		{
		}

		private sbyte ReadSByte(Stream input)
		{
			return 0;
		}

		private bool ReadBoolean(Stream input)
		{
			return false;
		}

		private float ReadFloat(Stream input)
		{
			return 0f;
		}

		private int ReadInt(Stream input)
		{
			return 0;
		}

		private int ReadInt(Stream input, bool optimizePositive)
		{
			return 0;
		}

		private string ReadString(Stream input)
		{
			return null;
		}

		private void ReadUtf8_slow(Stream input, int charCount, int charIndex, int b)
		{
		}
	}
}
