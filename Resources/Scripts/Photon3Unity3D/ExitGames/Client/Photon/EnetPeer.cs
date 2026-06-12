using System.Collections.Generic;

namespace ExitGames.Client.Photon
{
	internal class EnetPeer : PeerBase
	{
		private static readonly int HMAC_SIZE;

		private static readonly int BLOCK_SIZE;

		private static readonly int IV_SIZE;

		private List<NCommand> sentReliableCommands;

		private StreamBuffer outgoingAcknowledgementsPool;

		internal readonly int[] unsequencedWindow;

		internal int outgoingUnsequencedGroupNumber;

		internal int incomingUnsequencedGroupNumber;

		private byte udpCommandCount;

		private byte[] udpBuffer;

		private int udpBufferIndex;

		private int udpBufferLength;

		private byte[] bufferForEncryption;

		private int commandBufferSize;

		internal int challenge;

		internal int reliableCommandsRepeated;

		internal int reliableCommandsSent;

		internal int serverSentTime;

		internal static readonly byte[] udpHeader0xF3;

		internal static readonly byte[] messageHeader;

		protected bool datagramEncryptedConnection;

		private EnetChannel[] channelArray;

		private Queue<int> commandsToRemove;

		private int fragmentLength;

		private int fragmentLengthDatagramEncrypt;

		private int fragmentLengthMtuValue;

		private Queue<NCommand> commandsToResend;

		private Queue<NCommand> CommandQueue;

		internal EnetPeer()
		{
		}

		internal override void InitPeerBase()
		{
		}

		internal void ApplyRandomizedSequenceNumbers()
		{
		}

		internal override bool Connect(string ipport, string appID, object custom = null)
		{
			return false;
		}

		public override void OnConnect()
		{
		}

		internal override void Disconnect()
		{
		}

		internal override void StopConnection()
		{
		}

		internal override void FetchServerTimestamp()
		{
		}

		internal override bool DispatchIncomingCommands()
		{
			return false;
		}

		private int GetFragmentLength()
		{
			return 0;
		}

		private int CalculateBufferLen()
		{
			return 0;
		}

		private int CalculateInitialOffset()
		{
			return 0;
		}

		internal override bool SendAcksOnly()
		{
			return false;
		}

		internal override bool SendOutgoingCommands()
		{
			return false;
		}

		private bool AreReliableCommandsInTransit()
		{
			return false;
		}

		internal override bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, SendOptions sendParams, EgMessageType messageType = EgMessageType.Operation)
		{
			return false;
		}

		private EnetChannel GetChannel(byte channelNumber)
		{
			return null;
		}

		internal bool CreateAndEnqueueCommand(byte commandType, StreamBuffer payload, byte channelNumber)
		{
			return false;
		}

		internal override StreamBuffer SerializeOperationToMessage(byte opCode, Dictionary<byte, object> parameters, EgMessageType messageType, bool encrypt)
		{
			return null;
		}

		internal int SerializeAckToBuffer()
		{
			return 0;
		}

		internal int SerializeToBuffer(Queue<NCommand> commandList)
		{
			return 0;
		}

		internal void SendData(byte[] data, int length)
		{
		}

		private void SendToSocket(byte[] data, int length)
		{
		}

		private void SendDataEncrypted(byte[] data, int length)
		{
		}

		internal void QueueSentCommand(NCommand command)
		{
		}

		internal void QueueOutgoingReliableCommand(NCommand command)
		{
		}

		internal void QueueOutgoingUnreliableCommand(NCommand command)
		{
		}

		internal void QueueOutgoingAcknowledgement(NCommand readCommand, int sendTime)
		{
		}

		internal override void ReceiveIncomingCommands(byte[] inBuff, int dataLength)
		{
		}

		internal bool ExecuteCommand(NCommand command)
		{
			return false;
		}

		internal bool QueueIncomingCommand(NCommand command)
		{
			return false;
		}

		internal NCommand RemoveSentReliableCommand(int ackReceivedReliableSequenceNumber, int ackReceivedChannel, bool isUnsequenced)
		{
			return null;
		}
	}
}
