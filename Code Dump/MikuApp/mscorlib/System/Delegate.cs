using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Represents a delegate, which is a data structure that refers to a static method or to a class instance and an instance method of that class.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ClassInterface(ClassInterfaceType.AutoDual)]
	[ComVisible(true)]
	public abstract class Delegate : ICloneable, ISerializable
	{
		private IntPtr method_ptr;

		private IntPtr invoke_impl;

		private object m_target;

		private IntPtr method;

		private IntPtr delegate_trampoline;

		private IntPtr method_code;

		private MethodInfo method_info;

		private MethodInfo original_method_info;

		private DelegateData data;

		/// <summary>Gets the method represented by the delegate.</summary>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> describing the method represented by the delegate.</returns>
		/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception>
		/// <filterpriority>2</filterpriority>
		public MethodInfo Method => (MethodInfo)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the class instance on which the current delegate invokes the instance method.</summary>
		/// <returns>The object on which the current delegate invokes the instance method, if the delegate represents an instance method; null if the delegate represents a static method.</returns>
		/// <filterpriority>2</filterpriority>
		public object Target => (object)/*Error near IL_0001: Stack underflow*/;

		[MethodImpl(4096)]
		internal static extern Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure);

		[MethodImpl(4096)]
		internal extern void SetMulticastInvoke();

		private static bool arg_type_match(Type delArgType, Type argType)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool return_type_match(Type delReturnType, Type returnType)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Creates a delegate of the specified type that represents the specified static or instance method, with the specified first argument and the specified behavior on failure to bind.</summary>
		/// <returns>A delegate of the specified type that represents the specified static or instance method, or null if <paramref name="throwOnBindFailure" /> is false and the delegate cannot be bound to <paramref name="method" />. </returns>
		/// <param name="type">A <see cref="T:System.Type" /> representing the type of delegate to create. </param>
		/// <param name="firstArgument">An <see cref="T:System.Object" /> that is the first argument of the method the delegate represents. For instance methods, it must be compatible with the instance type. </param>
		/// <param name="method">The <see cref="T:System.Reflection.MethodInfo" /> describing the static or instance method the delegate is to represent.</param>
		/// <param name="throwOnBindFailure">true to throw an exception if <paramref name="method" /> cannot be bound; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null.-or- <paramref name="method" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-<paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="method" /> cannot be bound, and <paramref name="throwOnBindFailure" /> is true.-or-<paramref name="method" /> is not a RuntimeMethodInfo. See Runtime Types in Reflection.</exception>
		/// <exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		/// </PermissionSet>
		public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates a delegate of the specified type that represents the specified static or instance method, with the specified first argument.</summary>
		/// <returns>A delegate of the specified type that represents the specified static or instance method. </returns>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="firstArgument">The object to which the delegate is bound, or null to treat <paramref name="method" /> as static (Shared in Visual Basic). </param>
		/// <param name="method">The <see cref="T:System.Reflection.MethodInfo" /> describing the static or instance method the delegate is to represent.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null.-or- <paramref name="method" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-<paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="method" /> cannot be bound.-or-<paramref name="method" /> is not a RuntimeMethodInfo. See Runtime Types in Reflection.</exception>
		/// <exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		/// </PermissionSet>
		public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</summary>
		/// <returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="target">The class instance on which <paramref name="method" /> is invoked. </param>
		/// <param name="method">The name of the instance method that the delegate is to represent. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null.-or- <paramref name="target" /> is null.-or- <paramref name="method" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />. -or-<paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection.-or- <paramref name="method" /> is not an instance method. -or-<paramref name="method" /> cannot be bound, for example because it cannot be found.</exception>
		/// <exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		/// </PermissionSet>
		public static Delegate CreateDelegate(Type type, object target, string method)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure)
		{
			return (MethodInfo)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates a delegate of the specified type that represents the specified static method of the specified class, with the specified case-sensitivity and the specified behavior on failure to bind.</summary>
		/// <returns>A delegate of the specified type that represents the specified static method of the specified class.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="target">The <see cref="T:System.Type" /> representing the class that implements <paramref name="method" />. </param>
		/// <param name="method">The name of the static method that the delegate is to represent. </param>
		/// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method.</param>
		/// <param name="throwOnBindFailure">true to throw an exception if <paramref name="method" /> cannot be bound; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null.-or- <paramref name="target" /> is null.-or- <paramref name="method" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or- <paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="target" /> is not a RuntimeType.-or-<paramref name="target" /> is an open generic type. That is, its <see cref="P:System.Type.ContainsGenericParameters" /> property is true.-or-<paramref name="method" /> is not a static method (Shared method in Visual Basic). -or-<paramref name="method" /> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure" /> is true. </exception>
		/// <exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		/// </PermissionSet>
		public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates a delegate of the specified type that represents the specified static method of the specified class.</summary>
		/// <returns>A delegate of the specified type that represents the specified static method of the specified class.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="target">The <see cref="T:System.Type" /> representing the class that implements <paramref name="method" />. </param>
		/// <param name="method">The name of the static method that the delegate is to represent. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null.-or- <paramref name="target" /> is null.-or- <paramref name="method" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or- <paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection. -or-<paramref name="target" /> is not a RuntimeType.-or-<paramref name="target" /> is an open generic type. That is, its <see cref="P:System.Type.ContainsGenericParameters" /> property is true.-or-<paramref name="method" /> is not a static method (Shared method in Visual Basic). -or-<paramref name="method" /> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure" /> is true.</exception>
		/// <exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		/// </PermissionSet>
		public static Delegate CreateDelegate(Type type, Type target, string method)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance, with the specified case-sensitivity and the specified behavior on failure to bind.</summary>
		/// <returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="target">The class instance on which <paramref name="method" /> is invoked. </param>
		/// <param name="method">The name of the instance method that the delegate is to represent. </param>
		/// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method. </param>
		/// <param name="throwOnBindFailure">true to throw an exception if <paramref name="method" /> cannot be bound; otherwise, false.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null.-or- <paramref name="target" /> is null.-or- <paramref name="method" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-<paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection. -or-  <paramref name="method" /> is not an instance method. -or-<paramref name="method" /> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure" /> is true.</exception>
		/// <exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		/// </PermissionSet>
		public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance with the specified case-sensitivity.</summary>
		/// <returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> of delegate to create. </param>
		/// <param name="target">The class instance on which <paramref name="method" /> is invoked. </param>
		/// <param name="method">The name of the instance method that the delegate is to represent. </param>
		/// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null.-or- <paramref name="target" /> is null.-or- <paramref name="method" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.-or-<paramref name="type" /> is not a RuntimeType. See Runtime Types in Reflection.-or- <paramref name="method" /> is not an instance method. -or-<paramref name="method" /> cannot be bound, for example because it cannot be found.</exception>
		/// <exception cref="T:System.MissingMethodException">The Invoke method of <paramref name="type" /> is not found. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		/// </PermissionSet>
		public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates a shallow copy of the delegate.</summary>
		/// <returns>A shallow copy of the delegate.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual object Clone()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether the specified object and the current delegate are of the same type and share the same targets, methods, and invocation list.</summary>
		/// <returns>true if <paramref name="obj" /> and the current delegate have the same targets, methods, and invocation list; otherwise, false.</returns>
		/// <param name="obj">The object to compare with the current delegate. </param>
		/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception>
		/// <filterpriority>2</filterpriority>
		public override bool Equals(object obj)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns a hash code for the delegate.</summary>
		/// <returns>A hash code for the delegate.</returns>
		/// <filterpriority>2</filterpriority>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Not supported.</summary>
		/// <param name="info">Not supported. </param>
		/// <param name="context">Not supported. </param>
		/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
		/// <filterpriority>2</filterpriority>
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Returns the invocation list of the delegate.</summary>
		/// <returns>An array of delegates representing the invocation list of the current delegate.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual Delegate[] GetInvocationList()
		{
			return (Delegate[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Concatenates the invocation lists of two delegates.</summary>
		/// <returns>A new delegate with an invocation list that concatenates the invocation lists of <paramref name="a" /> and <paramref name="b" /> in that order. Returns <paramref name="a" /> if <paramref name="b" /> is null, returns <paramref name="b" /> if <paramref name="a" /> is a null reference, and returns a null reference if both <paramref name="a" /> and <paramref name="b" /> are null references.</returns>
		/// <param name="a">The delegate whose invocation list comes first. </param>
		/// <param name="b">The delegate whose invocation list comes last. </param>
		/// <exception cref="T:System.ArgumentException">Both <paramref name="a" /> and <paramref name="b" /> are not null, and <paramref name="a" /> and <paramref name="b" /> are not instances of the same delegate type. </exception>
		/// <filterpriority>1</filterpriority>
		public static Delegate Combine(Delegate a, Delegate b)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Concatenates the invocation lists of an array of delegates.</summary>
		/// <returns>A new delegate with an invocation list that concatenates the invocation lists of the delegates in the <paramref name="delegates" /> array. Returns null if <paramref name="delegates" /> is null, if <paramref name="delegates" /> contains zero elements, or if every entry in <paramref name="delegates" /> is null.</returns>
		/// <param name="delegates">The array of delegates to combine. </param>
		/// <exception cref="T:System.ArgumentException">Not all the non-null entries in <paramref name="delegates" /> are instances of the same delegate type. </exception>
		/// <filterpriority>1</filterpriority>
		[ComVisible(true)]
		public static Delegate Combine(params Delegate[] delegates)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Concatenates the invocation lists of the specified multicast (combinable) delegate and the current multicast (combinable) delegate.</summary>
		/// <returns>A new multicast (combinable) delegate with an invocation list that concatenates the invocation list of the current multicast (combinable) delegate and the invocation list of <paramref name="d" />, or the current multicast (combinable) delegate if <paramref name="d" /> is null.</returns>
		/// <param name="d">The multicast (combinable) delegate whose invocation list to append to the end of the invocation list of the current multicast (combinable) delegate. </param>
		/// <exception cref="T:System.MulticastNotSupportedException">Always thrown. </exception>
		protected virtual Delegate CombineImpl(Delegate d)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Removes the last occurrence of the invocation list of a delegate from the invocation list of another delegate.</summary>
		/// <returns>A new delegate with an invocation list formed by taking the invocation list of <paramref name="source" /> and removing the last occurrence of the invocation list of <paramref name="value" />, if the invocation list of <paramref name="value" /> is found within the invocation list of <paramref name="source" />. Returns <paramref name="source" /> if <paramref name="value" /> is null or if the invocation list of <paramref name="value" /> is not found within the invocation list of <paramref name="source" />. Returns a null reference if the invocation list of <paramref name="value" /> is equal to the invocation list of <paramref name="source" /> or if <paramref name="source" /> is a null reference.</returns>
		/// <param name="source">The delegate from which to remove the invocation list of <paramref name="value" />. </param>
		/// <param name="value">The delegate that supplies the invocation list to remove from the invocation list of <paramref name="source" />. </param>
		/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception>
		/// <exception cref="T:System.ArgumentException">The delegate types do not match.</exception>
		/// <filterpriority>1</filterpriority>
		public static Delegate Remove(Delegate source, Delegate value)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Removes the invocation list of a delegate from the invocation list of another delegate.</summary>
		/// <returns>A new delegate with an invocation list formed by taking the invocation list of the current delegate and removing the invocation list of <paramref name="value" />, if the invocation list of <paramref name="value" /> is found within the current delegate's invocation list. Returns the current delegate if <paramref name="value" /> is null or if the invocation list of <paramref name="value" /> is not found within the current delegate's invocation list. Returns null if the invocation list of <paramref name="value" /> is equal to the current delegate's invocation list.</returns>
		/// <param name="d">The delegate that supplies the invocation list to remove from the invocation list of the current delegate. </param>
		/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private). </exception>
		protected virtual Delegate RemoveImpl(Delegate d)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
