using System;
using Unity.Collections;
using UnityEngine.Bindings;

namespace Unity.Jobs
{
	[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
	public struct JobHandle : IEquatable<JobHandle>
	{
		internal ulong jobGroup;

		internal int version;

		public void Complete()
		{
		}

		[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = true, IsThreadSafe = true)]
		public static void ScheduleBatchedJobs()
		{
		}

		[NativeMethod("ScheduleBatchedScriptingJobsAndComplete", IsFreeFunction = true, IsThreadSafe = true, ThrowsException = true)]
		private static void ScheduleBatchedJobsAndComplete(ref JobHandle job)
		{
		}

		public static JobHandle CombineDependencies(NativeArray<JobHandle> jobs)
		{
			return default(JobHandle);
		}

		public static JobHandle CombineDependencies(NativeSlice<JobHandle> jobs)
		{
			return default(JobHandle);
		}

		[NativeMethod(IsFreeFunction = true, IsThreadSafe = true, ThrowsException = true)]
		internal unsafe static JobHandle CombineDependenciesInternalPtr(void* jobs, int count)
		{
			return default(JobHandle);
		}

		public bool Equals(JobHandle other)
		{
			return false;
		}

		private unsafe static void CombineDependenciesInternalPtr_Injected(void* jobs, int count, out JobHandle ret)
		{
			ret = default(JobHandle);
		}
	}
}
