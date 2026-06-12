using System;
using UnityEngine;

public class ApiVersionValidator : MonoBehaviour
{
	private int currentRoomApiVersion => 0;

	public void Validate(Action OnValidApiVersion, Action<ApiVersionError> OnInvalidApiVersion)
	{
	}
}
