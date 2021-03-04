using UnityEngine;

[AddComponentMenu("NGUI/UI/Input (Basic)")]
public class UIInputSysfontName : UIInputSysfont
{
	public enum LabelType
	{
		Name,
		TeamName,
		TeamMessage
	}

	[SerializeField]
	private LabelType _labelType;

	private void Awake()
	{
	}

	public override void UpdateLabel()
	{
	}

	public override void OnSelect(bool isSelected)
	{
	}

	private string CutText(string processed)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}
}
