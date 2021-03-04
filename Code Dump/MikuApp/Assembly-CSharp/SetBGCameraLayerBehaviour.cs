using UnityEngine;

[RequireComponent(typeof(Camera))]
public class SetBGCameraLayerBehaviour : MonoBehaviour
{
	public int CameraLayer;

	private void Awake()
	{
	}

	private void ApplyCameraLayerRecursive(GameObject go)
	{
	}
}
