using System;
using System.Collections.Generic;

namespace ExitGames.Client.Photon.Chat
{
	public class ChatClient : IPhotonPeerListener
	{
		private const int FriendRequestListMax = 1024;

		public const int DefaultMaxSubscribers = 100;

		private string chatRegion;

		public int MessageLimit;

		public readonly Dictionary<string, ChatChannel> PublicChannels;

		public readonly Dictionary<string, ChatChannel> PrivateChannels;

		private readonly HashSet<string> PublicChannelsUnsubscribing;

		private readonly IChatClientListener listener;

		public ChatPeer chatPeer;

		private const string ChatAppName = "chat";

		private bool didAuthenticate;

		private int msDeltaForServiceCalls;

		private int msTimestampOfLastServiceCall;

		public string NameServerAddress { get; private set; }

		public string FrontendAddress { get; private set; }

		public string ChatRegion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ChatState State { get; private set; }

		public ChatDisconnectCause DisconnectedCause { get; private set; }

		public bool CanChat => false;

		private bool HasPeer => false;

		public string AppVersion { get; private set; }

		public string AppId { get; private set; }

		public AuthenticationValues AuthValues { get; set; }

		public string UserId
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool UseBackgroundWorkerForSending { get; set; }

		public ConnectionProtocol TransportProtocol
		{
			get
			{
				return default(ConnectionProtocol);
			}
			set
			{
			}
		}

		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig => null;

		public DebugLevel DebugOut
		{
			get
			{
				return default(DebugLevel);
			}
			set
			{
			}
		}

		public bool CanChatInChannel(string channelName)
		{
			return false;
		}

		public ChatClient(IChatClientListener listener, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		public bool Connect(string appId, string appVersion, AuthenticationValues authValues)
		{
			return false;
		}

		public void Service()
		{
		}

		private bool SendOutgoingInBackground()
		{
			return false;
		}

		[Obsolete("Better use UseBackgroundWorkerForSending and Service().")]
		public void SendAcksOnly()
		{
		}

		public void Disconnect()
		{
		}

		public void StopThread()
		{
		}

		public bool Subscribe(string[] channels)
		{
			return false;
		}

		public bool Subscribe(string[] channels, int messagesFromHistory)
		{
			return false;
		}

		public bool Subscribe(string[] channels, int[] lastMsgIds)
		{
			return false;
		}

		public bool Unsubscribe(string[] channels)
		{
			return false;
		}

		public bool PublishMessage(string channelName, object message, bool forwardAsWebhook = false)
		{
			return false;
		}

		internal bool PublishMessageUnreliable(string channelName, object message, bool forwardAsWebhook = false)
		{
			return false;
		}

		private bool publishMessage(string channelName, object message, bool reliable, bool forwardAsWebhook = false)
		{
			return false;
		}

		public bool SendPrivateMessage(string target, object message, bool forwardAsWebhook = false)
		{
			return false;
		}

		public bool SendPrivateMessage(string target, object message, bool encrypt, bool forwardAsWebhook)
		{
			return false;
		}

		internal bool SendPrivateMessageUnreliable(string target, object message, bool encrypt, bool forwardAsWebhook = false)
		{
			return false;
		}

		private bool sendPrivateMessage(string target, object message, bool encrypt, bool reliable, bool forwardAsWebhook = false)
		{
			return false;
		}

		private bool SetOnlineStatus(int status, object message, bool skipMessage)
		{
			return false;
		}

		public bool SetOnlineStatus(int status)
		{
			return false;
		}

		public bool SetOnlineStatus(int status, object message)
		{
			return false;
		}

		public bool AddFriends(string[] friends)
		{
			return false;
		}

		public bool RemoveFriends(string[] friends)
		{
			return false;
		}

		public string GetPrivateChannelNameByUser(string userName)
		{
			return null;
		}

		public bool TryGetChannel(string channelName, bool isPrivate, out ChatChannel channel)
		{
			channel = null;
			return false;
		}

		public bool TryGetChannel(string channelName, out ChatChannel channel)
		{
			channel = null;
			return false;
		}

		void IPhotonPeerListener.DebugReturn(DebugLevel level, string message)
		{
		}

		void IPhotonPeerListener.OnEvent(EventData eventData)
		{
		}

		void IPhotonPeerListener.OnOperationResponse(OperationResponse operationResponse)
		{
		}

		void IPhotonPeerListener.OnStatusChanged(StatusCode statusCode)
		{
		}

		private bool SendChannelOperation(string[] channels, byte operation, int historyLength)
		{
			return false;
		}

		private void HandlePrivateMessageEvent(EventData eventData)
		{
		}

		private void HandleChatMessagesEvent(EventData eventData)
		{
		}

		private void HandleSubscribeEvent(EventData eventData)
		{
		}

		private void HandleUnsubscribeEvent(EventData eventData)
		{
		}

		private void HandleAuthResponse(OperationResponse operationResponse)
		{
		}

		private void HandleStatusUpdate(EventData eventData)
		{
		}

		private void ConnectToFrontEnd()
		{
		}

		private bool AuthenticateOnFrontEnd()
		{
			return false;
		}

		private void HandleUserUnsubscribedEvent(EventData eventData)
		{
		}

		private void HandleUserSubscribedEvent(EventData eventData)
		{
		}

		public bool Subscribe(string channel, int lastMsgId = 0, int messagesFromHistory = -1, ChannelCreationOptions creationOptions = null)
		{
			return false;
		}
	}
}
