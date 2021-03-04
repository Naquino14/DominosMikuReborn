using System.Configuration.Assemblies;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>Describes an assembly's unique identity in full.</summary>
	[Serializable]
	[ClassInterface(ClassInterfaceType.None)]
	public sealed class AssemblyName : ICloneable, _AssemblyName, IDeserializationCallback, ISerializable
	{
		private string name;

		private string codebase;

		private int major;

		private int minor;

		private int build;

		private int revision;

		private CultureInfo cultureinfo;

		private AssemblyNameFlags flags;

		private AssemblyHashAlgorithm hashalg;

		private StrongNameKeyPair keypair;

		private byte[] publicKey;

		private byte[] keyToken;

		private AssemblyVersionCompatibility versioncompat;

		private Version version;

		private ProcessorArchitecture processor_architecture;

		/// <summary>Gets or sets the simple name of the assembly. This is usually, but not necessarily, the file name of the manifest file of the assembly, minus its extension.</summary>
		/// <returns>A String that is the simple name of the assembly.</returns>
		public string Name => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the location of the assembly as a URL.</summary>
		/// <returns>A string that is the URL location of the assembly. </returns>
		public string CodeBase => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the culture supported by the assembly.</summary>
		/// <returns>A <see cref="T:System.Globalization.CultureInfo" /> object representing the culture supported by the assembly.</returns>
		public CultureInfo CultureInfo => (CultureInfo)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the attributes of the assembly.</summary>
		/// <returns>An <see cref="T:System.Reflection.AssemblyNameFlags" /> object representing the attributes of the assembly.</returns>
		public AssemblyNameFlags Flags => (AssemblyNameFlags)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the full name of the assembly, also known as the display name.</summary>
		/// <returns>A string that is the full name of the assembly, also known as the display name.</returns>
		public string FullName => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the major, minor, build, and revision numbers of the assembly.</summary>
		/// <returns>A <see cref="T:System.Version" /> object representing the major, minor, build, and revision numbers of the assembly.</returns>
		public Version Version
		{
			get
			{
				return (Version)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyName" /> class.</summary>
		public AssemblyName()
		{
		}

		internal AssemblyName(SerializationInfo si, StreamingContext sc)
		{
		}

		/// <summary>Returns the full name of the assembly, also known as the display name.</summary>
		/// <returns>A String that is the full name of the assembly, or the class name if the full name of the assembly cannot be determined.</returns>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets the public key token, which is the last 8 bytes of the SHA-1 hash of the public key under which the application or assembly is signed.</summary>
		/// <returns>An array of type byte containing the public key token.</returns>
		public byte[] GetPublicKeyToken()
		{
			return (byte[])/*Error near IL_0001: Stack underflow*/;
		}

		private byte[] InternalGetPublicKeyToken()
		{
			return (byte[])/*Error near IL_0001: Stack underflow*/;
		}

		private byte[] ComputePublicKeyToken()
		{
			return (byte[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets serialization information with all of the data needed to recreate an instance of this AssemblyName.</summary>
		/// <param name="info">The object to be populated with serialization information. </param>
		/// <param name="context">The destination context of the serialization. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null. </exception>
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Makes a copy of this AssemblyName object.</summary>
		/// <returns>An object that is a copy of this AssemblyName object.</returns>
		public object Clone()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and is called back by the deserialization event when deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event. </param>
		public void OnDeserialization(object sender)
		{
		}
	}
}
