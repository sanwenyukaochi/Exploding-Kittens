using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	public static class Tuple
	{
		public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
		{
			return null;
		}

		public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
		{
			return null;
		}

		internal static int CombineHashCodes(int h1, int h2)
		{
			return 0;
		}

		internal static int CombineHashCodes(int h1, int h2, int h3)
		{
			return 0;
		}

		internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
		{
			return 0;
		}
	}
	[Serializable]
	public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		private readonly T1 m_Item1;

		private readonly T2 m_Item2;

		public T1 Item1 => default(T1);

		public T2 Item2 => default(T2);

		int ITuple.Length => 0;

		public Tuple(T1 item1, T2 item2)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		string ITupleInternal.ToString(StringBuilder sb)
		{
			return null;
		}
	}
	[Serializable]
	public class Tuple<T1, T2, T3> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		private readonly T1 m_Item1;

		private readonly T2 m_Item2;

		private readonly T3 m_Item3;

		public T1 Item1 => default(T1);

		public T2 Item2 => default(T2);

		public T3 Item3 => default(T3);

		int ITuple.Length => 0;

		public Tuple(T1 item1, T2 item2, T3 item3)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		string ITupleInternal.ToString(StringBuilder sb)
		{
			return null;
		}
	}
	[Serializable]
	public class Tuple<T1, T2, T3, T4> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		private readonly T1 m_Item1;

		private readonly T2 m_Item2;

		private readonly T3 m_Item3;

		private readonly T4 m_Item4;

		public T1 Item1 => default(T1);

		public T2 Item2 => default(T2);

		public T3 Item3 => default(T3);

		public T4 Item4 => default(T4);

		int ITuple.Length => 0;

		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		string ITupleInternal.ToString(StringBuilder sb)
		{
			return null;
		}
	}
}
