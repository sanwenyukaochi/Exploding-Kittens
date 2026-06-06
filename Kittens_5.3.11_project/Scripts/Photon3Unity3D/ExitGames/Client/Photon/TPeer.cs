using System.Collections.Generic;

namespace ExitGames.Client.Photon
{
	internal class TPeer : PeerBase
	{
		private Queue<byte[]> incomingList;

		internal List<StreamBuffer> outgoingStream;

		private int lastPingResult;

		private byte[] pingRequest;

		internal static readonly byte[] tcpFramedMessageHead;

		internal static readonly byte[] tcpMsgHead;

		internal byte[] messageHeader;

		protected internal bool DoFraming;

		internal TPeer()
		{
		}

		internal override void InitPeerBase()
		{
		}

		internal override bool Connect(string serverAddress, string appID, object customData = null)
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

		private void EnqueueInit(byte[] data)
		{
		}

		internal override bool DispatchIncomingCommands()
		{
			return false;
		}

		internal override bool SendOutgoingCommands()
		{
			return false;
		}

		internal override bool SendAcksOnly()
		{
			return false;
		}

		internal override bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, SendOptions sendParams, EgMessageType messageType)
		{
			return false;
		}

		internal override StreamBuffer SerializeOperationToMessage(byte opCode, Dictionary<byte, object> parameters, EgMessageType messageType, bool encrypt)
		{
			return null;
		}

		internal bool EnqueueMessageAsPayload(DeliveryMode deliveryMode, StreamBuffer opMessage, byte channelId)
		{
			return false;
		}

		internal void SendPing()
		{
		}

		internal void SendData(byte[] data, int length)
		{
		}

		internal override void ReceiveIncomingCommands(byte[] inbuff, int dataLength)
		{
		}

		private void ReadPingResult(byte[] inbuff)
		{
		}

		protected internal void ReadPingResult(OperationResponse operationResponse)
		{
		}
	}
}
