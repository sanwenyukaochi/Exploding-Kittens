using System.Collections.Generic;
using UnityEngine;

public class FlaggedDeviceIdRepository : MonoBehaviour
{
	public static FlaggedDeviceIdRepository Instance;

	public List<string> DeviceIds;

	private const string BACKING_STORE_FILENAME = "flagged_users.txt";

	private string BackingStorePath => null;

	private void Awake()
	{
	}

	public void Add(string deviceId)
	{
	}

	public void Remove(string deviceId)
	{
	}

	public bool Contains(string deviceId)
	{
		return false;
	}

	public void Reset()
	{
	}

	private void LoadExistingDeviceIds()
	{
	}

	private void Save()
	{
	}
}
