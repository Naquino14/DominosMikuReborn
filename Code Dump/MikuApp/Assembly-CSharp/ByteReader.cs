using System.Collections.Generic;
using UnityEngine;

public class ByteReader
{
	private byte[] mBuffer;

	private int mOffset;

	public bool canRead => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public ByteReader(byte[] bytes)
	{
	}

	public ByteReader(TextAsset asset)
	{
	}

	private static string ReadLine(byte[] buffer, int start, int count)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	public string ReadLine()
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	public Dictionary<string, string> ReadDictionary()
	{
		return (Dictionary<string, string>)/*Error near IL_0001: Stack underflow*/;
	}
}
