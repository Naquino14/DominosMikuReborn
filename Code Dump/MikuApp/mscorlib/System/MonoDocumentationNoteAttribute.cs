namespace System
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	internal class MonoDocumentationNoteAttribute : MonoTODOAttribute
	{
		public MonoDocumentationNoteAttribute(string comment)
		{
		}
	}
}
