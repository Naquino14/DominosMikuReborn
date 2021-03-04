using System;
using System.Collections.Generic;
using System.Diagnostics;

public class BetterList<T>
{
	public T[] buffer;

	public int size;

	public T this[int i]
	{
		get
		{
			return (T)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	[DebuggerHidden]
	public IEnumerator<T> GetEnumerator()
	{
		return (IEnumerator<T>)/*Error near IL_0001: Stack underflow*/;
	}

	private void AllocateMore()
	{
	}

	private void Trim()
	{
	}

	public void Clear()
	{
	}

	public void Release()
	{
	}

	public void Add(T item)
	{
	}

	public void Insert(int index, T item)
	{
	}

	public bool Contains(T item)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public bool Remove(T item)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void RemoveAt(int index)
	{
	}

	public T[] ToArray()
	{
		return (T[])/*Error near IL_0001: Stack underflow*/;
	}

	public void Sort(Comparison<T> comparer)
	{
	}
}
