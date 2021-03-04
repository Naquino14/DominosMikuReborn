using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System
{
	/// <summary>Provides constants and static methods for trigonometric, logarithmic, and other common mathematical functions.</summary>
	/// <filterpriority>1</filterpriority>
	public static class Math
	{
		/// <summary>Represents the natural logarithmic base, specified by the constant, e.</summary>
		/// <filterpriority>1</filterpriority>
		public const double E = 2.7182818284590451;

		/// <summary>Represents the ratio of the circumference of a circle to its diameter, specified by the constant, π.</summary>
		/// <filterpriority>1</filterpriority>
		public const double PI = 3.1415926535897931;

		/// <summary>Returns the absolute value of a single-precision floating-point number.</summary>
		/// <returns>A single-precision floating-point number, x, such that 0 ≤ x ≤<see cref="F:System.Single.MaxValue" />.</returns>
		/// <param name="value">A number that is greater than or equal to <see cref="F:System.Single.MinValue" />, but less than or equal to <see cref="F:System.Single.MaxValue" />.</param>
		/// <filterpriority>1</filterpriority>
		public static float Abs(float value)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the absolute value of a 32-bit signed integer.</summary>
		/// <returns>A 32-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.Int32.MaxValue" />.</returns>
		/// <param name="value">A number that is greater than <see cref="F:System.Int32.MinValue" />, but less than or equal to <see cref="F:System.Int32.MaxValue" />.</param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static int Abs(int value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the absolute value of a 64-bit signed integer.</summary>
		/// <returns>A 64-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.Int64.MaxValue" />.</returns>
		/// <param name="value">A number that is greater than <see cref="F:System.Int64.MinValue" />, but less than or equal to <see cref="F:System.Int64.MaxValue" />.</param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> equals <see cref="F:System.Int64.MinValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static long Abs(long value)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the smallest integral value that is greater than or equal to the specified double-precision floating-point number.</summary>
		/// <returns>The smallest integral value that is greater than or equal to <paramref name="a" />. If <paramref name="a" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, that value is returned. Note that this method returns a <see cref="T:System.Double" /> type instead of an integral type.</returns>
		/// <param name="a">A double-precision floating-point number. </param>
		/// <filterpriority>1</filterpriority>
		public static double Ceiling(double a)
		{
			return (double)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the largest integer less than or equal to the specified double-precision floating-point number.</summary>
		/// <returns>The largest integer less than or equal to <paramref name="d" />. If <paramref name="d" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, that value is returned.</returns>
		/// <param name="d">A double-precision floating-point number. </param>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(4096)]
		public static extern double Floor(double d);

		/// <summary>Returns the larger of two 32-bit signed integers.</summary>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
		/// <param name="val1">The first of two 32-bit signed integers to compare. </param>
		/// <param name="val2">The second of two 32-bit signed integers to compare. </param>
		/// <filterpriority>1</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int Max(int val1, int val2)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the smaller of two 32-bit signed integers.</summary>
		/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
		/// <param name="val1">The first of two 32-bit signed integers to compare. </param>
		/// <param name="val2">The second of two 32-bit signed integers to compare. </param>
		/// <filterpriority>1</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int Min(int val1, int val2)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Rounds a decimal value to the nearest integral value.</summary>
		/// <returns>The integer nearest parameter <paramref name="d" />. If the fractional component of <paramref name="d" /> is halfway between two integers, one of which is even and the other odd, the even number is returned. Note that this method returns a <see cref="T:System.Decimal" /> instead of an integral type.</returns>
		/// <param name="d">A decimal number to be rounded. </param>
		/// <exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" />.</exception>
		/// <filterpriority>1</filterpriority>
		public static decimal Round(decimal d)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Rounds a double-precision floating-point value to the nearest integral value.</summary>
		/// <returns>The integer nearest <paramref name="a" />. If the fractional component of <paramref name="a" /> is halfway between two integers, one of which is even and the other odd, then the even number is returned. Note that this method returns a <see cref="T:System.Double" /> instead of an integral type.</returns>
		/// <param name="a">A double-precision floating-point number to be rounded. </param>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(4096)]
		public static extern double Round(double a);

		/// <summary>Returns the sine of the specified angle.</summary>
		/// <returns>The sine of <paramref name="a" />. If <paramref name="a" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, this method returns <see cref="F:System.Double.NaN" />.</returns>
		/// <param name="a">An angle, measured in radians. </param>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(4096)]
		public static extern double Sin(double a);

		/// <summary>Returns the cosine of the specified angle.</summary>
		/// <returns>The cosine of <paramref name="d" />. If <paramref name="d" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, this method returns <see cref="F:System.Double.NaN" />. </returns>
		/// <param name="d">An angle, measured in radians. </param>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(4096)]
		public static extern double Cos(double d);

		/// <summary>Returns the angle whose cosine is the specified number.</summary>
		/// <returns>An angle, θ, measured in radians, such that 0 ≤θ≤π-or- <see cref="F:System.Double.NaN" /> if <paramref name="d" /> &lt; -1 or <paramref name="d" /> &gt; 1 or <paramref name="d" /> equals <see cref="F:System.Double.NaN" />.</returns>
		/// <param name="d">A number representing a cosine, where <paramref name="d" /> must be greater than or equal to -1, but less than or equal to 1. </param>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(4096)]
		public static extern double Acos(double d);

		/// <summary>Returns a specified number raised to the specified power.</summary>
		/// <returns>The number <paramref name="x" /> raised to the power <paramref name="y" />.</returns>
		/// <param name="x">A double-precision floating-point number to be raised to a power. </param>
		/// <param name="y">A double-precision floating-point number that specifies a power. </param>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(4096)]
		public static extern double Pow(double x, double y);

		/// <summary>Returns the square root of a specified number.</summary>
		/// <returns>Value of <paramref name="d" />Returns Zero, or positive The positive square root of <paramref name="d" />. Negative <see cref="F:System.Double.NaN" />If <paramref name="d" /> is equal to <see cref="F:System.Double.NaN" /> or <see cref="F:System.Double.PositiveInfinity" />, that value is returned.</returns>
		/// <param name="d">A number. </param>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(4096)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern double Sqrt(double d);
	}
}
