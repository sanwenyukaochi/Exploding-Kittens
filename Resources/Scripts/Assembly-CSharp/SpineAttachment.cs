using Spine;
using UnityEngine;

public class SpineAttachment : PropertyAttribute
{
	public struct Hierarchy
	{
		public string skin;

		public string slot;

		public string name;

		public Hierarchy(string fullPath)
		{
			skin = null;
			slot = null;
			name = null;
		}
	}

	public bool returnAttachmentPath;

	public bool currentSkinOnly;

	public bool placeholdersOnly;

	public string dataField;

	public string slotField;

	public SpineAttachment()
	{
	}

	public SpineAttachment(bool currentSkinOnly = true, bool returnAttachmentPath = false, bool placeholdersOnly = false, string slotField = "", string dataField = "")
	{
	}

	public static Hierarchy GetHierarchy(string fullPath)
	{
		return default(Hierarchy);
	}

	public static Attachment GetAttachment(string attachmentPath, SkeletonData skeletonData)
	{
		return null;
	}

	public static Attachment GetAttachment(string attachmentPath, SkeletonDataAsset skeletonDataAsset)
	{
		return null;
	}
}
