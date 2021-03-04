using System.Collections.Generic;
using UnityEngine;

public class DataSetLoadBehaviour : MonoBehaviour
{
	[SerializeField]
	[HideInInspector]
	public List<string> mDataSetsToActivate;

	[SerializeField]
	[HideInInspector]
	public List<string> mDataSetsToLoad;

	private void Awake()
	{
	}
}
