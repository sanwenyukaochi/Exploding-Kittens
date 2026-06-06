using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;

namespace System.Threading
{
	internal struct ExecutionContextSwitcher
	{
		internal ExecutionContext.Reader outerEC;

		internal bool outerECBelongsToScope;

		internal object hecsw;

		internal Thread thread;

		[HandleProcessCorruptedStateExceptions]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal bool UndoNoThrow()
		{
			return false;
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal void Undo()
		{
		}
	}
}
