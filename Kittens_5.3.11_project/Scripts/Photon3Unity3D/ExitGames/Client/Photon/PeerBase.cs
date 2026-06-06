using System;
using System.Collections.Generic;
using Photon.SocketServer.Security;

namespace ExitGames.Client.Photon
{
	public abstract class PeerBase
	{
		internal delegate void MyAction();

		internal PhotonPeer photonPeer;

		public IProtocol SerializationProtocol;

		internal ConnectionProtocol usedTransportProtocol;

		internal IPhotonSocket PhotonSocket;

		internal ConnectionStateValue peerConnectionState;

		internal int ByteCountLastOperation;

		internal int ByteCountCurrentDispatch;

		internal NCommand CommandInCurrentDispatch;

		internal int packetLossByCrc;

		internal int packetLossByChallenge;

		internal readonly Queue<MyAction> ActionQueue;

		internal short peerID;

		internal int serverTimeOffset;

		internal bool serverTimeOffsetIsAvailable;

		internal int roundTripTime;

		internal int roundTripTimeVariance;

		internal int lastRoundTripTime;

		internal int lowestRoundTripTime;

		internal int lastRoundTripTimeVariance;

		internal int highestRoundTripTimeVariance;

		internal int timestampOfLastReceive;

		internal static short peerCount;

		internal long bytesOut;

		internal long bytesIn;

		internal object CustomInitData;

		public string AppId;

		internal int timeBase;

		internal int timeInt;

		internal int timeoutInt;

		internal int timeLastAckReceive;

		internal int timeLastSendAck;

		internal int timeLastSendOutgoing;

		internal bool ApplicationIsInitialized;

		internal bool isEncryptionAvailable;

		internal int outgoingCommandsInStream;

		protected internal static Queue<StreamBuffer> MessageBufferPool;

		internal ICryptoProvider CryptoProvider;

		private readonly Random lagRandomizer;

		internal readonly LinkedList<SimulationItem> NetSimListOutgoing;

		internal readonly LinkedList<SimulationItem> NetSimListIncoming;

		private readonly NetworkSimulationSet networkSimulationSettings;

		internal int TrafficPackageHeaderSize;

		private int commandLogSize;

		internal Queue<CmdLogItem> CommandLog;

		internal Queue<CmdLogItem> InReliableLog;

		internal Type SocketImplementation => null;

		public string ServerAddress { get; internal set; }

		internal IPhotonPeerListener Listener => null;

		internal DebugLevel debugOut => default(DebugLevel);

		internal int DisconnectTimeout => 0;

		internal int timePingInterval => 0;

		internal byte ChannelCount => 0;

		public virtual string PeerID => null;

		internal bool IsSendingOnlyAcks => false;

		internal int mtu => 0;

		protected internal bool IsIpv6 => false;

		public NetworkSimulationSet NetworkSimulationSettings => null;

		internal bool TrafficStatsEnabled => false;

		internal TrafficStats TrafficStatsIncoming => null;

		internal TrafficStats TrafficStatsOutgoing => null;

		internal TrafficStatsGameLevel TrafficStatsGameLevel => null;

		internal int CommandLogSize => 0;

		public static StreamBuffer MessageBufferPoolGet()
		{
			return null;
		}

		public static void MessageBufferPoolPut(StreamBuffer buff)
		{
		}

		internal virtual void InitPeerBase()
		{
		}

		internal abstract bool Connect(string serverAddress, string appID, object customData = null);

		private string GetHttpKeyValueString(Dictionary<string, string> dic)
		{
			return null;
		}

		internal byte[] PrepareConnectData(string serverAddress, string appID, object custom)
		{
			return null;
		}

		internal string PepareWebSocketUrl(string serverAddress, string appId, object customData)
		{
			return null;
		}

		public abstract void OnConnect();

		internal void InitCallback()
		{
		}

		internal abstract void Disconnect();

		internal abstract void StopConnection();

		internal abstract void FetchServerTimestamp();

		internal abstract bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, SendOptions sendParams, EgMessageType messageType = EgMessageType.Operation);

		internal abstract StreamBuffer SerializeOperationToMessage(byte opCode, Dictionary<byte, object> parameters, EgMessageType messageType, bool encrypt);

		internal abstract bool SendOutgoingCommands();

		internal virtual bool SendAcksOnly()
		{
			return false;
		}

		internal abstract void ReceiveIncomingCommands(byte[] inBuff, int dataLength);

		internal abstract bool DispatchIncomingCommands();

		internal virtual bool DeserializeMessageAndCallback(StreamBuffer stream)
		{
			return false;
		}

		internal void UpdateRoundTripTimeAndVariance(int lastRoundtripTime)
		{
		}

		internal bool ExchangeKeysForEncryption(object lockObject)
		{
			return false;
		}

		internal void DeriveSharedKey(OperationResponse operationResponse)
		{
		}

		internal virtual void InitEncryption(byte[] secret)
		{
		}

		internal void EnqueueActionForDispatch(MyAction action)
		{
		}

		internal void EnqueueDebugReturn(DebugLevel level, string debugReturn)
		{
		}

		internal void EnqueueStatusCallback(StatusCode statusValue)
		{
		}

		internal void SendNetworkSimulated(byte[] dataToSend)
		{
		}

		internal void ReceiveNetworkSimulated(byte[] dataReceived)
		{
		}

		protected internal void NetworkSimRun()
		{
		}

		internal void CommandLogResize()
		{
		}

		internal void CommandLogInit()
		{
		}
	}
}
