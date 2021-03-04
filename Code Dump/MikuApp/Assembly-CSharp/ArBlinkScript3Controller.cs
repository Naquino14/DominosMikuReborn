using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ArBlinkScript3Controller : ArBlinkScriptController
{
	private const int SAMPLE_NUMBER = 8;

	private const float MAX_VALUE = 3.5f;

	public ArBlinkController _blinkCtrl;

	public TextAsset[] _files;

	private StageAnimModel[] _data;

	public TextAsset _dominoFile;

	private StageAnimModel _dominoData;

	private float[] samples;

	private float[] curValues;

	private int _maxSquare;

	private bool _isFinished;

	public void Start()
	{
	}

	protected override void OnUpdate()
	{
	}

	[DebuggerHidden]
	private IEnumerator Finish()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private void MusicVisualization()
	{
	}
}
