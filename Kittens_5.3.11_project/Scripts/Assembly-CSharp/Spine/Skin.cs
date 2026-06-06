using System.Collections.Generic;

namespace Spine
{
	public class Skin
	{
		private class AttachmentKeyTupleComparer : IEqualityComparer<AttachmentKeyTuple>
		{
			internal static readonly AttachmentKeyTupleComparer Instance;

			bool IEqualityComparer<AttachmentKeyTuple>.Equals(AttachmentKeyTuple o1, AttachmentKeyTuple o2)
			{
				return false;
			}

			int IEqualityComparer<AttachmentKeyTuple>.GetHashCode(AttachmentKeyTuple o)
			{
				return 0;
			}
		}

		private class AttachmentKeyTuple
		{
			public readonly int SlotIndex;

			public readonly string Name;

			public readonly int NameHashCode;

			public AttachmentKeyTuple(int slotIndex, string name)
			{
			}
		}

		internal string name;

		private Dictionary<AttachmentKeyTuple, Attachment> attachments;

		public string Name => null;

		public Skin(string name)
		{
		}

		public void AddAttachment(int slotIndex, string name, Attachment attachment)
		{
		}

		public Attachment GetAttachment(int slotIndex, string name)
		{
			return null;
		}

		public void FindNamesForSlot(int slotIndex, List<string> names)
		{
		}

		public void FindAttachmentsForSlot(int slotIndex, List<Attachment> attachments)
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal void AttachAll(Skeleton skeleton, Skin oldSkin)
		{
		}
	}
}
