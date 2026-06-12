using System.Collections.Generic;
using UnityEngine;

public class PlayerInterfaceRepository : MonoBehaviour
{
	private List<IPlayerInterface> faces;

	public void Add(IPlayerInterface behaviour)
	{
	}

	public void Reset()
	{
	}

	public IPlayerInterface FindByPlayer(Player player)
	{
		return null;
	}

	public void SwitchTo(Player player)
	{
	}

	private void Update()
	{
	}
}
