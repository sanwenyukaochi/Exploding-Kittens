using System;
using System.Collections.Generic;
using UnityEngine;

public class GameplayAnnouncer : MonoBehaviour
{
	public ActivityBannerQueue ActivityBannerQueue;

	public ActivityStream ActivityStream;

	public List<BannerFactoryCriteria> BannerMetadataFactoryCriteria;

	public void Initialize()
	{
	}

	private void OnActivity(Activity activity)
	{
	}

	private void Cull(Activity activity, Action<BannerMetadataFactory> onShouldShow)
	{
	}
}
