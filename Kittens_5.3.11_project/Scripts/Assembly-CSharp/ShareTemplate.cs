using System;
using UnityEngine;

[Serializable]
public class ShareTemplate
{
	[TextArea(1, 10)]
	public string ShareTextTemplate;

	public string ImagePath;

	public string Url;

	public string Subject;

	public string ShareText(string code)
	{
		return null;
	}
}
