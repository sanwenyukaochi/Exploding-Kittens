using UnityEngine;

public class SlapAnimationController : MonoBehaviour
{
	public PlayMakerFSM SlapFsm;

	public PlayerProvider PlayerProvider;

	public GenericEvent OnSlapAnimationComplete;

	private Player CurrentPlayer => null;

	public void Start()
	{
	}

	public void NotifySlapAnimationComplete()
	{
	}

	private void OnAttack(Player attacker, Player victim, int turnsRemaining)
	{
	}
}
