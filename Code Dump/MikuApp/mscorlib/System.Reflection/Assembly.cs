using System.Configuration.Assemblies;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Represents an assembly, which is a reusable, versionable, and self-describing building block of a common language runtime application.</summary>
	[Serializable]
	[ComDefaultInterface(typeof(_Assembly))]
	[ClassInterface(ClassInterfaceType.None)]
	[ComVisible(true)]
	public class Assembly : ICustomAttributeProvider, _Assembly
	{
		internal class ResolveEventHolder
		{
			private ModuleResolveEventHandler ModuleResolve;
		}

		private IntPtr _mono_assembly;

		private ResolveEventHolder resolve_event_holder;

		private bool fromByteArray;

		private string assemblyName;

		/// <summary>Gets the display name of the assembly.</summary>
		/// <returns>The display name of the assembly.</returns>
		public virtual string FullName => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the entry point of this assembly.</summary>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object that represents the entry point of this assembly. If no entry point is found (for example, the assembly is a DLL), null is returned.</returns>
		public virtual MethodInfo EntryPoint
		{
			[MethodImpl(4096)]
			get;
		}

		internal bool FromByteArray
		{
			set
			{
			}
		}

		internal Assembly()
		{
		}

		[MethodImpl(4096)]
		private extern string get_fullname();

		/// <summary>Indicates whether or not a specified attribute has been applied to the assembly.</summary>
		/// <returns>true if the attribute has been applied to the assembly; otherwise, false.</returns>
		/// <param name="attributeType">The <see cref="T:System.Type" /> of the attribute to be checked for this assembly. </param>
		/// <param name="inherit">This argument is ignored for objects of this type. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> uses an invalid type.</exception>
		public virtual bool IsDefined(Type attributeType, bool inherit)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Gets all the custom attributes for this assembly.</summary>
		/// <returns>An array of type Object containing the custom attributes for this assembly.</returns>
		/// <param name="inherit">This argument is ignored for objects of type <see cref="T:System.Reflection.Assembly" />. </param>
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the custom attributes for this assembly as specified by type.</summary>
		/// <returns>An array of type Object containing the custom attributes for this assembly as specified by <paramref name="attributeType" />.</returns>
		/// <param name="attributeType">The <see cref="T:System.Type" /> for which the custom attributes are to be returned. </param>
		/// <param name="inherit">This argument is ignored for objects of type <see cref="T:System.Reflection.Assembly" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="attributeType" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> is not a runtime type. </exception>
		public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the <see cref="T:System.Type" /> object with the specified name in the assembly instance and optionally throws an exception if the type is not found.</summary>
		/// <returns>A <see cref="T:System.Type" /> object that represents the specified class.</returns>
		/// <param name="name">The full name of the type. </param>
		/// <param name="throwOnError">true to throw an exception if the type is not found; false to return null. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> is invalid.-or- The length of <paramref name="name" /> exceeds 1024 characters. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null. </exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="throwOnError" /> is true, and the type cannot be found.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="name" /> requires a dependent assembly that could not be found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">
		///   <paramref name="name" /> requires a dependent assembly that was found but could not be loaded.-or-The current assembly was loaded into the reflection-only context, and <paramref name="name" /> requires a dependent assembly that was not preloaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="name" /> requires a dependent assembly, but the file is not a valid assembly. -or-<paramref name="name" /> requires a dependent assembly which was compiled for a version of the runtime later than the currently loaded version.</exception>
		public virtual Type GetType(string name, bool throwOnError)
		{
			return (Type)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the <see cref="T:System.Type" /> object with the specified name in the assembly instance.</summary>
		/// <returns>A <see cref="T:System.Type" /> object that represents the specified class, or null if the class is not found.</returns>
		/// <param name="name">The full name of the type. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> is invalid. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="name" /> requires a dependent assembly that could not be found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">
		///   <paramref name="name" /> requires a dependent assembly that was found but could not be loaded.-or-The current assembly was loaded into the reflection-only context, and <paramref name="name" /> requires a dependent assembly that was not preloaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="name" /> requires a dependent assembly, but the file is not a valid assembly. -or-<paramref name="name" /> requires a dependent assembly which was compiled for a version of the runtime later than the currently loaded version.</exception>
		public virtual Type GetType(string name)
		{
			return (Type)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		internal extern Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase);

		/// <summary>Gets the <see cref="T:System.Type" /> object with the specified name in the assembly instance, with the options of ignoring the case, and of throwing an exception if the type is not found.</summary>
		/// <returns>A <see cref="T:System.Type" /> object that represents the specified class.</returns>
		/// <param name="name">The full name of the type. </param>
		/// <param name="throwOnError">true to throw an exception if the type is not found; false to return null. </param>
		/// <param name="ignoreCase">true to ignore the case of the type name; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> is invalid.-or- The length of <paramref name="name" /> exceeds 1024 characters. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null. </exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="throwOnError" /> is true, and the type cannot be found.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="name" /> requires a dependent assembly that could not be found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">
		///   <paramref name="name" /> requires a dependent assembly that was found but could not be loaded.-or-The current assembly was loaded into the reflection-only context, and <paramref name="name" /> requires a dependent assembly that was not preloaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="name" /> requires a dependent assembly, but the file is not a valid assembly. -or-<paramref name="name" /> requires a dependent assembly which was compiled for a version of the runtime later than the currently loaded version.</exception>
		public Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			return (Type)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern void FillName(Assembly ass, AssemblyName aname);

		/// <summary>Gets an <see cref="T:System.Reflection.AssemblyName" /> for this assembly, setting the codebase as specified by <paramref name="copiedName" />.</summary>
		/// <returns>An <see cref="T:System.Reflection.AssemblyName" /> for this assembly.</returns>
		/// <param name="copiedName">true to set the <see cref="P:System.Reflection.Assembly.CodeBase" /> to the location of the assembly after it was shadow copied; false to set <see cref="P:System.Reflection.Assembly.CodeBase" /> to the original location. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[MonoTODO("copiedName == true is not supported")]
		public virtual AssemblyName GetName(bool copiedName)
		{
			return (AssemblyName)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets an <see cref="T:System.Reflection.AssemblyName" /> for this assembly.</summary>
		/// <returns>An <see cref="T:System.Reflection.AssemblyName" /> for this assembly.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public virtual AssemblyName GetName()
		{
			return (AssemblyName)/*Error near IL_0001: Stack underflow*/;
		}

		internal virtual AssemblyName UnprotectedGetName()
		{
			return (AssemblyName)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the full name of the assembly, also known as the display name.</summary>
		/// <returns>The full name of the assembly, or the class name if the full name of the assembly cannot be determined.</returns>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern Assembly LoadFrom(string assemblyFile, bool refonly);

		public static Assembly LoadFrom(string assemblyFile, object securityEvidence)
		{
			return (Assembly)/*Error near IL_0001: Stack underflow*/;
		}

		[MonoTODO("This overload is not currently implemented")]
		public static Assembly LoadFrom(string assemblyFile, object securityEvidence, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
		{
			return (Assembly)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Loads an assembly given the long form of its name.</summary>
		/// <returns>The loaded assembly.</returns>
		/// <param name="assemblyString">The long form of the assembly name. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="assemblyString" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="assemblyString" /> is a zero-length string. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="assemblyString" /> is not found. </exception>
		/// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="assemblyString" /> is not a valid assembly. -or-Version 2.0 or later of the common language runtime is currently loaded and <paramref name="assemblyString" /> was compiled with a later version.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public static Assembly Load(string assemblyString)
		{
			return (Assembly)/*Error near IL_0001: Stack underflow*/;
		}

		public static Assembly Load(string assemblyString, object assemblySecurity)
		{
			return (Assembly)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the specified module in this assembly.</summary>
		/// <returns>The module being requested, or null if the module is not found.</returns>
		/// <param name="name">The name of the module being requested. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is an empty string (""). </exception>
		/// <exception cref="T:System.IO.FileLoadException">A file that was found could not be loaded. </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///   <paramref name="name" /> was not found. </exception>
		/// <exception cref="T:System.BadImageFormatException">
		///   <paramref name="name" /> is not a valid assembly. </exception>
		public Module GetModule(string name)
		{
			return (Module)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		internal virtual extern Module[] GetModulesInternal();

		/// <summary>Gets all the modules that are part of this assembly, specifying whether to include resource modules.</summary>
		/// <returns>An array of modules.</returns>
		/// <param name="getResourceModules">true to include resource modules; otherwise, false. </param>
		public Module[] GetModules(bool getResourceModules)
		{
			return (Module[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the assembly that contains the code that is currently executing.</summary>
		/// <returns>A <see cref="T:System.Reflection.Assembly" /> representing the assembly that contains the code that is currently executing. </returns>
		[MethodImpl(4096)]
		public static extern Assembly GetExecutingAssembly();

		/// <summary>Returns the <see cref="T:System.Reflection.Assembly" /> of the method that invoked the currently executing method.</summary>
		/// <returns>The Assembly object of the method that invoked the currently executing method.</returns>
		[MethodImpl(4096)]
		public static extern Assembly GetCallingAssembly();
	}
}
