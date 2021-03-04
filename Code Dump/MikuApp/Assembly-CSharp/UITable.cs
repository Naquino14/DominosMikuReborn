using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Table")]
[ExecuteInEditMode]
public class UITable : MonoBehaviour
{
	public enum Direction
	{
		Down,
		Up
	}

	public delegate void OnReposition();

	public int columns;

	public Direction direction;

	public Vector2 padding;

	public bool sorted;

	public bool hideInactive;

	public bool repositionNow;

	public bool keepWithinPanel;

	public OnReposition onReposition;

	private UIPanel mPanel;

	private UIDraggablePanel mDrag;

	private bool mStarted;

	private List<Transform> mChildren;

	public List<Transform> children => (List<Transform>)/*Error near IL_0001: Stack underflow*/;

	public static int SortByName(Transform a, Transform b)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	private void RepositionVariableSize(List<Transform> children)
	{
	}

	public void Reposition()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}
}
