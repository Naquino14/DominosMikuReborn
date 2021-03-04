using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Provides information about a <see cref="T:System.Diagnostics.StackFrame" />, which represents a function call on the call stack for the current thread.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ComVisible(true)]
	[MonoTODO("Serialized objects are not compatible with MS.NET")]
	public class StackFrame
	{
		/// <summary>Defines the value that is returned from the <see cref="M:System.Diagnostics.StackFrame.GetNativeOffset" /> or <see cref="M:System.Diagnostics.StackFrame.GetILOffset" /> method when the native or Microsoft intermediate language (MSIL) offset is unknown. This field is constant.</summary>
		/// <filterpriority>1</filterpriority>
		public const int OFFSET_UNKNOWN = -1;

		private int ilOffset;

		private int nativeOffset;

		private MethodBase methodBase;

		private string fileName;

		private int lineNumber;

		private int columnNumber;

		private string internalMethodName;

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackFrame" /> class.</summary>
		public StackFrame()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.StackFrame" /> class that corresponds to a frame above the current stack frame, optionally capturing source information.</summary>
		/// <param name="skipFrames">The number of frames up the stack to skip. </param>
		/// <param name="fNeedFileInfo">true to capture the file name, line number, and column number of the stack frame; otherwise, false. </param>
		public StackFrame(int skipFrames, bool fNeedFileInfo)
		{
		}

		[MethodImpl(4096)]
		private static extern bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column);

		/// <summary>Gets the line number in the file that contains the code that is executing. This information is typically extracted from the debugging symbols for the executable.</summary>
		/// <returns>The file line number.-or- Zero if the file line number cannot be determined.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual int GetFileLineNumber()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the file name that contains the code that is executing. This information is typically extracted from the debugging symbols for the executable.</summary>
		/// <returns>The file name.-or- null if the file name cannot be determined.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public virtual string GetFileName()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal string GetSecureFileName()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the offset from the start of the Microsoft intermediate language (MSIL) code for the method that is executing. This offset might be an approximation depending on whether or not the just-in-time (JIT) compiler is generating debugging code. The generation of this debugging information is controlled by the <see cref="T:System.Diagnostics.DebuggableAttribute" />.</summary>
		/// <returns>The offset from the start of the MSIL code for the method that is executing.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual int GetILOffset()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the method in which the frame is executing.</summary>
		/// <returns>The method in which the frame is executing.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual MethodBase GetMethod()
		{
			return (MethodBase)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the offset from the start of the native just-in-time (JIT)-compiled code for the method that is being executed. The generation of this debugging information is controlled by the <see cref="T:System.Diagnostics.DebuggableAttribute" /> class.</summary>
		/// <returns>The offset from the start of the JIT-compiled code for the method that is being executed.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual int GetNativeOffset()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal string GetInternalMethodName()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Builds a readable representation of the stack trace.</summary>
		/// <returns>A readable representation of the stack trace.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
