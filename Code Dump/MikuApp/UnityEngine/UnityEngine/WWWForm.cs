using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UnityEngine
{
	public sealed class WWWForm
	{
		private List<byte[]> formData;

		private List<string> fieldNames;

		private List<string> fileNames;

		private List<string> types;

		private byte[] boundary;

		private bool containsFiles;

		public Hashtable headers => (Hashtable)/*Error near IL_0001: Stack underflow*/;

		public byte[] data => (byte[])/*Error near IL_0001: Stack underflow*/;

		public void AddField(string fieldName, string value)
		{
		}

		public void AddField(string fieldName, string value, Encoding e)
		{
		}

		public void AddBinaryData(string fieldName, byte[] contents)
		{
		}

		public void AddBinaryData(string fieldName, byte[] contents, string fileName, string mimeType)
		{
		}
	}
}
