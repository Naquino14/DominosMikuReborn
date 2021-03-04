using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class QCARManagerImpl : QCARManager
{
	[StructLayout(0, Pack = 1)]
	public struct PoseData
	{
		[MarshalAs(30, SizeConst = 3)]
		public Vector3 position;

		[MarshalAs(30, SizeConst = 4)]
		public Quaternion orientation;
	}

	[StructLayout(0, Pack = 1)]
	public struct TrackableResultData
	{
		public PoseData pose;

		public TrackableBehaviour.Status status;

		public int id;
	}

	[StructLayout(0, Pack = 1)]
	public struct VirtualButtonData
	{
		public int id;

		public int isPressed;
	}

	[StructLayout(0, Pack = 1)]
	private struct ImageHeaderData
	{
		public int width;

		public int height;

		public int stride;

		public int bufferWidth;

		public int bufferHeight;

		public int format;

		public int reallocate;

		public int updated;

		public IntPtr data;
	}

	[StructLayout(0, Pack = 1)]
	private struct FrameState
	{
		public int numTrackableResults;

		public int numVirtualButtonResults;

		public int frameIndex;

		public IntPtr trackableDataArray;

		public IntPtr vbDataArray;
	}

	private QCARBehaviour.WorldCenterMode mWorldCenterMode;

	private TrackableBehaviour mWorldCenter;

	private Camera mARCamera;

	private TrackableResultData[] mTrackableResultDataArray;

	private LinkedList<int> mTrackableFoundQueue;

	private IntPtr mImageHeaderData;

	private int mNumImageHeaders;

	private bool mDrawVideobackground;

	private int mInjectedFrameIdx;

	private IntPtr mLastProcessedFrameStatePtr;

	private bool mInitialized;

	public override QCARBehaviour.WorldCenterMode WorldCenterMode
	{
		get
		{
			return (QCARBehaviour.WorldCenterMode)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public override TrackableBehaviour WorldCenter
	{
		get
		{
			return (TrackableBehaviour)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public override Camera ARCamera
	{
		get
		{
			return (Camera)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public override bool DrawVideoBackground
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public override bool Initialized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public override bool Init()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void Update(ScreenOrientation counterRotation)
	{
	}

	public override void Deinit()
	{
	}

	private void InitializeTrackableContainer(int numTrackableResults)
	{
	}

	private void UpdateTrackers(FrameState frameState)
	{
	}

	private void UpdateTrackablesEditor()
	{
	}

	private void UpdateImageContainer()
	{
	}

	private void UpdateCameraFrame()
	{
	}

	private void InjectCameraFrame()
	{
	}
}
