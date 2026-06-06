using System.Collections.Generic;

namespace ExitGames.Client.Photon.Chat
{
	public class ChatChannel
	{
		public readonly string Name;

		public readonly List<string> Senders;

		public readonly List<object> Messages;

		public int MessageLimit;

		public bool IsPrivate { get; protected internal set; }

		public int MessageCount => 0;

		public ChatChannel(string name)
		{
		}

		public void Add(string sender, object message)
		{
		}

		public void Add(string[] senders, object[] messages)
		{
		}

		public void TruncateMessages()
		{
		}

		public void ClearMessages()
		{
		}

		public string ToStringMessages()
		{
			return null;
		}
	}
}
