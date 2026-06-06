using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends a Message to a Game Object. See Unity docs for SendMessage.")]
	[ActionCategory(ActionCategory.ScriptControl)]
	public class SendMessage : FsmStateAction
	{
		public enum MessageType
		{
			SendMessage = 0,
			SendMessageUpwards = 1,
			BroadcastMessage = 2
		}

		[Tooltip("The Game Object to send a message to.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Pick between <a href=\"http://unity3d.com/support/documentation/ScriptReference/GameObject.SendMessage.html\" rel=\"nofollow\">SendMessage</a>, <a href=\"http://unity3d.com/support/documentation/ScriptReference/GameObject.SendMessageUpwards.html\" rel=\"nofollow\">SendMessageUpwards</a>, or <a href=\"http://unity3d.com/support/documentation/ScriptReference/GameObject.BroadcastMessage.html\" rel=\"nofollow\">BroadcastMessage</a>.")]
		public MessageType delivery;

		[Tooltip("Message delivery options. See <a href=\"http://unity3d.com/support/documentation/ScriptReference/SendMessageOptions.html\" rel=\"nofollow\">SendMessageOptions</a> in Unity Docs.")]
		public SendMessageOptions options;

		[Tooltip("Select a Method Name first then Parameters.")]
		[RequiredField]
		public FunctionCall functionCall;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSendMessage()
		{
		}
	}
}
