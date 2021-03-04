using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Grid")]
public class UIGrid : MonoBehaviour
{
	public enum Arrangement
	{
		Horizontal,
		Vertical
	}

	public Arrangement arrangement;

	public int maxPerLine;

	public float cellWidth;

	public float cellHeight;

	public bool repositionNow;

	public bool sorted;

	public bool hideInactive;

	private bool mStarted;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static int SortByName(Transform a, Transform b)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public void Reposition()
	{
	}
}
