using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SA_ValuesTween : MonoBehaviour
{
	public bool DestoryGameObjectOnComplete;

	private float FinalFloatValue;

	private Vector3 FinalVectorValue;

	public event Action OnComplete
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<float> OnValueChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Vector3> OnVectorValueChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static SA_ValuesTween Create()
	{
		return null;
	}

	private void Update()
	{
	}

	public void ValueTo(float from, float to, float time, SA_EaseType easeType = SA_EaseType.linear)
	{
	}

	public void VectorTo(Vector3 from, Vector3 to, float time, SA_EaseType easeType = SA_EaseType.linear)
	{
	}

	public void VectorToS(Vector3 from, Vector3 to, float speed, SA_EaseType easeType = SA_EaseType.linear)
	{
	}

	public void Stop()
	{
	}

	private void onTweenComplete()
	{
	}
}
