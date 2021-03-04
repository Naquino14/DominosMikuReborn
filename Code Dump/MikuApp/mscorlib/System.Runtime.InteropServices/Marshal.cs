using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Threading;

namespace System.Runtime.InteropServices
{
	/// <summary>Provides a collection of methods for allocating unmanaged memory, copying unmanaged memory blocks, and converting managed to unmanaged types, as well as other miscellaneous methods used when interacting with unmanaged code.</summary>
	[SuppressUnmanagedCodeSecurity]
	public static class Marshal
	{
		/// <summary>Represents the maximum size of a double byte character set (DBCS) size, in bytes, for the current operating system. This field is read-only.</summary>
		public static readonly int SystemMaxDBCSCharSize;

		/// <summary>Represents the default character size on the system; the default is 2 for Unicode systems and 1 for ANSI systems. This field is read-only.</summary>
		public static readonly int SystemDefaultCharSize;

		static Marshal()
		{
		}

		[MethodImpl(4096)]
		private static extern int AddRefInternal(IntPtr pUnk);

		/// <summary>Increments the reference count on the specified interface.</summary>
		/// <returns>The new value of the reference count on the <paramref name="pUnk" /> parameter.</returns>
		/// <param name="pUnk">The interface reference count to increment. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static int AddRef(IntPtr pUnk)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Allocates a block of memory of specified size from the COM task memory allocator.</summary>
		/// <returns>An integer representing the address of the block of memory allocated. This memory must be released with <see cref="M:System.Runtime.InteropServices.Marshal.FreeCoTaskMem(System.IntPtr)" />.</returns>
		/// <param name="cb">The size of the block of memory to be allocated. </param>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to satisfy the request. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern IntPtr AllocCoTaskMem(int cb);

		/// <summary>Allocates memory from the process's unmanaged memory.</summary>
		/// <returns>An <see cref="T:System.IntPtr" /> to the newly allocated memory. This memory must be released using the <see cref="M:System.Runtime.InteropServices.Marshal.FreeHGlobal(System.IntPtr)" /> method.</returns>
		/// <param name="cb">The number of bytes in memory required. </param>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to satisfy the request. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static extern IntPtr AllocHGlobal(IntPtr cb);

		/// <summary>Allocates memory from the unmanaged memory of the process.</summary>
		/// <returns>An <see cref="T:System.IntPtr" /> to the newly allocated memory. This memory must be released using the <see cref="M:System.Runtime.InteropServices.Marshal.FreeHGlobal(System.IntPtr)" /> method.</returns>
		/// <param name="cb">The number of bytes in memory required. </param>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to satisfy the request. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public unsafe static IntPtr AllocHGlobal(int cb)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets an interface pointer identified by the specified moniker.</summary>
		/// <returns>An object containing a reference to the interface pointer identified by the <paramref name="monikerName" /> parameter. A moniker is a name, and in this case, the moniker is defined by an interface.</returns>
		/// <param name="monikerName">The moniker corresponding to the desired interface pointer. </param>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">An unrecognized HRESULT was returned by the unmanaged BindToMoniker method. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static object BindToMoniker(string monikerName)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Changes the strength of a COM callable wrapper's (CCW) handle on the object it contains.</summary>
		/// <param name="otp">The object whose COM callable wrapper (CCW) holds a reference counted handle. The handle is strong if the reference count on the CCW is greater than zero; otherwise it is weak. </param>
		/// <param name="fIsWeak">true to change the strength of the handle on the <paramref name="otp" /> parameter to weak, regardless of its reference count; false to reset the handle strength on <paramref name="otp" /> to be reference counted. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static void ChangeWrapperHandleStrength(object otp, bool fIsWeak)
		{
		}

		[MethodImpl(4096)]
		private static extern void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length);

