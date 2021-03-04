using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x02000040 RID: 64
public class BetterList<T>
{
	// Token: 0x06000176 RID: 374 RVA: 0x00002624 File Offset: 0x00000824
	[DebuggerHidden]
	public IEnumerator<T> GetEnumerator()
	{
	}

	// Token: 0x17000029 RID: 41
	public T this[int i]
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00002630 File Offset: 0x00000830
	private void AllocateMore()
	{
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00002634 File Offset: 0x00000834
	private void Trim()
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00002638 File Offset: 0x00000838
	public void Clear()
	{
	}

	// Token: 0x0600017C RID: 380 RVA: 0x0000263C File Offset: 0x0000083C
	public void Release()
	{
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00002640 File Offset: 0x00000840
	public void Add(T item)
	{
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00002644 File Offset: 0x00000844
	public void Insert(int index, T item)
	{
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00002648 File Offset: 0x00000848
	public bool Contains(T item)
	{
	}

	// Token: 0x06000180 RID: 384 RVA: 0x0000264C File Offset: 0x0000084C
	public bool Remove(T item)
	{
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00002650 File Offset: 0x00000850
	public void RemoveAt(int index)
	{
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00002654 File Offset: 0x00000854
	public T[] ToArray()
	{
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00002658 File Offset: 0x00000858
	public void Sort(Comparison<T> comparer)
	{
	}

	// Token: 0x04000198 RID: 408
	public T[] buffer;

	// Token: 0x04000199 RID: 409
	public int size;
}
