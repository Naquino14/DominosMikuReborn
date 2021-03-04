using UnityEngine;

public class ArSelectDanceController : MonoBehaviour
{
	public enum DanceType
	{
		EVER_GREEN,
		LUV_4_NIGHT
	}

	[SerializeField]
	public Transform[] _panels;

	[HideInInspector]
	public static DanceType danceType;

	[SerializeField]
	private GameObject newMark;

	private bool isClicked;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void SelectDanceType()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void OnEverGreenClick()
	{
	}

	private void OnLuv4NightClick()
	{
	}

	private void OnBackClick()
	{
	}
}
