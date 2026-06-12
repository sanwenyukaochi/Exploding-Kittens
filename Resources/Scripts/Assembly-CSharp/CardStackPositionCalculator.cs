using UnityEngine;

public class CardStackPositionCalculator : MonoBehaviour
{
	private const float XJitter = 2.5f;

	private const float YJitter = 0.75f;

	public float RotationJitter;

	public Vector3 PositionForIndex(int index)
	{
		return default(Vector3);
	}

	public Quaternion RotationForIndex(int index)
	{
		return default(Quaternion);
	}

	private float X()
	{
		return 0f;
	}

	private float Y(int index)
	{
		return 0f;
	}

	private float Rotation()
	{
		return 0f;
	}
}