		[MethodImpl(4096)]
		private static extern void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length);

		/// <summary>Copies data from a one-dimensional, managed 8-bit unsigned integer array to an unmanaged memory pointer.</summary>
		/// <param name="source">The one-dimensional array to copy from. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="destination">The memory pointer to copy to. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> and <paramref name="length" /> are not valid. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(byte[] source, int startIndex, IntPtr destination, int length)
		{
		}

		/// <summary>Copies data from a one-dimensional, managed character array to an unmanaged memory pointer.</summary>
		/// <param name="source">The one-dimensional array to copy from. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="destination">The memory pointer to copy to. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> and <paramref name="length" /> are not valid. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(char[] source, int startIndex, IntPtr destination, int length)
		{
		}

		/// <summary>Copies data from a one-dimensional, managed 16-bit signed integer array to an unmanaged memory pointer.</summary>
		/// <param name="source">The one-dimensional array to copy from. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="destination">The memory pointer to copy to. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> and <paramref name="length" /> are not valid. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(short[] source, int startIndex, IntPtr destination, int length)
		{
		}

		/// <summary>Copies data from a one-dimensional, managed 32-bit signed integer array to an unmanaged memory pointer.</summary>
		/// <param name="source">The one-dimensional array to copy from. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="destination">The memory pointer to copy to. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> and <paramref name="length" /> are not valid. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="startIndex" /> or <paramref name="length" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(int[] source, int startIndex, IntPtr destination, int length)
		{
		}

		/// <summary>Copies data from a one-dimensional, managed 64-bit signed integer array to an unmanaged memory pointer.</summary>
		/// <param name="source">The one-dimensional array to copy from. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="destination">The memory pointer to copy to. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> and <paramref name="length" /> are not valid. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(long[] source, int startIndex, IntPtr destination, int length)
		{
		}

		/// <summary>Copies data from a one-dimensional, managed single-precision floating-point number array to an unmanaged memory pointer.</summary>
		/// <param name="source">The one-dimensional array to copy from. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="destination">The memory pointer to copy to. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> and <paramref name="length" /> are not valid. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(float[] source, int startIndex, IntPtr destination, int length)
		{
		}

		/// <summary>Copies data from a one-dimensional, managed double-precision floating-point number array to an unmanaged memory pointer.</summary>
		/// <param name="source">The one-dimensional array to copy from. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="destination">The memory pointer to copy to. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> and <paramref name="length" /> are not valid. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(double[] source, int startIndex, IntPtr destination, int length)
		{
		}

		/// <summary>Copies data from a one-dimensional, managed <see cref="T:System.IntPtr" /> array to an unmanaged memory pointer.</summary>
		/// <param name="source">The one-dimensional array to copy from. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="destination">The memory pointer to copy to. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null. </exception>
		public static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length)
		{
		}

		/// <summary>Copies data from an unmanaged memory pointer to a managed 8-bit unsigned integer array.</summary>
		/// <param name="source">The memory pointer to copy from. </param>
		/// <param name="destination">The array to copy to. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
		{
		}

		/// <summary>Copies data from an unmanaged memory pointer to a managed character array.</summary>
		/// <param name="source">The memory pointer to copy from. </param>
		/// <param name="destination">The array to copy to. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(IntPtr source, char[] destination, int startIndex, int length)
		{
		}

		/// <summary>Copies data from an unmanaged memory pointer to a managed 16-bit signed integer array.</summary>
		/// <param name="source">The memory pointer to copy from. </param>
		/// <param name="destination">The array to copy to. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(IntPtr source, short[] destination, int startIndex, int length)
		{
		}

		/// <summary>Copies data from an unmanaged memory pointer to a managed 32-bit signed integer array.</summary>
		/// <param name="source">The memory pointer to copy from. </param>
		/// <param name="destination">The array to copy to. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(IntPtr source, int[] destination, int startIndex, int length)
		{
		}

		/// <summary>Copies data from an unmanaged memory pointer to a managed 64-bit signed integer array.</summary>
		/// <param name="source">The memory pointer to copy from. </param>
		/// <param name="destination">The array to copy to. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(IntPtr source, long[] destination, int startIndex, int length)
		{
		}

		/// <summary>Copies data from an unmanaged memory pointer to a managed single-precision floating-point number array.</summary>
		/// <param name="source">The memory pointer to copy from. </param>
		/// <param name="destination">The array to copy to. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(IntPtr source, float[] destination, int startIndex, int length)
		{
		}

		/// <summary>Copies data from an unmanaged memory pointer to a managed double-precision floating-point number array.</summary>
		/// <param name="source">The memory pointer to copy from. </param>
		/// <param name="destination">The array to copy to. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void Copy(IntPtr source, double[] destination, int startIndex, int length)
		{
		}

		/// <summary>Copies data from an unmanaged memory pointer to a managed <see cref="T:System.IntPtr" /> array.</summary>
		/// <param name="source">The memory pointer to copy from. </param>
		/// <param name="destination">The array to copy to. </param>
		/// <param name="startIndex">The zero-based index into the array where Copy should start. </param>
		/// <param name="length">The number of array elements to copy. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is null. </exception>
		public static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length)
		{
		}

		/// <summary>Aggregates a managed object with the specified COM object.</summary>
		/// <returns>The inner IUnknown pointer of the managed object.</returns>
		/// <param name="pOuter">The outer IUnknown pointer.</param>
		/// <param name="o">An object to aggregate.</param>
		public unsafe static IntPtr CreateAggregatedObject(IntPtr pOuter, object o)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Wraps the specified COM object in an object of the specified type.</summary>
		/// <returns>The newly wrapped object that is an instance of the desired type.</returns>
		/// <param name="o">The object to be wrapped. </param>
		/// <param name="t">The <see cref="T:System.Type" /> of wrapper to create. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="t" /> must derive from __ComObject. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="t" /> parameter is null.</exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="o" /> cannot be converted to the destination type since it does not support all required interfaces. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static object CreateWrapperOfType(object o, Type t)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Frees all substructures pointed to by the specified unmanaged memory block.</summary>
		/// <param name="ptr">A pointer to an unmanaged block of memory. </param>
		/// <param name="structuretype">Type of a formatted class. This provides the layout information necessary to delete the buffer in the <paramref name="ptr" /> parameter. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="structureType" /> has an automatic layout. Use sequential or explicit instead. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		[ComVisible(true)]
		public static extern void DestroyStructure(IntPtr ptr, Type structuretype);

		/// <summary>Frees a BSTR using SysFreeString.</summary>
		/// <param name="ptr">The address of the BSTR to be freed. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern void FreeBSTR(IntPtr ptr);

		/// <summary>Frees a block of memory allocated by the unmanaged COM task memory allocator with <see cref="M:System.Runtime.InteropServices.Marshal.AllocCoTaskMem(System.Int32)" />.</summary>
		/// <param name="ptr">The address of the memory to be freed. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern void FreeCoTaskMem(IntPtr ptr);

		/// <summary>Frees memory previously allocated from the unmanaged memory of the process with <see cref="M:System.Runtime.InteropServices.Marshal.AllocHGlobal(System.IntPtr)" />.</summary>
		/// <param name="hglobal">The handle returned by the original matching call to <see cref="M:System.Runtime.InteropServices.Marshal.AllocHGlobal(System.IntPtr)" />. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern void FreeHGlobal(IntPtr hglobal);

		private static void ClearBSTR(IntPtr ptr)
		{
		}

		/// <summary>Frees a BSTR pointer that was allocated using the <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToBSTR(System.Security.SecureString)" /> method.</summary>
		/// <param name="s">The address of the BSTR to free.</param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void ZeroFreeBSTR(IntPtr s)
		{
		}

		private static void ClearAnsi(IntPtr ptr)
		{
		}

		private static void ClearUnicode(IntPtr ptr)
		{
		}

		/// <summary>Frees an unmanaged string pointer that was allocated using the <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToCoTaskMemAnsi(System.Security.SecureString)" /> method.</summary>
		/// <param name="s">The address of the unmanaged string to free.</param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void ZeroFreeCoTaskMemAnsi(IntPtr s)
		{
		}

		/// <summary>Frees an unmanaged string pointer that was allocated using the <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToCoTaskMemUnicode(System.Security.SecureString)" /> method.</summary>
		/// <param name="s">The address of the unmanaged string to free.</param>
		public static void ZeroFreeCoTaskMemUnicode(IntPtr s)
		{
		}

		/// <summary>Frees an unmanaged string pointer that was allocated using the <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocAnsi(System.Security.SecureString)" /> method.</summary>
		/// <param name="s">The address of the unmanaged string to free.</param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void ZeroFreeGlobalAllocAnsi(IntPtr s)
		{
		}

		/// <summary>Frees an unmanaged string pointer that was allocated using the <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(System.Security.SecureString)" /> method.</summary>
		/// <param name="s">The address of the unmanaged string to free.</param>
		public static void ZeroFreeGlobalAllocUnicode(IntPtr s)
		{
		}

		/// <summary>Returns the globally unique identifier (GUID) for the specified type, or generates a GUID using the algorithm used by the Type Library Exporter (Tlbexp.exe).</summary>
		/// <returns>A <see cref="T:System.Guid" /> for the specified type.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> to generate a GUID for. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static Guid GenerateGuidForType(Type type)
		{
			return (Guid)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a programmatic identifier (ProgID) for the specified type.</summary>
		/// <returns>The ProgID of the specified type.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> to get a ProgID for. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="type" /> parameter is not a class that can be create by COM. The class must be public, have a public default constructor, and be COM visible. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="type" /> parameter is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static string GenerateProgIdForType(Type type)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Obtains a running instance of the specified object from the Running Object Table (ROT).</summary>
		/// <returns>The object requested. You can cast this object to any COM interface that it supports.</returns>
		/// <param name="progID">The ProgID of the object being requested. </param>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">The object was not found.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static object GetActiveObject(string progID)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern IntPtr GetCCW(object o, Type T);

		private unsafe static IntPtr GetComInterfaceForObjectInternal(object o, Type T)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an interface pointer that represents the specified interface for an object.</summary>
		/// <returns>The interface pointer representing the interface for the object.</returns>
		/// <param name="o">The object providing the interface. </param>
		/// <param name="T">The <see cref="T:System.Type" /> of interface that is requested. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="T" /> parameter is not an interface.-or- The type is not visible to COM. -or-The <paramref name="T" /> parameter is a generic type.</exception>
		/// <exception cref="T:System.InvalidCastException">The <paramref name="o" /> parameter does not support the requested interface. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="o" /> parameter is null-or- The <paramref name="T" /> parameter is null</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public unsafe static IntPtr GetComInterfaceForObject(object o, Type T)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an interface pointer that represents the specified interface for an object, if the caller is in the same context as that object.</summary>
		/// <returns>The interface pointer specified by <paramref name="t" /> that represents the interface for the specified object, or null if the caller is not in the same context as the object.</returns>
		/// <param name="o">The object that provides the interface.</param>
		/// <param name="t">The <see cref="T:System.Type" /> of interface that is requested.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="t" /> is not an interface.-or- The type is not visible to COM. </exception>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="o" /> does not support the requested interface.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="o" /> is null.-or- <paramref name="t" /> is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public unsafe static IntPtr GetComInterfaceForObjectInContext(object o, Type t)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets data referenced by the specified key from the specified COM object.</summary>
		/// <returns>The data represented by the <paramref name="key" /> parameter in the internal hash table of the <paramref name="obj" /> parameter.</returns>
		/// <param name="obj">The COM object containing the desired data. </param>
		/// <param name="key">The key in the internal hash table of <paramref name="obj" /> to retrieve the data from. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="obj" /> is null.-or- <paramref name="key" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="obj" /> is not a COM object. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoNotSupported("MSDN states user code should never need to call this method.")]
		public static object GetComObjectData(object obj, object key)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern int GetComSlotForMethodInfoInternal(MemberInfo m);

		/// <summary>Gets the virtual function table (VTBL) slot for a specified <see cref="T:System.Reflection.MemberInfo" /> when exposed to COM.</summary>
		/// <returns>The VTBL (also called v-table) slot <paramref name="m" /> identifier when it is exposed to COM.</returns>
		/// <param name="m">A <see cref="T:System.Reflection.MemberInfo" /> that represents an interface method. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="m" /> parameter is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="m" /> parameter is not a <see cref="T:System.Reflection.MethodInfo" /> object.-or-The <paramref name="m" /> parameter is not an interface method.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static int GetComSlotForMethodInfo(MemberInfo m)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the last slot in the virtual function table (VTBL) of a type when exposed to COM.</summary>
		/// <returns>The last VTBL (also called v-table) slot of the interface when exposed to COM. If the <paramref name="t" /> parameter is a class, the returned VTBL slot is the last slot in the interface that is generated from the class.</returns>
		/// <param name="t">A <see cref="T:System.Type" /> representing an interface or class. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static int GetEndComSlot(Type t)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves a code that identifies the type of the exception that occurred.</summary>
		/// <returns>The type of the exception.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static int GetExceptionCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves a computer-independent description of an exception, and information about the state that existed for the thread when the exception occurred.</summary>
		/// <returns>An <see cref="T:System.IntPtr" /> to an EXCEPTION_POINTERS structure.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[ComVisible(true)]
		[MonoTODO]
		public unsafe static IntPtr GetExceptionPointers()
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the instance handle (HINSTANCE) for the specified module.</summary>
		/// <returns>The HINSTANCE for <paramref name="m" />; -1 if the module does not have an HINSTANCE.</returns>
		/// <param name="m">The <see cref="T:System.Reflection.Module" /> whose HINSTANCE is desired. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="m" /> parameter is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public unsafe static IntPtr GetHINSTANCE(Module m)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the specified exception to an HRESULT.</summary>
		/// <returns>The HRESULT mapped to the supplied exception.</returns>
		/// <param name="e">The <see cref="T:System.Exception" /> to convert to an HRESULT. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO("SetErrorInfo")]
		public static int GetHRForException(Exception e)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the HRESULT corresponding to the last error incurred by Win32 code executed using <see cref="T:System.Runtime.InteropServices.Marshal" />.</summary>
		/// <returns>The HRESULT corresponding to the last Win32 error code.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int GetHRForLastWin32Error()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern IntPtr GetIDispatchForObjectInternal(object o);

		/// <summary>Returns an IDispatch interface from a managed object.</summary>
		/// <returns>The IDispatch pointer for the <paramref name="o" /> parameter.</returns>
		/// <param name="o">The object whose IDispatch interface is requested. </param>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="o" /> does not support the requested interface. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public unsafe static IntPtr GetIDispatchForObject(object o)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an IDispatch interface pointer from a managed object, if the caller is in the same context as that object.</summary>
		/// <returns>The IDispatch interface pointer for the <paramref name="o" /> parameter, or null if the caller is not in the same context as the specified object.</returns>
		/// <param name="o">The object whose IDispatch interface is requested. </param>
		/// <exception cref="T:System.InvalidCastException">
		///   <paramref name="o" /> does not support the requested interface. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="o" /> is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public unsafe static IntPtr GetIDispatchForObjectInContext(object o)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an ITypeInfo interface from a managed type.</summary>
		/// <returns>The ITypeInfo pointer for the <paramref name="t" /> parameter.</returns>
		/// <param name="t">The <see cref="T:System.Type" /> whose ITypeInfo interface is being requested. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="t" /> is not a visible type to COM. </exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">A type library is registered for the assembly that contains the type, but the type definition cannot be found. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public unsafe static IntPtr GetITypeInfoForType(Type t)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern IntPtr GetIUnknownForObjectInternal(object o);

		/// <summary>Returns an IUnknown interface from a managed object.</summary>
		/// <returns>The IUnknown pointer for the <paramref name="o" /> parameter.</returns>
		/// <param name="o">The object whose IUnknown interface is requested. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public unsafe static IntPtr GetIUnknownForObject(object o)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an IUnknown interface from a managed object, if the caller is in the same context as that object.</summary>
		/// <returns>The IUnknown pointer for the <paramref name="o" /> parameter, or null if the caller is not in the same context as the specified object.</returns>
		/// <param name="o">The object whose IUnknown interface is requested.</param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public unsafe static IntPtr GetIUnknownForObjectInContext(object o)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets a pointer to a thunk that marshals a call from managed to unmanaged code.</summary>
		/// <returns>A pointer to the thunk that will marshal a call from the <paramref name="pfnMethodToWrap" /> parameter.</returns>
		/// <param name="pfnMethodToWrap">A pointer to the method to marshal. </param>
		/// <param name="pbSignature">A pointer to the method signature. </param>
		/// <param name="cbSignature">The number of bytes in <paramref name="pbSignature" />. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		[Obsolete("This method has been deprecated")]
		public unsafe static IntPtr GetManagedThunkForUnmanagedMethodPtr(IntPtr pfnMethodToWrap, IntPtr pbSignature, int cbSignature)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves <see cref="T:System.Reflection.MethodInfo" /> for the specified virtual function table (VTBL) slot.</summary>
		/// <returns>The MemberInfo that represents the member at the specified VTBL (also called v-table) slot.</returns>
		/// <param name="t">The type for which the MethodInfo is to be retrieved. </param>
		/// <param name="slot">The VTBL slot. </param>
		/// <param name="memberType">On successful return, the type of the member. This is one of the <see cref="T:System.Runtime.InteropServices.ComMemberType" /> enumeration members. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="t" /> is not visible from COM. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static MemberInfo GetMethodInfoForComSlot(Type t, int slot, ref ComMemberType memberType)
		{
			return (MemberInfo)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts an object to a COM VARIANT.</summary>
		/// <param name="obj">The object for which to get a COM VARIANT. </param>
		/// <param name="pDstNativeVariant">An <see cref="T:System.IntPtr" /> to receive the VARIANT corresponding to the <paramref name="obj" /> parameter. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="obj" /> parameter is a generic type.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void GetNativeVariantForObject(object obj, IntPtr pDstNativeVariant)
		{
		}

		[MethodImpl(4096)]
		private static extern object GetObjectForCCW(IntPtr pUnk);

		/// <summary>Returns an instance of a type that represents a COM object by a pointer to its IUnknown interface.</summary>
		/// <returns>An object representing the specified unmanaged COM object.</returns>
		/// <param name="pUnk">A pointer to the IUnknown interface. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static object GetObjectForIUnknown(IntPtr pUnk)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a COM VARIANT to an object.</summary>
		/// <returns>An object corresponding to the <paramref name="pSrcNativeVariant" /> parameter.</returns>
		/// <param name="pSrcNativeVariant">An <see cref="T:System.IntPtr" /> containing a COM VARIANT. </param>
		/// <exception cref="T:System.Runtime.InteropServices.InvalidOleVariantTypeException">
		///   <paramref name="pSrcNativeVariant" /> is not a valid VARIANT type. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="pSrcNativeVariant" /> has an unsupported type. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static object GetObjectForNativeVariant(IntPtr pSrcNativeVariant)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts an array of COM VARIANTs to an array of objects.</summary>
		/// <returns>An object array corresponding to <paramref name="aSrcNativeVariant" />.</returns>
		/// <param name="aSrcNativeVariant">An <see cref="T:System.IntPtr" /> containing the first element of an array of COM VARIANTs. </param>
		/// <param name="cVars">The count of COM VARIANTs in <paramref name="aSrcNativeVariant" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="cVars" /> cannot be a negative number. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static object[] GetObjectsForNativeVariants(IntPtr aSrcNativeVariant, int cVars)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the first slot in the virtual function table (VTBL) that contains user defined methods.</summary>
		/// <returns>The first VTBL (also called v-table) slot that contains user defined methods. The first slot is 3 if the interface is IUnknown based, and 7 if the interface is IDispatch based.</returns>
		/// <param name="t">A <see cref="T:System.Type" /> representing an interface. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="t" /> is not visible from COM. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static int GetStartComSlot(Type t)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a fiber cookie into the corresponding <see cref="T:System.Threading.Thread" /> instance.</summary>
		/// <returns>A <see cref="T:System.Threading.Thread" /> corresponding to the <paramref name="cookie" /> parameter.</returns>
		/// <param name="cookie">An integer representing a fiber cookie. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="cookie" /> parameter is 0.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[Obsolete("This method has been deprecated")]
		[MonoTODO]
		public static Thread GetThreadFromFiberCookie(int cookie)
		{
			return (Thread)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a managed object of a specified type that represents a COM object.</summary>
		/// <returns>An instance of the class corresponding to the <see cref="T:System.Type" /> object that represents the requested unmanaged COM object.</returns>
		/// <param name="pUnk">A pointer to the IUnknown interface of the unmanaged object. </param>
		/// <param name="t">The <see cref="T:System.Type" /> of the requested managed class. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="t" /> is not attributed with <see cref="T:System.Runtime.InteropServices.ComImportAttribute" />. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static object GetTypedObjectForIUnknown(IntPtr pUnk, Type t)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts an ITypeInfo into a managed <see cref="T:System.Type" /> object.</summary>
		/// <returns>A managed <see cref="T:System.Type" /> that represents the unmanaged ITypeInfo.</returns>
		/// <param name="piTypeInfo">The ITypeInfo interface to marshal. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		[MonoTODO]
		public static Type GetTypeForITypeInfo(IntPtr piTypeInfo)
		{
			return (Type)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves the name of the type represented by an ITypeInfo.</summary>
		/// <returns>The name of the type pointed to by the <paramref name="pTI" /> parameter.</returns>
		/// <param name="pTI">A <see cref="T:System.Runtime.InteropServices.UCOMITypeInfo" /> that represents an ITypeInfo pointer. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[Obsolete]
		[MonoTODO]
		public static string GetTypeInfoName(UCOMITypeInfo pTI)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves the name of the type represented by an ITypeInfo.</summary>
		/// <returns>The name of the type pointed to by the <paramref name="typeInfo" /> parameter.</returns>
		/// <param name="typeInfo">A <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeInfo" /> object that represents an ITypeInfo pointer. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="typeInfo" /> parameter is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static string GetTypeInfoName(ITypeInfo typeInfo)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves the library identifier (LIBID) of a type library.</summary>
		/// <returns>The LIBID (that is, the <see cref="T:System.Guid" />) of the type library pointed to by the <paramref name="pTLB" /> parameter.</returns>
		/// <param name="pTLB">A <see cref="T:System.Runtime.InteropServices.UCOMITypeLib" /> that represents an ITypeLib pointer. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[Obsolete]
		[MonoTODO]
		public static Guid GetTypeLibGuid(UCOMITypeLib pTLB)
		{
			return (Guid)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves the library identifier (LIBID) of a type library.</summary>
		/// <returns>The LIBID (that is, the <see cref="T:System.Guid" />) of the type library pointed to by the <paramref name="typelib" /> parameter.</returns>
		/// <param name="typelib">An <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeLib" /> object that represents an ITypeLib pointer. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static Guid GetTypeLibGuid(ITypeLib typelib)
		{
			return (Guid)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves the library identifier (LIBID) that is assigned to a type library when it was exported from the specified assembly.</summary>
		/// <returns>The LIBID (that is, the <see cref="T:System.Guid" />) that is assigned to a type library when it is exported from the <paramref name="asm" /> parameter.</returns>
		/// <param name="asm">A managed <see cref="T:System.Reflection.Assembly" />. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static Guid GetTypeLibGuidForAssembly(Assembly asm)
		{
			return (Guid)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves the LCID of a type library.</summary>
		/// <returns>The LCID of the type library pointed to by the <paramref name="pTLB" /> parameter.</returns>
		/// <param name="pTLB">A <see cref="T:System.Runtime.InteropServices.UCOMITypeLib" /> that represents an ITypeLib pointer. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[Obsolete]
		[MonoTODO]
		public static int GetTypeLibLcid(UCOMITypeLib pTLB)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves the LCID of a type library.</summary>
		/// <returns>The LCID of the type library pointed to by the <paramref name="typelib" /> parameter.</returns>
		/// <param name="typelib">A <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeLib" /> object that represents an ITypeLib pointer. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static int GetTypeLibLcid(ITypeLib typelib)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves the name of a type library.</summary>
		/// <returns>The name of the type library pointed to by the <paramref name="pTLB" /> parameter.</returns>
		/// <param name="pTLB">A <see cref="T:System.Runtime.InteropServices.UCOMITypeLib" /> that represents an ITypeLib pointer. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[Obsolete]
		[MonoTODO]
		public static string GetTypeLibName(UCOMITypeLib pTLB)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves the name of a type library.</summary>
		/// <returns>The name of the type library pointed to by the <paramref name="typelib" /> parameter.</returns>
		/// <param name="typelib">An <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeLib" /> object that represents an ITypeLib pointer. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="typelib" /> parameter is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static string GetTypeLibName(ITypeLib typelib)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves the version number of a type library that will be exported from the specified assembly.</summary>
		/// <param name="inputAssembly">A managed <see cref="T:System.Reflection.Assembly" /> object.</param>
		/// <param name="majorVersion">The major version number.</param>
		/// <param name="minorVersion">The minor version number.</param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static void GetTypeLibVersionForAssembly(Assembly inputAssembly, out int majorVersion, out int minorVersion)
		{
		}

		/// <summary>Creates a unique runtime callable wrapper (RCW) object for a given IUnknown.</summary>
		/// <returns>A unique runtime callable wrapper (RCW) for a given IUnknown.</returns>
		/// <param name="unknown">A managed pointer to an IUnknown.</param>
		public static object GetUniqueObjectForIUnknown(IntPtr unknown)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets a pointer to a thunk that marshals a call from unmanaged to managed code.</summary>
		/// <returns>A pointer to the thunk that will marshal a call from <paramref name="pfnMethodToWrap" />.</returns>
		/// <param name="pfnMethodToWrap">A pointer to the method to marshal. </param>
		/// <param name="pbSignature">A pointer to the method signature. </param>
		/// <param name="cbSignature">The number of bytes in <paramref name="pbSignature" />. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		[Obsolete("This method has been deprecated")]
		public unsafe static IntPtr GetUnmanagedThunkForManagedMethodPtr(IntPtr pfnMethodToWrap, IntPtr pbSignature, int cbSignature)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Indicates whether a specified object represents a COM object.</summary>
		/// <returns>true if the <paramref name="o" /> parameter is a COM type; otherwise, false.</returns>
		/// <param name="o">The object to check. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern bool IsComObject(object o);

		/// <summary>Indicates whether a type is visible to COM clients.</summary>
		/// <returns>true if the type is visible to COM; otherwise, false.</returns>
		/// <param name="t">The <see cref="T:System.Type" /> to check for COM visibility. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static bool IsTypeVisibleFromCom(Type t)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Calculates the number of bytes in unmanaged memory that are required to hold the parameters for the specified method.</summary>
		/// <returns>The number of bytes required to represent the method parameters in unmanaged memory.</returns>
		/// <param name="m">A <see cref="T:System.Reflection.MethodInfo" /> that identifies the method to be checked. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="m" /> parameter is null. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="m" /> parameter is not a <see cref="T:System.Reflection.MethodInfo" /> object.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static int NumParamBytes(MethodInfo m)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the error code returned by the last unmanaged function called using platform invoke that has the <see cref="F:System.Runtime.InteropServices.DllImportAttribute.SetLastError" /> flag set.</summary>
		/// <returns>The last error code set by a call to the Win32 SetLastError API method.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern int GetLastWin32Error();

		/// <summary>Returns the field offset of the unmanaged form of the managed class.</summary>
		/// <returns>The offset, in bytes, for the <paramref name="fieldName" /> parameter within the platform invoke declared class <paramref name="t" />.</returns>
		/// <param name="t">A <see cref="T:System.Type" />, specifying the specified class. You must apply the <see cref="T:System.Runtime.InteropServices.StructLayoutAttribute" /> to the class. </param>
		/// <param name="fieldName">The field within the <paramref name="t" /> parameter. </param>
		/// <exception cref="T:System.ArgumentException">The class cannot be exported as a structure or the field is nonpublic. Beginning with the .NET Framework version 2.0, the field may be private.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="t" /> parameter is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern IntPtr OffsetOf(Type t, string fieldName);

		/// <summary>Executes one-time method setup tasks without calling the method.</summary>
		/// <param name="m">A <see cref="T:System.Reflection.MethodInfo" /> that identifies the method to be checked. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="m" /> parameter is null.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="m" /> parameter is not a <see cref="T:System.Reflection.MethodInfo" /> object.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern void Prelink(MethodInfo m);

		/// <summary>Performs a pre-link check for all methods on a class.</summary>
		/// <param name="c">A <see cref="T:System.Type" /> that identifies the class whose methods are to be checked. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="c" /> parameter is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern void PrelinkAll(Type c);

		/// <summary>Copies all characters up to the first null from an unmanaged ANSI string to a managed <see cref="T:System.String" />. Widens each ANSI character to Unicode.</summary>
		/// <returns>A managed <see cref="T:System.String" /> object that holds a copy of the unmanaged ANSI string. If <paramref name="ptr" /> is null, the method returns a null string.</returns>
		/// <param name="ptr">The address of the first character of the unmanaged string. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern string PtrToStringAnsi(IntPtr ptr);

		/// <summary>Allocates a managed <see cref="T:System.String" />, copies a specified number of characters from an unmanaged ANSI string into it, and widens each ANSI character to Unicode.</summary>
		/// <returns>A managed <see cref="T:System.String" /> that holds a copy of the native ANSI string if the value of the <paramref name="ptr" /> parameter is not null; otherwise, this method returns null.</returns>
		/// <param name="ptr">The address of the first character of the unmanaged string. </param>
		/// <param name="len">The byte count of the input string to copy. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="len" /> is less than zero. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern string PtrToStringAnsi(IntPtr ptr, int len);

		/// <summary>Allocates a managed <see cref="T:System.String" /> and copies all characters up to the first null character from a string stored in unmanaged memory into it.</summary>
		/// <returns>A managed string that holds a copy of the unmanaged string if the value of the <paramref name="ptr" /> parameter is not null; otherwise, this method returns null.</returns>
		/// <param name="ptr">For Unicode platforms, the address of the first Unicode character.-or- For ANSI plaforms, the address of the first ANSI character. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static string PtrToStringAuto(IntPtr ptr)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies a specified number of characters from a string stored in unmanaged memory to a managed <see cref="T:System.String" />.</summary>
		/// <returns>A managed string that holds a copy of the native string if the value of the <paramref name="ptr" /> parameter is not null; otherwise, this method returns null.</returns>
		/// <param name="ptr">For Unicode platforms, the address of the first Unicode character.-or- For ANSI plaforms, the address of the first ANSI character. </param>
		/// <param name="len">The number of characters to copy. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="len" /> is less than zero. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static string PtrToStringAuto(IntPtr ptr, int len)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Allocates a managed <see cref="T:System.String" /> and copies all characters up to the first null character from an unmanaged Unicode string into it.</summary>
		/// <returns>A managed string holding a copy of the native string if the value of the <paramref name="ptr" /> parameter is not null; otherwise, this method returns null.</returns>
		/// <param name="ptr">The address of the first character of the unmanaged string. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern string PtrToStringUni(IntPtr ptr);

		/// <summary>Copies a specified number of characters from a Unicode string stored in native heap to a managed <see cref="T:System.String" />.</summary>
		/// <returns>A managed string that holds a copy of the native string if the value of the <paramref name="ptr" /> parameter is not null; otherwise, this method returns null.</returns>
		/// <param name="ptr">The address of the first character of the unmanaged string. </param>
		/// <param name="len">The number of Unicode characters to copy. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern string PtrToStringUni(IntPtr ptr, int len);

		/// <summary>Allocates a managed <see cref="T:System.String" /> and copies a BSTR string stored in unmanaged memory into it.</summary>
		/// <returns>A managed string that holds a copy of the native string if the value of the <paramref name="ptr" /> parameter is not null; otherwise, this method returns null.</returns>
		/// <param name="ptr">The address of the first character of the unmanaged string. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern string PtrToStringBSTR(IntPtr ptr);

		/// <summary>Marshals data from an unmanaged block of memory to a managed object.</summary>
		/// <param name="ptr">A pointer to an unmanaged block of memory. </param>
		/// <param name="structure">The object to which the data is to be copied. This must be an instance of a formatted class. </param>
		/// <exception cref="T:System.ArgumentException">Structure layout is not sequential or explicit.-or- Structure is a boxed value type. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		[ComVisible(true)]
		public static extern void PtrToStructure(IntPtr ptr, object structure);

		/// <summary>Marshals data from an unmanaged block of memory to a newly allocated managed object of the specified type.</summary>
		/// <returns>A managed object containing the data pointed to by the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">A pointer to an unmanaged block of memory. </param>
		/// <param name="structureType">The <see cref="T:System.Type" /> of object to be created. This type object must represent a formatted class or a structure. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="structureType" /> parameter layout is not sequential or explicit. -or-The <paramref name="structureType" /> parameter is a generic type.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="structureType" /> is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		[ComVisible(true)]
		public static extern object PtrToStructure(IntPtr ptr, Type structureType);

		[MethodImpl(4096)]
		private static extern int QueryInterfaceInternal(IntPtr pUnk, ref Guid iid, out IntPtr ppv);

		/// <summary>Requests a pointer to a specified interface from a COM object.</summary>
		/// <returns>An HRESULT that indicates the success or failure of the call.</returns>
		/// <param name="pUnk">The interface to be queried. </param>
		/// <param name="iid">A <see cref="T:System.Guid" />, passed by reference, that is the interface identifier (IID) of the requested interface. </param>
		/// <param name="ppv">When this method returns, contains a reference to the returned interface. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static int QueryInterface(IntPtr pUnk, ref Guid iid, out IntPtr ppv)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reads a single byte from an unmanaged pointer.</summary>
		/// <returns>The byte read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The address in unmanaged memory from which to read. </param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> is not a recognized format. -or-<paramref name="ptr" /> is null. -or-<paramref name="ptr" /> is invalid.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static byte ReadByte(IntPtr ptr)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reads a single byte at a given offset (or index) from an unmanaged pointer.</summary>
		/// <returns>The byte read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The base address in unmanaged memory from which to read. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before reading. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern byte ReadByte(IntPtr ptr, int ofs);

		/// <summary>Reads a single byte from an unmanaged pointer.</summary>
		/// <returns>The byte read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The base address in unmanaged memory of the source object. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before reading. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static byte ReadByte([In][MarshalAs(40)] object ptr, int ofs)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reads a 16-bit signed integer from the unmanaged memory.</summary>
		/// <returns>The 16-bit signed integer read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The address in unmanaged memory from which to read. </param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> is not a recognized format. -or-<paramref name="ptr" /> is null.-or-<paramref name="ptr" /> is invalid.  </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static short ReadInt16(IntPtr ptr)
		{
			return (short)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reads a 16-bit signed integer from unmanaged memory.</summary>
		/// <returns>The 16-bit signed integer read from <paramref name="ptr" />.</returns>
		/// <param name="ptr">The base address in unmanaged memory from which to read.</param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before reading.</param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern short ReadInt16(IntPtr ptr, int ofs);

		/// <summary>Reads a 16-bit signed integer from unmanaged memory.</summary>
		/// <returns>The 16-bit signed integer read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The base address in unmanaged memory of the source object. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before reading. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static short ReadInt16([In][MarshalAs(40)] object ptr, int ofs)
		{
			return (short)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reads a 32-bit signed integer from unmanaged memory.</summary>
		/// <returns>The 32-bit signed integer read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The address in unmanaged from which to read. </param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> is not a recognized format. -or-<paramref name="ptr" /> is null.  -or-<paramref name="ptr" /> is invalid.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int ReadInt32(IntPtr ptr)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reads a 32-bit signed integer from unmanaged memory.</summary>
		/// <returns>The 32-bit signed integer read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The base address in unmanaged memory from which to read. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before reading. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern int ReadInt32(IntPtr ptr, int ofs);

		/// <summary>Reads a 32-bit signed integer from unmanaged memory.</summary>
		/// <returns>The 32-bit signed integer read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The base address in unmanaged memory of the source object. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before reading. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int ReadInt32([In][MarshalAs(40)] object ptr, int ofs)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reads a 64-bit signed integer from unmanaged memory.</summary>
		/// <returns>The 64-bit signed integer read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The address in unmanaged memory from which to read. </param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> is not a recognized format. -or-<paramref name="ptr" /> is null.  -or-<paramref name="ptr" /> is invalid.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static long ReadInt64(IntPtr ptr)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reads a 64-bit signed integer from unmanaged memory.</summary>
		/// <returns>The 64-bit signed integer read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The base address in unmanaged memory from which to read. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before reading. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern long ReadInt64(IntPtr ptr, int ofs);

		/// <summary>Reads a 64-bit signed integer from unmanaged memory.</summary>
		/// <returns>The 64-bit signed integer read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The base address in unmanaged memory of the source object. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before reading. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static long ReadInt64([In][MarshalAs(40)] object ptr, int ofs)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reads a processor native sized integer from unmanaged memory.</summary>
		/// <returns>The IntPtr read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The address in unmanaged memory from which to read. </param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> is not a recognized format. -or-<paramref name="ptr" /> is null. -or-<paramref name="ptr" /> is invalid. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public unsafe static IntPtr ReadIntPtr(IntPtr ptr)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Reads a processor native sized integer from unmanaged memory.</summary>
		/// <returns>The IntPtr read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The base address in unmanaged memory from which to read. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before reading. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern IntPtr ReadIntPtr(IntPtr ptr, int ofs);

		/// <summary>Reads a processor native sized integer from unmanaged memory.</summary>
		/// <returns>The IntPtr read from the <paramref name="ptr" /> parameter.</returns>
		/// <param name="ptr">The base address in unmanaged memory of the source object. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before reading. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public unsafe static IntPtr ReadIntPtr([In][MarshalAs(40)] object ptr, int ofs)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Resizes a block of memory previously allocated with <see cref="M:System.Runtime.InteropServices.Marshal.AllocCoTaskMem(System.Int32)" />.</summary>
		/// <returns>An integer representing the address of the block of memory reallocated. This memory must be released with <see cref="M:System.Runtime.InteropServices.Marshal.FreeCoTaskMem(System.IntPtr)" />.</returns>
		/// <param name="pv">A pointer to memory allocated with <see cref="M:System.Runtime.InteropServices.Marshal.AllocCoTaskMem(System.Int32)" />. </param>
		/// <param name="cb">The new size of the allocated block. </param>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to satisfy the request. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern IntPtr ReAllocCoTaskMem(IntPtr pv, int cb);

		/// <summary>Resizes a block of memory previously allocated with <see cref="M:System.Runtime.InteropServices.Marshal.AllocHGlobal(System.IntPtr)" />.</summary>
		/// <returns>An <see cref="T:System.IntPtr" /> to the reallocated memory. This memory must be released using <see cref="M:System.Runtime.InteropServices.Marshal.FreeHGlobal(System.IntPtr)" />.</returns>
		/// <param name="pv">A pointer to memory allocated with <see cref="M:System.Runtime.InteropServices.Marshal.AllocHGlobal(System.IntPtr)" />. </param>
		/// <param name="cb">The new size of the allocated block. This is not a pointer; it is the byte count you are requesting, cast to type <see cref="T:System.IntPtr" />. If you pass a pointer, it is treated as a size.</param>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to satisfy the request. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern IntPtr ReAllocHGlobal(IntPtr pv, IntPtr cb);

		[MethodImpl(4096)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		private static extern int ReleaseInternal(IntPtr pUnk);

		/// <summary>Decrements the reference count on the specified interface.</summary>
		/// <returns>The new value of the reference count on the interface specified by the <paramref name="pUnk" /> parameter.</returns>
		/// <param name="pUnk">The interface to release. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int Release(IntPtr pUnk)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern int ReleaseComObjectInternal(object co);

		/// <summary>Decrements the reference count of the supplied runtime callable wrapper.</summary>
		/// <returns>The new value of the reference count of the runtime callable wrapper associated with <paramref name="o" />. This value is typically zero since the runtime callable wrapper keeps just one reference to the wrapped COM object regardless of the number of managed clients calling it.</returns>
		/// <param name="o">The COM object to release. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="o" /> is not a valid COM object.</exception>
		/// <exception cref="T:System.NullReferenceException">
		///   <paramref name="o" /> is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static int ReleaseComObject(object o)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Releases the thread cache.</summary>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		[Obsolete]
		public static void ReleaseThreadCache()
		{
		}

		/// <summary>Sets data referenced by the specified key in the specified COM object.</summary>
		/// <returns>true if the data was set successfully; otherwise, false.</returns>
		/// <param name="obj">The COM object in which to store the data. </param>
		/// <param name="key">The key in the internal hash table of the COM object in which to store the data. </param>
		/// <param name="data">The data to set. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="obj" /> is null.-or- <paramref name="key" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="obj" /> is not a COM object. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoNotSupported("MSDN states user code should never need to call this method.")]
		public static bool SetComObjectData(object obj, object key, object data)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns the unmanaged size of an object in bytes.</summary>
		/// <returns>The size of the <paramref name="structure" /> parameter in unmanaged code.</returns>
		/// <param name="structure">The object whose size is to be returned. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="structure" /> parameter is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[ComVisible(true)]
		public static int SizeOf(object structure)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the size of an unmanaged type in bytes.</summary>
		/// <returns>The size of the <paramref name="structure" /> parameter in unmanaged code.</returns>
		/// <param name="t">The <see cref="T:System.Type" /> whose size is to be returned. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="t" /> parameter is a generic type.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="t" /> parameter is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern int SizeOf(Type t);

		/// <summary>Allocates a BSTR and copies the contents of a managed <see cref="T:System.String" /> into it.</summary>
		/// <returns>An unmanaged pointer to the BSTR, or 0 if a null string was supplied.</returns>
		/// <param name="s">The managed string to be copied. </param>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length for <paramref name="s" /> is out of range.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern IntPtr StringToBSTR(string s);

		/// <summary>Copies the contents of a managed <see cref="T:System.String" /> to a block of memory allocated from the unmanaged COM task allocator.</summary>
		/// <returns>An integer representing a pointer to the block of memory allocated for the string, or 0 if a null string was supplied.</returns>
		/// <param name="s">A managed string to be copied. </param>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="s" /> parameter exceeds the maximum length allowed by the operating system.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public unsafe static IntPtr StringToCoTaskMemAnsi(string s)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies the contents of a managed <see cref="T:System.String" /> to a block of memory allocated from the unmanaged COM task allocator.</summary>
		/// <returns>The allocated memory block, or 0 if a null string was supplied.</returns>
		/// <param name="s">A managed string to be copied. </param>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length for <paramref name="s" /> is out of range.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public unsafe static IntPtr StringToCoTaskMemAuto(string s)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies the contents of a managed <see cref="T:System.String" /> to a block of memory allocated from the unmanaged COM task allocator.</summary>
		/// <returns>An integer representing a pointer to the block of memory allocated for the string, or 0 if a null string was supplied.</returns>
		/// <param name="s">A managed string to be copied. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="s" /> parameter exceeds the maximum length allowed by the operating system.</exception>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public unsafe static IntPtr StringToCoTaskMemUni(string s)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies the contents of a managed <see cref="T:System.String" /> into unmanaged memory, converting into ANSI format as it copies.</summary>
		/// <returns>The address, in unmanaged memory, to where <paramref name="s" /> was copied, or 0 if a null string was supplied.</returns>
		/// <param name="s">A managed string to be copied. </param>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="s" /> parameter exceeds the maximum length allowed by the operating system.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern IntPtr StringToHGlobalAnsi(string s);

		/// <summary>Copies the contents of a managed <see cref="T:System.String" /> into unmanaged memory, converting into ANSI format if required.</summary>
		/// <returns>The address, in unmanaged memory, to where the string was copied, or 0 if a null string was supplied.</returns>
		/// <param name="s">A managed string to be copied. </param>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public unsafe static IntPtr StringToHGlobalAuto(string s)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies the contents of a managed <see cref="T:System.String" /> into unmanaged memory.</summary>
		/// <returns>The address, in unmanaged memory, to where the <paramref name="s" /> was copied, or 0 if a null string was supplied.</returns>
		/// <param name="s">A managed string to be copied. </param>
		/// <exception cref="T:System.OutOfMemoryException">The method could not allocate enough native heap memory. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="s" /> parameter exceeds the maximum length allowed by the operating system.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern IntPtr StringToHGlobalUni(string s);

		/// <summary>Allocates a BSTR and copies the contents of a managed <see cref="T:System.Security.SecureString" /> object into it.</summary>
		/// <returns>The address, in unmanaged memory, where the <paramref name="s" /> parameter was copied to, or 0 if a null <see cref="T:System.Security.SecureString" /> object was supplied.</returns>
		/// <param name="s">The managed <see cref="T:System.Security.SecureString" /> object to be copied.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null.</exception>
		/// <exception cref="T:System.NotSupportedException">The current computer is not running Windows 2000 Service Pack 3 or later.  </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public unsafe static IntPtr SecureStringToBSTR(SecureString s)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies the contents of a managed <see cref="T:System.Security.SecureString" /> object to a block of memory allocated from the unmanaged COM task allocator.</summary>
		/// <returns>The address, in unmanaged memory, where the <paramref name="s" /> parameter was copied to, or 0 if a null <see cref="T:System.Security.SecureString" /> object was supplied.</returns>
		/// <param name="s">The managed <see cref="T:System.Security.SecureString" /> object to copy.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null.</exception>
		/// <exception cref="T:System.NotSupportedException">The current computer is not running Windows 2000 Service Pack 3 or later.  </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public unsafe static IntPtr SecureStringToCoTaskMemAnsi(SecureString s)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies the contents of a managed <see cref="T:System.Security.SecureString" /> object to a block of memory allocated from the unmanaged COM task allocator.</summary>
		/// <returns>The address, in unmanaged memory, where the <paramref name="s" /> parameter was copied to, or 0 if a null <see cref="T:System.Security.SecureString" /> object was supplied.</returns>
		/// <param name="s">The managed <see cref="T:System.Security.SecureString" /> object to copy.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null.</exception>
		/// <exception cref="T:System.NotSupportedException">The current computer is not running Windows 2000 Service Pack 3 or later.  </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available. </exception>
		public unsafe static IntPtr SecureStringToCoTaskMemUnicode(SecureString s)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies the contents of a managed <see cref="T:System.Security.SecureString" /> into unmanaged memory, converting into ANSI format as it copies.</summary>
		/// <returns>The address, in unmanaged memory, to where the <paramref name="s" /> parameter was copied, or 0 if a null <see cref="T:System.Security.SecureString" /> was supplied.</returns>
		/// <param name="s">The managed <see cref="T:System.Security.SecureString" /> to be copied.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null.</exception>
		/// <exception cref="T:System.NotSupportedException">The current computer is not running Windows 2000 Service Pack 3 or later.  </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public unsafe static IntPtr SecureStringToGlobalAllocAnsi(SecureString s)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies the contents of a managed <see cref="T:System.Security.SecureString" /> object into unmanaged memory.</summary>
		/// <returns>The address, in unmanaged memory, where <paramref name="s" /> was copied, or 0 if <paramref name="s" /> is a <see cref="T:System.Security.SecureString" /> object whose length is 0.</returns>
		/// <param name="s">The managed object to be copied.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is null.</exception>
		/// <exception cref="T:System.NotSupportedException">The current computer is not running Windows 2000 Service Pack 3 or later.  </exception>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available. </exception>
		public unsafe static IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Marshals data from a managed object to an unmanaged block of memory.</summary>
		/// <param name="structure">A managed object holding the data to be marshaled. This object must be an instance of a formatted class. </param>
		/// <param name="ptr">A pointer to an unmanaged block of memory, which must be allocated before this method is called. </param>
		/// <param name="fDeleteOld">true to have the <see cref="M:System.Runtime.InteropServices.Marshal.DestroyStructure(System.IntPtr,System.Type)" /> method called on the <paramref name="ptr" /> parameter before this method executes. Note that passing false can lead to a memory leak. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="structure" /> parameter is a generic type.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		[ComVisible(true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static extern void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld);

		/// <summary>Throws an exception with a specific failure HRESULT value.</summary>
		/// <param name="errorCode">The HRESULT corresponding to the desired exception. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void ThrowExceptionForHR(int errorCode)
		{
		}

		/// <summary>Throws an exception with a specific failure HRESULT.</summary>
		/// <param name="errorCode">The HRESULT corresponding to the desired exception. </param>
		/// <param name="errorInfo">A pointer to the IErrorInfo interface that provides more information about the error. You can specify IntPtr(0) to use the current IErrorInfo interface, or IntPtr(-1) to ignore the current IErrorInfo interface and construct the exception just from the error code.</param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void ThrowExceptionForHR(int errorCode, IntPtr errorInfo)
		{
		}

		/// <summary>Gets the address of the element at the specified index inside the specified array.</summary>
		/// <returns>The address of <paramref name="index" /> inside <paramref name="arr" />.</returns>
		/// <param name="arr">The <see cref="T:System.Array" /> containing the desired element. </param>
		/// <param name="index">The index in the <paramref name="arr" /> parameter of the desired element. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index);

		/// <summary>Writes a single byte value to unmanaged memory.</summary>
		/// <param name="ptr">The address in unmanaged to write. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> is not a recognized format. -or-<paramref name="ptr" /> is null.-or-<paramref name="ptr" /> is invalid.  </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void WriteByte(IntPtr ptr, byte val)
		{
		}

		/// <summary>Writes a single byte value to unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory to write. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before writing. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern void WriteByte(IntPtr ptr, int ofs, byte val);

		/// <summary>Writes a single byte value to unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory of the target object. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before writing. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static void WriteByte([In][Out][MarshalAs(40)] object ptr, int ofs, byte val)
		{
		}

		/// <summary>Writes a 16-bit integer value to unmanaged memory.</summary>
		/// <param name="ptr">The address in unmanaged memory to write. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> is not a recognized format. -or-<paramref name="ptr" /> is null. -or-<paramref name="ptr" /> is invalid. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void WriteInt16(IntPtr ptr, short val)
		{
		}

		/// <summary>Writes a 16-bit signed integer value into unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory to write. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before writing. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern void WriteInt16(IntPtr ptr, int ofs, short val);

		/// <summary>Writes a 16-bit signed integer value to unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory of the target object. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before writing. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static void WriteInt16([In][Out][MarshalAs(40)] object ptr, int ofs, short val)
		{
		}

		/// <summary>Writes a 16-bit signed integer value to unmanaged memory.</summary>
		/// <param name="ptr">The address in unmanaged memory to write. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> is not a recognized format. -or-<paramref name="ptr" /> is null.-or-<paramref name="ptr" /> is invalid.  </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void WriteInt16(IntPtr ptr, char val)
		{
		}

		/// <summary>Writes a 16-bit signed integer value to unmanaged memory.</summary>
		/// <param name="ptr">The base address in the native heap to write. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before writing. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		[MonoTODO]
		public static extern void WriteInt16(IntPtr ptr, int ofs, char val);

		/// <summary>Writes a 16-bit signed integer value to unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory of the target object. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before writing. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static void WriteInt16([In][Out] object ptr, int ofs, char val)
		{
		}

		/// <summary>Writes a 32-bit signed integer value to unmanaged memory.</summary>
		/// <param name="ptr">The address in unmanaged memory to write. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> is not a recognized format. -or-<paramref name="ptr" /> is null. -or-<paramref name="ptr" /> is invalid. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void WriteInt32(IntPtr ptr, int val)
		{
		}

		/// <summary>Writes a 32-bit signed integer value into unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory to write. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before writing. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern void WriteInt32(IntPtr ptr, int ofs, int val);

		/// <summary>Writes a 32-bit signed integer value to unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory of the target object. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before writing. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static void WriteInt32([In][Out][MarshalAs(40)] object ptr, int ofs, int val)
		{
		}

		/// <summary>Writes a 64-bit signed integer value to unmanaged memory.</summary>
		/// <param name="ptr">The address in unmanaged memory to write. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> is not a recognized format. -or-<paramref name="ptr" /> is null.  -or-<paramref name="ptr" /> is invalid.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void WriteInt64(IntPtr ptr, long val)
		{
		}

		/// <summary>Writes a 64-bit signed integer value to unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory to write. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before writing. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern void WriteInt64(IntPtr ptr, int ofs, long val);

		/// <summary>Writes a 64-bit signed integer value to unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory of the target object. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before writing. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static void WriteInt64([In][Out][MarshalAs(40)] object ptr, int ofs, long val)
		{
		}

		/// <summary>Writes a processor native sized integer value into unmanaged memory.</summary>
		/// <param name="ptr">The address in unmanaged memory to write. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">
		///   <paramref name="ptr" /> is not a recognized format. -or-<paramref name="ptr" /> is null.  -or-<paramref name="ptr" /> is invalid.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static void WriteIntPtr(IntPtr ptr, IntPtr val)
		{
		}

		/// <summary>Writes a processor native sized integer value to unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory to write. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before writing. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern void WriteIntPtr(IntPtr ptr, int ofs, IntPtr val);

		/// <summary>Writes a processor native sized integer value to unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory of the target object. </param>
		/// <param name="ofs">An additional byte offset, added to the <paramref name="ptr" /> parameter before writing. </param>
		/// <param name="val">The value to write. </param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="ptr" /> is an <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> object. This method does not accept <see cref="T:System.Runtime.InteropServices.ArrayWithOffset" /> parameters.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MonoTODO]
		public static void WriteIntPtr([In][Out][MarshalAs(40)] object ptr, int ofs, IntPtr val)
		{
		}

		/// <summary>Converts the specified HRESULT error code to a corresponding <see cref="T:System.Exception" /> object.</summary>
		/// <returns>An <see cref="T:System.Exception" /> object representing the converted HRESULT.</returns>
		/// <param name="errorCode">The HRESULT to be converted.</param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static Exception GetExceptionForHR(int errorCode)
		{
			return (Exception)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the specified HRESULT error code to a corresponding <see cref="T:System.Exception" /> object, with additional error information passed in an IErrorInfo interface for the exception object.</summary>
		/// <returns>An <see cref="T:System.Exception" /> object representing the converted HRESULT and information obtained from <paramref name="errorInfo" />.</returns>
		/// <param name="errorCode">The HRESULT to be converted.</param>
		/// <param name="errorInfo">A pointer to the IErrorInfo interface that provides more information about the error. You can specify IntPtr(0) to use the current IErrorInfo interface, or IntPtr(-1) to ignore the current IErrorInfo interface and construct the exception just from the error code. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static Exception GetExceptionForHR(int errorCode, IntPtr errorInfo)
		{
			return (Exception)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Releases all references to a runtime callable wrapper (RCW) by setting the reference count of the supplied RCW to 0.</summary>
		/// <returns>The new value of the reference count of the RCW associated with the <paramref name="o" />parameter, which is zero if the release is successful.</returns>
		/// <param name="o">The RCW to be released.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="o" /> is not a valid COM object.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="o" /> is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static int FinalReleaseComObject(object o)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern Delegate GetDelegateForFunctionPointerInternal(IntPtr ptr, Type t);

		/// <summary>Converts an unmanaged function pointer to a delegate.</summary>
		/// <returns>A delegate instance that can be cast to the appropriate delegate type.</returns>
		/// <param name="ptr">An <see cref="T:System.IntPtr" /> type that is the unmanaged function pointer to be converted. </param>
		/// <param name="t">The type of the delegate to be returned. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="t" /> parameter is not a delegate or is generic.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="ptr" /> parameter is null.-or-The <paramref name="t" /> parameter is null.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static Delegate GetDelegateForFunctionPointer(IntPtr ptr, Type t)
		{
			return (Delegate)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern IntPtr GetFunctionPointerForDelegateInternal(Delegate d);

		/// <summary>Converts a delegate into a function pointer callable from unmanaged code.</summary>
		/// <returns>An <see cref="T:System.IntPtr" /> value that can be passed to unmanaged code, which in turn can use it to call the underlying managed delegate.</returns>
		/// <param name="d">The delegate to be passed to unmanaged code. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="d" /> parameter is a generic type</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="d" /> parameter is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public unsafe static IntPtr GetFunctionPointerForDelegate(Delegate d)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
