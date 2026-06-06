using System;
using System.Collections.Generic;

public class NetworkMessageRouter
{
	private Dictionary<string, Action<NetworkMessage>> handlers;

	public static NetworkMessageRouter instance;

	public static NetworkMessageRouter Instance => null;

	public void RouteMessage(string messageType, NetworkMessage networkMessage)
	{
	}

	public void AddHandler(string messageType, Action<NetworkMessage> handler)
	{
	}

	public void RemoveHandler(string messageType)
	{
	}
}
