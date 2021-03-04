using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Exposes the public members of the <see cref="T:System.Reflection.EventInfo" /> class to unmanaged code.</summary>
	[ComVisible(true)]
	[Guid("9DE59C64-D889-35A1-B897-587D74469E5B")]
	[TypeLibImportClass(typeof(EventInfo))]
	[CLSCompliant(false)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface _EventInfo
	{
		/// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.EventInfo.Attributes" /> property.</summary>
		/// <returns>The read-only attributes for this event.</returns>
		EventAttributes Attributes
		{
			get;
		}

		/// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.EventInfo.EventHandlerType" /> property.</summary>
		/// <returns>A read-only <see cref="T:System.Type" /> object representing the delegate event handler.</returns>
		Type EventHandlerType
		{
			get;
		}

		/// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.EventInfo.MemberType" /> property.</summary>
		/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is an event.</returns>
		MemberTypes MemberType
		{
			get;
		}

		/// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.EventInfo.GetAddMethod(System.Boolean)" /> method.</summary>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method used to add an event-handler delegate to the event source.</returns>
		/// <param name="nonPublic">true to return non-public methods; otherwise, false.</param>
		MethodInfo GetAddMethod(bool nonPublic);
	}
}
