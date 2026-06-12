using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Jobs.LowLevel.Unsafe
{
	[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
	[NativeHeader("Runtime/Jobs/JobSystem.h")]
	public static class JobsUtility
	{
		public struct JobScheduleParameters
		{
			public JobHandle Dependency;

			public int ScheduleMode;

			public IntPtr ReflectionData;

			public IntPtr JobDataPtr;

			public unsafe JobScheduleParameters(void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode)
			{
				Dependency = default(JobHandle);
				ScheduleMode = 0;
				ReflectionData = (IntPtr)0;
				JobDataPtr = (IntPtr)0;
			}
		}

		internal delegate void PanicFunction_();

		internal static PanicFunction_ PanicFunction;

		[NativeMethod(IsFreeFunction = true, IsThreadSafe = true)]
		public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex)
		{
			beginIndex = default(int);
			endIndex = default(int);
			return false;
		}

		[FreeFunction("ScheduleManagedJobParallelFor", ThrowsException = true, IsThreadSafe = true)]
		public static JobHandle ScheduleParallelFor(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount)
		{
			return default(JobHandle);
		}

		[FreeFunction(ThrowsException = true, IsThreadSafe = true)]
		private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2)
		{
			return (IntPtr)0;
		}

		public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1 = null, object managedJobFunction2 = null)
		{
			return (IntPtr)0;
		}

		[RequiredByNativeCode]
		private static void InvokePanicFunction()
		{
		}

		private static void ScheduleParallelFor_Injected(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret)
		{
			ret = default(JobHandle);
		}
	}
}
