using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Discovers the attributes of a method and provides access to method metadata.</summary>
	[Serializable]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_MethodInfo))]
	public abstract class MethodInfo : MethodBase, _MethodInfo
	{
		/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a method.</summary>
		/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a method.</returns>
		public override MemberTypes MemberType => (MemberTypes)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the return type of this method.</summary>
		/// <returns>The return type of this method.</returns>
		public virtual Type ReturnType => (Type)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether the current method is a generic method.</summary>
		/// <returns>true if the current method is a generic method; otherwise, false.</returns>
		public override bool IsGenericMethod => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Reflection.MethodInfo" /> represents the definition of a generic method.</summary>
		/// <returns>true if the <see cref="T:System.Reflection.MethodInfo" /> object represents the definition of a generic method; otherwise, false.</returns>
		public override bool IsGenericMethodDefinition => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether a generic method contains unassigned generic type parameters.</summary>
		/// <returns>true if the current <see cref="T:System.Reflection.MethodInfo" /> contains unassigned generic type parameters; otherwise, false.</returns>
		public override bool ContainsGenericParameters => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.MethodInfo" /> class.</summary>
		protected MethodInfo()
		{
		}

		/// <summary>When overridden in a derived class, returns the MethodInfo object for the method on the direct or indirect base class in which the method represented by this instance was first declared.</summary>
		/// <returns>A MethodInfo object for the first implementation of this method.</returns>
		public abstract MethodInfo GetBaseDefinition();

		/// <summary>Substitutes the elements of an array of types for the type parameters of the current generic method definition, and returns a <see cref="T:System.Reflection.MethodInfo" /> object representing the resulting constructed method.</summary>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object that represents the constructed method formed by substituting the elements of <paramref name="typeArguments" /> for the type parameters of the current generic method definition.</returns>
		/// <param name="typeArguments">An array of types to be substituted for the type parameters of the current generic method definition.</param>
		/// <exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Reflection.MethodInfo" /> does not represent a generic method definition. That is, <see cref="P:System.Reflection.MethodInfo.IsGenericMethodDefinition" /> returns false.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="typeArguments" /> is null.-or- Any element of <paramref name="typeArguments" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">The number of elements in <paramref name="typeArguments" /> is not the same as the number of type parameters of the current generic method definition.-or- An element of <paramref name="typeArguments" /> does not satisfy the constraints specified for the corresponding type parameter of the current generic method definition. </exception>
		/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
		public virtual MethodInfo MakeGenericMethod(params Type[] typeArguments)
		{
			return (MethodInfo)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic method or the type parameters of a generic method definition.</summary>
		/// <returns>An array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic method or the type parameters of a generic method definition. Returns an empty array if the current method is not a generic method.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
		[ComVisible(true)]
		public override Type[] GetGenericArguments()
		{
			return (Type[])/*Error near IL_0001: Stack underflow*/;
		}
	}
}
