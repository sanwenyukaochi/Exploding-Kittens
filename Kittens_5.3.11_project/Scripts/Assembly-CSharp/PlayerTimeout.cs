public class PlayerTimeout : TimeoutAction
{
	public static PlayerTimeout m;

	public GameMessages GameMessages;

	public Player CurrentPlayerAction;

	public bool GarbageCollectionActive;

	public OnPlayerTimeout OnTimeOutCallback;

	private Player Player;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Init(Player player)
	{
	}

	public void StartTimer(float time)
	{
	}

	public void StopTimer()
	{
	}

	private void OnPlayCard(Player player, Card card)
	{
	}

	private void OnEndTurn(Player player)
	{
	}

	private void Update()
	{
	}

	private void OnTimeOut()
	{
	}
}
