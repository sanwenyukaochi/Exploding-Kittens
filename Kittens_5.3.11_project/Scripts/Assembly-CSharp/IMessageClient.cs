public interface IMessageClient
{
	void SendToAll(string messageType, params string[] messageParams);
}
