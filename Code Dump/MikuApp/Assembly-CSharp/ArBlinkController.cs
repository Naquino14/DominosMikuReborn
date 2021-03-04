using System.Collections.Generic;
using UnityEngine;

public class ArBlinkController : MonoBehaviour
{
	public Transform polySurface;

	public GameObject surfacePrefab;

	private List<GameObject> _squares;

	private List<Vector2> _posList;

	public float frameRate;

	private int[] _lines;

	private float _originZ;

	private float _originW;

	private float _originD;

	public Material whiteMat;

	public void Play()
	{
	}

	private void Awake()
	{
	}

	public int LoadFromFile(TextAsset file, ref StageAnimModel data)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public void LoadStage(StageAnimModel data, int index)
	{
	}

	public void LoadStage(List<int> list)
	{
	}

	public void AddColumn(List<int> column, float percent, ref List<int> list)
	{
	}

	public void OffAllSquare()
	{
	}

	private void DoubleLines()
	{
	}

	public void CreateSquares(int maxSquare)
	{
	}

	private void CreatePosList()
	{
	}

	private void CreateSquare(float x, float z)
	{
	}
}
