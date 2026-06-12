using UnityEngine;

namespace MGS.Debugging
{
	public interface ILogHandler
	{
		void Log(string log, string stack, LogType type);

		void Log(string log, string stack, string type);

		void OnEnabled(string handler, bool enabled);

		void Update();

		void Pause(bool pause);
	}
}
