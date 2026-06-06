using UnityEngine;

public class NewCardAnimation : MonoBehaviour
{
	public MovementAction FinalMovementAction;

	public UITexture CardTexture;

	public ActionBase AnimationAction;

	public RotateByAction RotateByAction;

	public float MinRotationDeviance;

	public float MaxRotationDeviance;

	private Vector3 RandomRotation => default(Vector3);

	public void Initialize(Card card, Vector3 destinationPosition)
	{
	}
}
