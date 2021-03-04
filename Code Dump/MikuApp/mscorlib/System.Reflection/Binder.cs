using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Selects a member from a list of candidates, and performs type conversion from actual argument type to formal argument type. </summary>
	[Serializable]
	[ClassInterface(ClassInterfaceType.AutoDual)]
	public abstract class Binder
	{
		internal sealed class Default : Binder
		{
			public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] names, out object state)
			{
				return (MethodBase)/*Error near IL_0001: Stack underflow*/;
			}

			private void ReorderParameters(string[] names, ref object[] args, MethodBase selected)
			{
			}

			private static bool IsArrayAssignable(Type object_type, Type target_type)
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			public override object ChangeType(object value, Type type, CultureInfo culture)
			{
				return (object)/*Error near IL_0001: Stack underflow*/;
			}

			[MonoTODO("This method does not do anything in Mono")]
			public override void ReorderArgumentArray(ref object[] args, object state)
			{
			}

			private static bool check_type(Type from, Type to)
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			private static bool check_arguments(Type[] types, ParameterInfo[] args, bool allowByRefMatch)
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			public override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers)
			{
				return (MethodBase)/*Error near IL_0001: Stack underflow*/;
			}

			private MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers, bool allowByRefMatch)
			{
				return (MethodBase)/*Error near IL_0001: Stack underflow*/;
			}

			private MethodBase GetBetterMethod(MethodBase m1, MethodBase m2, Type[] types)
			{
				return (MethodBase)/*Error near IL_0001: Stack underflow*/;
			}

			private int CompareCloserType(Type t1, Type t2)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}

			public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers)
			{
				return (PropertyInfo)/*Error near IL_0001: Stack underflow*/;
			}

			private static int check_arguments_with_score(Type[] types, ParameterInfo[] args)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}

			private static int check_type_with_score(Type from, Type to)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
		}

		private static Binder default_binder;

		internal static Binder DefaultBinder => (Binder)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.Binder" /> class.</summary>
		protected Binder()
		{
		}

		/// <summary>Selects a method to invoke from the given set of methods, based on the supplied arguments.</summary>
		/// <returns>The matching method.</returns>
		/// <param name="bindingAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values. </param>
		/// <param name="match">The set of methods that are candidates for matching. For example, when a <see cref="T:System.Reflection.Binder" /> object is used by <see cref="Overload:System.Type.InvokeMember" />, this parameter specifies the set of methods that reflection has determined to be possible matches, typically because they have the correct member name. The default implementation provided by <see cref="P:System.Type.DefaultBinder" /> changes the order of this array.</param>
		/// <param name="args">The arguments that are passed in. The binder can change the order of the arguments in this array; for example, the default binder changes the order of arguments if the <paramref name="names" /> parameter is used to specify an order other than positional order. If a binder implementation coerces argument types, the types and values of the arguments can be changed as well. </param>
		/// <param name="modifiers">An array of parameter modifiers that enable binding to work with parameter signatures in which the types have been modified. The default binder implementation does not use this parameter.</param>
		/// <param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> that is used to control the coercion of data types, in binder implementations that coerce types. If <paramref name="culture" /> is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. Note   For example, if a binder implementation allows coercion of string values to numeric types, this parameter is necessary to convert a String that represents 1000 to a Double value, because 1000 is represented differently by different cultures. The default binder does not do such string coercions.</param>
		/// <param name="names">The parameter names, if parameter names are to be considered when matching, or null if arguments are to be treated as purely positional. For example, parameter names must be used if arguments are not supplied in positional order. </param>
		/// <param name="state">After the method returns, <paramref name="state" /> contains a binder-provided object that keeps track of argument reordering. The binder creates this object, and the binder is the sole consumer of this object. If <paramref name="state" /> is not null when BindToMethod returns, you must pass <paramref name="state" /> to the <see cref="M:System.Reflection.Binder.ReorderArgumentArray(System.Object[]@,System.Object)" /> method if you want to restore <paramref name="args" /> to its original order, for example, so that you can retrieve the values of ref parameters (ByRef parameters in Visual Basic). </param>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">For the default binder, <paramref name="match" /> contains multiple methods that are equally good matches for <paramref name="args" />. For example, <paramref name="args" /> contains a MyClass object that implements the IMyClass interface, and <paramref name="match" /> contains a method that takes MyClass and a method that takes IMyClass. </exception>
		/// <exception cref="T:System.MissingMethodException">For the default binder, <paramref name="match" /> contains no methods that can accept the arguments supplied in <paramref name="args" />.</exception>
		/// <exception cref="T:System.ArgumentException">For the default binder, <paramref name="match" /> is null or an empty array.</exception>
		public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] names, out object state);

		/// <summary>Changes the type of the given Object to the given Type.</summary>
		/// <returns>An object that contains the given value as the new type. </returns>
		/// <param name="value">The object to change into a new Type. </param>
		/// <param name="type">The new Type that <paramref name="value" /> will become. </param>
		/// <param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> that is used to control the coercion of data types. If <paramref name="culture" /> is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used.Note   For example, this parameter is necessary to convert a String that represents 1000 to a Double value, because 1000 is represented differently by different cultures. </param>
		public abstract object ChangeType(object value, Type type, CultureInfo culture);

		/// <summary>Upon returning from <see cref="M:System.Reflection.Binder.BindToMethod(System.Reflection.BindingFlags,System.Reflection.MethodBase[],System.Object[]@,System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[],System.Object@)" />, restores the <paramref name="args" /> argument to what it was when it came from BindToMethod.</summary>
		/// <param name="args">The actual arguments that are passed in. Both the types and values of the arguments can be changed. </param>
		/// <param name="state">A binder-provided object that keeps track of argument reordering. </param>
		public abstract void ReorderArgumentArray(ref object[] args, object state);

		/// <summary>Selects a method from the given set of methods, based on the argument type.</summary>
		/// <returns>The matching method, if found; otherwise, null.</returns>
		/// <param name="bindingAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values. </param>
		/// <param name="match">The set of methods that are candidates for matching. For example, when a <see cref="T:System.Reflection.Binder" /> object is used by <see cref="Overload:System.Type.InvokeMember" />, this parameter specifies the set of methods that reflection has determined to be possible matches, typically because they have the correct member name. The default implementation provided by <see cref="P:System.Type.DefaultBinder" /> changes the order of this array.</param>
		/// <param name="types">The parameter types used to locate a matching method. </param>
		/// <param name="modifiers">An array of parameter modifiers that enable binding to work with parameter signatures in which the types have been modified. </param>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">For the default binder, <paramref name="match" /> contains multiple methods that are equally good matches for the parameter types described by <paramref name="types" />. For example, the array in <paramref name="types" /> contains a <see cref="T:System.Type" /> object for MyClass and the array in <paramref name="match" /> contains a method that takes a base class of MyClass and a method that takes an interface that MyClass implements. </exception>
		/// <exception cref="T:System.ArgumentException">For the default binder, <paramref name="match" /> is null or an empty array.-or-An element of <paramref name="types" /> derives from <see cref="T:System.Type" />, but is not of type RuntimeType.</exception>
		public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers);

		/// <summary>Selects a property from the given set of properties, based on the specified criteria.</summary>
		/// <returns>The matching property.</returns>
		/// <param name="bindingAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values. </param>
		/// <param name="match">The set of properties that are candidates for matching. For example, when a <see cref="T:System.Reflection.Binder" /> object is used by <see cref="Overload:System.Type.InvokeMember" />, this parameter specifies the set of properties that reflection has determined to be possible matches, typically because they have the correct member name. The default implementation provided by <see cref="P:System.Type.DefaultBinder" /> changes the order of this array.</param>
		/// <param name="returnType">The return value the matching property must have. </param>
		/// <param name="indexes">The index types of the property being searched for. Used for index properties such as the indexer for a class. </param>
		/// <param name="modifiers">An array of parameter modifiers that enable binding to work with parameter signatures in which the types have been modified. </param>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">For the default binder, <paramref name="match" /> contains multiple properties that are equally good matches for <paramref name="returnType" /> and <paramref name="indexes" />. </exception>
		/// <exception cref="T:System.ArgumentException">For the default binder, <paramref name="match" /> is null or an empty array. </exception>
		public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers);

		internal static bool ConvertArgs(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		internal static int GetDerivedLevel(Type type)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal static MethodBase FindMostDerivedMatch(MethodBase[] match)
		{
			return (MethodBase)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
