using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Provides information about methods and constructors. </summary>
	[Serializable]
	[ClassInterface(ClassInterfaceType.None)]
	public abstract class MethodBase : MemberInfo, _MethodBase
	{
		/// <summary>Gets a handle to the internal metadata representation of a method.</summary>
		/// <returns>A <see cref="T:System.RuntimeMethodHandle" /> object.</returns>
		public abstract RuntimeMethodHandle MethodHandle
		{
			get;
		}

		/// <summary>Gets the attributes associated with this method.</summary>
		/// <returns>One of the <see cref="T:System.Reflection.MethodAttributes" /> values.</returns>
		public abstract MethodAttributes Attributes
		{
			get;
		}

		/// <summary>Gets a value indicating the calling conventions for this method.</summary>
		/// <returns>The <see cref="T:System.Reflection.CallingConventions" /> for this method.</returns>
		public virtual CallingConventions CallingConvention => (CallingConventions)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether this is a public method.</summary>
		/// <returns>true if this method is public; otherwise, false.</returns>
		public bool IsPublic => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether the method is static.</summary>
		/// <returns>true if this method is static; otherwise, false.</returns>
		public bool IsStatic => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether the method is virtual.</summary>
		/// <returns>true if this method is virtual; otherwise, false.</returns>
		public bool IsVirtual => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether the generic method contains unassigned generic type parameters.</summary>
		/// <returns>true if the current <see cref="T:System.Reflection.MethodBase" /> object represents a generic method that contains unassigned generic type parameters; otherwise, false.</returns>
		public virtual bool ContainsGenericParameters => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether the method is a generic method definition.</summary>
		/// <returns>true if the current <see cref="T:System.Reflection.MethodBase" /> object represents the definition of a generic method; otherwise, false.</returns>
		public virtual bool IsGenericMethodDefinition => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether the method is generic.</summary>
		/// <returns>true if the current <see cref="T:System.Reflection.MethodBase" /> represents a generic method; otherwise, false.</returns>
		public virtual bool IsGenericMethod => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.MethodBase" /> class.</summary>
		protected MethodBase()
		{
		}

		internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle)
		{
			return (MethodBase)/*Error near IL_0001: Stack underflow*/;
		}

		private static MethodBase GetMethodFromIntPtr(IntPtr handle, IntPtr declaringType)
		{
			return (MethodBase)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets method information by using the method's internal metadata representation (handle).</summary>
		/// <returns>A MethodBase containing information about the method.</returns>
		/// <param name="handle">The method's handle. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="handle" /> is invalid.</exception>
		public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle)
		{
			return (MethodBase)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle);

		/// <summary>When overridden in a derived class, gets the parameters of the specified method or constructor.</summary>
		/// <returns>An array of type ParameterInfo containing information that matches the signature of the method (or constructor) reflected by this MethodBase instance.</returns>
		public abstract ParameterInfo[] GetParameters();

		/// <summary>Invokes the method or constructor represented by the current instance, using the specified parameters.</summary>
		/// <returns>An object containing the return value of the invoked method, or null in the case of a constructor.</returns>
		/// <param name="obj">The object on which to invoke the method or constructor. If a method is static, this argument is ignored. If a constructor is static, this argument must be null or an instance of the class that defines the constructor. </param>
		/// <param name="parameters">An argument list for the invoked method or constructor. This is an array of objects with the same number, order, and type as the parameters of the method or constructor to be invoked. If there are no parameters, <paramref name="parameters" /> should be null.If the method or constructor represented by this instance takes a ref parameter (ByRef in Visual Basic), no special attribute is required for that parameter in order to invoke the method or constructor using this function. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference-type elements, this value is null. For value-type elements, this value is 0, 0.0, or false, depending on the specific element type. </param>
		/// <exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is null and the method is not static.-or- The method is not declared or inherited by the class of <paramref name="obj" />. -or-A static constructor is invoked, and <paramref name="obj" /> is neither null nor an instance of the class that declared the constructor.</exception>
		/// <exception cref="T:System.ArgumentException">The elements of the <paramref name="parameters" /> array do not match the signature of the method or constructor reflected by this instance. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The invoked method or constructor throws an exception. </exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">The <paramref name="parameters" /> array does not have the correct number of arguments. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have permission to execute the constructor. </exception>
		/// <exception cref="T:System.InvalidOperationException">The type that declares the method is an open generic type. That is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns true for the declaring type.</exception>
		/// <exception cref="T:System.NotSupportedException">The current <see cref="T:System.Reflection.MethodBase" /> is a <see cref="T:System.Reflection.Emit.MethodBuilder" />. </exception>
		[DebuggerHidden]
		[DebuggerStepThrough]
		public object Invoke(object obj, object[] parameters)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>When overridden in a derived class, invokes the reflected method or constructor with the given parameters.</summary>
		/// <returns>An Object containing the return value of the invoked method, or null in the case of a constructor, or null if the method's return type is void. Before calling the method or constructor, Invoke checks to see if the user has access permission and verify that the parameters are valid.</returns>
		/// <param name="obj">The object on which to invoke the method or constructor. If a method is static, this argument is ignored. If a constructor is static, this argument must be null or an instance of the class that defines the constructor.</param>
		/// <param name="invokeAttr">A bitmask that is a combination of 0 or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. If <paramref name="binder" /> is null, this parameter is assigned the value <see cref="F:System.Reflection.BindingFlags.Default" />; thus, whatever you pass in is ignored. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects via reflection. If <paramref name="binder" /> is null, the default binder is used. </param>
		/// <param name="parameters">An argument list for the invoked method or constructor. This is an array of objects with the same number, order, and type as the parameters of the method or constructor to be invoked. If there are no parameters, this should be null.If the method or constructor represented by this instance takes a ByRef parameter, there is no special attribute required for that parameter in order to invoke the method or constructor using this function. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference-type elements, this value is null. For value-type elements, this value is 0, 0.0, or false, depending on the specific element type. </param>
		/// <param name="culture">An instance of CultureInfo used to govern the coercion of types. If this is null, the CultureInfo for the current thread is used. (This is necessary to convert a String that represents 1000 to a Double value, for example, since 1000 is represented differently by different cultures.) </param>
		/// <exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is null and the method is not static.-or- The method is not declared or inherited by the class of <paramref name="obj" />. -or-A static constructor is invoked, and <paramref name="obj" /> is neither null nor an instance of the class that declared the constructor.</exception>
		/// <exception cref="T:System.ArgumentException">The type of the <paramref name="parameters" /> parameter does not match the signature of the method or constructor reflected by this instance. </exception>
		/// <exception cref="T:System.Reflection.TargetParameterCountException">The <paramref name="parameters" /> array does not have the correct number of arguments. </exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">The invoked method or constructor throws an exception. </exception>
		/// <exception cref="T:System.MethodAccessException">The caller does not have permission to execute the constructor. </exception>
		/// <exception cref="T:System.InvalidOperationException">The type that declares the method is an open generic type. That is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns true for the declaring type.</exception>
		public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

		/// <summary>Returns an array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic method or the type parameters of a generic method definition.</summary>
		/// <returns>An array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic method or the type parameters of a generic method definition. Returns an empty array if the current method is not a generic method.</returns>
		/// <exception cref="T:System.NotSupportedException">The current object is a <see cref="T:System.Reflection.ConstructorInfo" />. Generic constructors are not supported in the .NET Framework version 2.0. This exception is the default behavior if this method is not overridden in a derived class.</exception>
		[ComVisible(true)]
		public virtual Type[] GetGenericArguments()
		{
			return (Type[])/*Error near IL_0001: Stack underflow*/;
		}
	}
}
