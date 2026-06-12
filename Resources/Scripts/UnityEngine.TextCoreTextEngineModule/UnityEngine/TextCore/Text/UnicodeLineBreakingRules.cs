using System;
using System.Collections.Generic;

namespace UnityEngine.TextCore.Text
{
	[Serializable]
	public class UnicodeLineBreakingRules
	{
		private static UnicodeLineBreakingRules s_Instance;

		[SerializeField]
		private UnityEngine.TextAsset m_UnicodeLineBreakingRules;

		[SerializeField]
		private UnityEngine.TextAsset m_LeadingCharacters;

		[SerializeField]
		private UnityEngine.TextAsset m_FollowingCharacters;

		[SerializeField]
		private bool m_UseModernHangulLineBreakingRules;

		private static HashSet<uint> s_LeadingCharactersLookup;

		private static HashSet<uint> s_FollowingCharactersLookup;

		public UnityEngine.TextAsset leadingCharacters => null;

		public UnityEngine.TextAsset followingCharacters => null;

		internal HashSet<uint> leadingCharactersLookup => null;

		internal HashSet<uint> followingCharactersLookup => null;

		public bool useModernHangulLineBreakingRules => false;

		internal static void LoadLineBreakingRules()
		{
		}

		internal static void LoadLineBreakingRules(UnityEngine.TextAsset leadingRules, UnityEngine.TextAsset followingRules)
		{
		}

		private static HashSet<uint> GetCharacters(UnityEngine.TextAsset file)
		{
			return null;
		}
	}
}
