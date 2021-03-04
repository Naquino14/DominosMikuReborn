using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Provides the connection between an instance of <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and the formatter-provided class best suited to parse the data inside the <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
	[ComVisible(true)]
	[CLSCompliant(false)]
	public interface IFormatterConverter
	{
		/// <summary>Converts a value to the given <see cref="T:System.Type" />.</summary>
		/// <returns>The converted <paramref name="value" />.</returns>
		/// <param name="value">The object to be converted. </param>
		/// <param name="type">The <see cref="T:System.Type" /> into which <paramref name="value" /> is to be converted. </param>
		object Convert(object value, Type type);

		/// <summary>Converts a value to a <see cref="T:System.Boolean" />.</summary>
		/// <returns>The converted <paramref name="value" />.</returns>
		/// <param name="value">The object to be converted. </param>
		bool ToBoolean(object value);

		/// <summary>Converts a value to a 16-bit signed integer.</summary>
		/// <returns>The converted <paramref name="value" />.</returns>
		/// <param name="value">The object to be converted. </param>
		short ToInt16(object value);

		/// <summary>Converts a value to a 32-bit signed integer.</summary>
		/// <returns>The converted <paramref name="value" />.</returns>
		/// <param name="value">The object to be converted. </param>
		int ToInt32(object value);

		/// <summary>Converts a value to a 64-bit signed integer.</summary>
		/// <returns>The converted <paramref name="value" />.</returns>
		/// <param name="value">The object to be converted. </param>
		long ToInt64(object value);

		/// <summary>Converts a value to a <see cref="T:System.String" />.</summary>
		/// <returns>The converted <paramref name="value" />.</returns>
		/// <param name="value">The object to be converted. </param>
		string ToString(object value);

		/// <summary>Converts a value to a 32-bit unsigned integer.</summary>
		/// <returns>The converted <paramref name="value" />.</returns>
		/// <param name="value">The object to be converted. </param>
		uint ToUInt32(object value);
	}
}
