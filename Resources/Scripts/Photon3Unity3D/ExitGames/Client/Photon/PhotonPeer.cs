using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon.EncryptorManaged;

namespace ExitGames.Client.Photon
{
	public class PhotonPeer
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int _003CCommandBufferSize_003Ek__BackingField;

		[Obsolete("Check QueuedOutgoingCommands and QueuedIncomingCommands on demand instead.")]
		public int WarningSize;

		public const bool NoSocket = false;

		public const bool NativeDatagramEncrypt = false;

		public const bool DebugBuild = true;

		protected internal byte ClientSdkId;

		private string clientVersion;

		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig;

		public DebugLevel DebugOut;

		private byte quickResendAttempts;

		public int RhttpMinConnections;

		public int RhttpMaxConnections;

		public byte ChannelCount;

		private bool crcEnabled;

		public int SentCountAllowance;

		public int TimePingInterval;

		public int DisconnectTimeout;

		public static int OutgoingStreamBufferSize;

		private int mtu;

		public static bool AsyncKeyExchange;

		internal bool RandomizeSequenceNumbers;

		internal byte[] RandomizedSequenceNumbers;

		private Stopwatch trafficStatsStopwatch;

		private bool trafficStatsEnabled;

		internal PeerBase peerBase;

		private readonly object SendOutgoingLockObject;

		private readonly object DispatchLockObject;

		private readonly object EnqueueLock;

		protected internal byte[] PayloadEncryptionSecret;

		internal Encryptor DgramEncryptor;

		internal Decryptor DgramDecryptor;

		[Obsolete("See remarks.")]
		public int LimitOfUnreliableCommands { get; set; }

		protected internal byte ClientSdkIdShifted => 0;

		public string ClientVersion => null;

		public SerializationProtocol SerializationProtocolType { get; }

		public Type SocketImplementation { get; internal set; }

		public IPhotonPeerListener Listener { get; protected set; }

		public bool EnableServerTracing { get; }

		public byte QuickResendAttempts
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public PeerStateValue PeerState => default(PeerStateValue);

		public string PeerID => null;

		public bool CrcEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int PacketLossByCrc => 0;

		public int ResentReliableCommands => 0;

		public int ServerTimeInMilliSeconds => 0;

		public int ConnectionTime => 0;

		public int LastSendOutgoingTime => 0;

		public SupportClass.IntegerMillisecondsDelegate LocalMsTimestampDelegate
		{
			set
			{
			}
		}

		public int RoundTripTime => 0;

		public int RoundTripTimeVariance => 0;

		public int TimestampOfLastSocketReceive => 0;

		public string ServerAddress => null;

		public ConnectionProtocol UsedProtocol => default(ConnectionProtocol);

		public ConnectionProtocol TransportProtocol { get; set; }

		public virtual bool IsSimulationEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public NetworkSimulationSet NetworkSimulationSettings => null;

		public int MaximumTransferUnit => 0;

		public bool IsEncryptionAvailable => false;

		public bool IsSendingOnlyAcks { get; set; }

		public TrafficStats TrafficStatsIncoming { get; internal set; }

		public TrafficStats TrafficStatsOutgoing { get; internal set; }

		public TrafficStatsGameLevel TrafficStatsGameLevel { get; internal set; }

		public long TrafficStatsElapsedMs => 0L;

		public bool TrafficStatsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void TrafficStatsReset()
		{
		}

		internal void InitializeTrafficStats()
		{
		}

		public string VitalStatsToString(bool all)
		{
			return null;
		}

		public PhotonPeer(ConnectionProtocol protocolType)
		{
		}

		public PhotonPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		{
		}

		public virtual bool Connect(string serverAddress, string applicationName)
		{
			return false;
		}

		public virtual bool Connect(string serverAddress, string applicationName, object custom)
		{
			return false;
		}

		private void CreatePeerBase()
		{
		}

		public virtual void Disconnect()
		{
		}

		public virtual void StopThread()
		{
		}

		public virtual void FetchServerTimestamp()
		{
		}

		public bool EstablishEncryption()
		{
			return false;
		}

		public bool InitDatagramEncryption(byte[] encryptionSecret, byte[] hmacSecret, bool randomizedSequenceNumbers = false)
		{
			return false;
		}

		public void InitPayloadEncryption(byte[] secret)
		{
		}

		public virtual bool SendOutgoingCommands()
		{
			return false;
		}

		public virtual bool SendAcksOnly()
		{
			return false;
		}

		public virtual bool DispatchIncomingCommands()
		{
			return false;
		}

		public virtual bool SendOperation(byte operationCode, Dictionary<byte, object> operationParameters, SendOptions sendOptions)
		{
			return false;
		}

		[Obsolete("Use SendOperation() or SendMessage().")]
		public virtual bool OpCustom(byte customOpCode, Dictionary<byte, object> customOpParameters, bool sendReliable, byte channelId = 0, bool encrypt = false)
		{
			return false;
		}

		public static bool RegisterType(Type customType, byte code, SerializeStreamMethod serializeMethod, DeserializeStreamMethod constructor)
		{
			return false;
		}
	}
}
