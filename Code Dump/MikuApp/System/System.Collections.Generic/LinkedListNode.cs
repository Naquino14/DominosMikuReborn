using System.Runtime.InteropServices;

namespace System.Collections.Generic
{
	/// <summary>Represents a node in a <see cref="T:System.Collections.Generic.LinkedList`1" />. This class cannot be inherited.</summary>
	/// <typeparam name="T">Specifies the element type of the linked list.</typeparam>
	/// <filterpriority>1</filterpriority>
	[ComVisible(false)]
	public sealed class LinkedListNode<T>
	{
		private T item;

		private LinkedList<T> container;

		internal LinkedListNode<T> forward;

		internal LinkedListNode<T> back;

		/// <summary>Gets the <see cref="T:System.Collections.Generic.LinkedList`1" /> that the <see cref="T:System.Collections.Generic.LinkedListNode`1" /> belongs to.</summary>
		/// <returns>A reference to the <see cref="T:System.Collections.Generic.LinkedList`1" /> that the <see cref="T:System.Collections.Generic.LinkedListNode`1" /> belongs to, or null if the <see cref="T:System.Collections.Generic.LinkedListNode`1" /> is not linked.</returns>
		public LinkedList<T> List => (LinkedList<T>)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the next node in the <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
		/// <returns>A reference to the next node in the <see cref="T:System.Collections.Generic.LinkedList`1" />, or null if the current node is the last element (<see cref="P:System.Collections.Generic.LinkedList`1.Last" />) of the <see cref="T:System.Collections.Generic.LinkedList`1" />.</returns>
		public LinkedListNode<T> Next => (LinkedListNode<T>)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the value contained in the node.</summary>
		/// <returns>The value contained in the node.</returns>
		public T Value => (T)/*Error near IL_0001: Stack underflow*/;

		internal LinkedListNode(LinkedList<T> list, T value)
		{
		}

		internal LinkedListNode(LinkedList<T> list, T value, LinkedListNode<T> previousNode, LinkedListNode<T> nextNode)
		{
		}

		internal void Detach()
		{
		}
	}
}
