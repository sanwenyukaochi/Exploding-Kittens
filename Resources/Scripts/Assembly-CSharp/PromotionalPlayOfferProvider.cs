using UnityEngine;

public class PromotionalPlayOfferProvider : MonoBehaviour
{
	public PromotionalPlayOffer[] Offers;

	public int[] GamesPlayedTriggers;

	public PromotionalPlayOffer NextOffer => null;

	private PromotionalPlayOffer FirstAvailableOffer => null;

	private bool ScheduledToSeeOffer(int numGamesPlayed)
	{
		return false;
	}

	private bool HaveSeenOfferAlready(int numGamesPlayed)
	{
		return false;
	}

	private void RecordSeeingOffer(PromotionalPlayOffer offer, int numGamesPlayed)
	{
	}
}
