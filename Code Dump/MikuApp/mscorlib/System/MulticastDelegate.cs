using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Represents a multicast delegate; that is, a delegate that can have more than one element in its invocation list.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public abstract class MulticastDelegate : Delegate
	{
		private MulticastDelegate prev;

		private MulticastDelegate kpm_next;

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with all the data needed to serialize this instance.</summary>
		/// <param name="info">An object that holds all the data needed to serialize or deserialize this instance. </param>
		/// <param name="context">(Reserved) The location where serialized data is stored and retrieved. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null. </exception>
		/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">A serialization error occurred.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		/// </PermissionSet>
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Determines whether this multicast delegate and the specified object are equal.</summary>
		/// <returns>true if <paramref name="obj" /> and this instance have the same invocation lists; otherwise, false.</returns>
		/// <param name="obj">The object to compare with this instance. </param>
		/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
		/// <filterpriority>2</filterpriority>
		public sealed override bool Equals(object obj)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
		/// <filterpriority>2</filterpriority>
		public sealed override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the invocation list of this multicast delegate, in invocation order.</summary>
		/// <returns>An array of delegates whose invocation lists collectively match the invocation list of this instance.</returns>
		/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
		/// <filterpriority>2</filterpriority>
		public sealed override Delegate[] GetInvocationList()
		{
			return (Delegate[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Combines this <see cref="T:System.Delegate" /> with the specified <see cref="T:System.Delegate" /> to form a new delegate.</summary>
		/// <returns>A <see cref="T:System.Delegate" /> that is the new root of the <see cref="T:System.MulticastDelegate" /> invocation list.</returns>
		/// <param name="follow">The delegate to combine with this delegate. </param>
		/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
		protected sealed override Delegate CombineImpl(Delegate follow)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		private bool BaseEquals(MulticastDelegate value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static MulticastDelegate KPM(MulticastDelegate needle, MulticastDelegate haystack, out MulticastDelegate tail)
		{
			return (MulticastDelegate)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Removes an element from the invocation list of this <see cref="T:System.MulticastDelegate" /> that is equal to the specified delegate.</summary>
		/// <returns>If <paramref name="value" /> is found in the invocation list for this instance, then a new <see cref="T:System.Delegate" /> without <paramref name="value" /> in its invocation list; otherwise, this instance with its original invocation list.</returns>
		/// <param name="value">The delegate to search for in the invocation list. </param>
		/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
		protected sealed override Delegate RemoveImpl(Delegate value)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether two <see cref="T:System.MulticastDelegate" /> objects are equal.</summary>
		/// <returns>true if <paramref name="d1" /> and <paramref name="d2" /> have the same invocation lists; otherwise, false.</returns>
		/// <param name="d1">The left operand. </param>
		/// <param name="d2">The right operand. </param>
		/// <exception cref="T:System.MemberAccessException">Cannot create an instance of an abstract class, or this member was invoked with a late-binding mechanism. </exception>
		/// <filterpriority>3</filterpriority>
		public static bool operator ==(MulticastDelegate d1, MulticastDelegate d2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
