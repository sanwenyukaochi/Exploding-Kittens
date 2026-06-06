using UnityEngine;

public class WindowPaginator : MonoBehaviour
{
	public NavigationController NavigationController;

	public WindowTransitioner[] Windows;

	private int windowIndex;

	private WindowTransitioner CurrentWindow => null;

	public void Page(int pageOffset)
	{
	}

	public bool OffsetIsOutOfBounds(int pageOffset)
	{
		return false;
	}

	private void IncrementWindowIndex(int pageOffset)
	{
	}
}
