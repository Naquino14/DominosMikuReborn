using UnityEngine;

[AddComponentMenu("Camera-Control/3dsMax Camera Style")]
public class MaxCamera : MonoBehaviour
{
	private const float xSpeed = 10f;

	private const float ySpeed = 10f;

	public Transform realTarget;

	public Transform target;

	public Vector3 targetOffset;

	public float distance;

	public float maxDistance;

	public float minDistance;

	public int yMinLimit;

	public int yMaxLimit;

	public int zoomRate;

	public float panSpeed;

	public float zoomDampening;

	private float currentDistance;

	private float desiredDistance;

	private Quaternion rotation;

	private Vector3 position;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Init()
	{
	}

	public void Reset()
	{
	}

	public void OnZoom(float deltaY)
	{
	}

	public void OnOrbit(float deltaX, float deltaY)
	{
	}

	public void OnPan(float deltaX, float deltaY)
	{
	}

	public void OnZoom()
	{
	}

	public void OnOrbit()
	{
	}

	public void OnPan()
	{
	}

	private void LateUpdate()
	{
	}

	private static float ClampAngle(float angle, float min, float max)
	{
		return (float)/*Error near IL_0001: Stack underflow*/;
	}
}
