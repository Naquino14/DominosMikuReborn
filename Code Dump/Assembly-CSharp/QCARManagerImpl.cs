using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020000B1 RID: 177
public class QCARManagerImpl : QCARManager
{
	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060004EF RID: 1263 RVA: 0x0000321C File Offset: 0x0000141C
	// (set) Token: 0x060004EE RID: 1262 RVA: 0x00003218 File Offset: 0x00001418
	public override QCARBehaviour.WorldCenterMode WorldCenterMode
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00003224 File Offset: 0x00001424
	// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00003220 File Offset: 0x00001420
	public override TrackableBehaviour WorldCenter
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0000322C File Offset: 0x0000142C
	// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00003228 File Offset: 0x00001428
	public override Camera ARCamera
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00003234 File Offset: 0x00001434
	// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00003230 File Offset: 0x00001430
	public override bool DrawVideoBackground
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00003238 File Offset: 0x00001438
	public override bool Initialized
	{
		get
		{
		}
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x0000323C File Offset: 0x0000143C
	public override bool Init()
	{
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x00003240 File Offset: 0x00001440
	public void Update(ScreenOrientation counterRotation)
	{
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x00003244 File Offset: 0x00001444
	public override void Deinit()
	{
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x00003248 File Offset: 0x00001448
	private void InitializeTrackableContainer(int numTrackableResults)
	{
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x0000324C File Offset: 0x0000144C
	private void UpdateTrackers(QCARManagerImpl.FrameState frameState)
	{
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00003250 File Offset: 0x00001450
	private void UpdateTrackablesEditor()
	{
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x00003254 File Offset: 0x00001454
	private void UpdateImageContainer()
	{
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x00003258 File Offset: 0x00001458
	private void UpdateCameraFrame()
	{
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x0000325C File Offset: 0x0000145C
	private void InjectCameraFrame()
	{
	}

	// Token: 0x040003DD RID: 989
	private QCARBehaviour.WorldCenterMode mWorldCenterMode;

	// Token: 0x040003DE RID: 990
	private TrackableBehaviour mWorldCenter;

	// Token: 0x040003DF RID: 991
	private Camera mARCamera;

	// Token: 0x040003E0 RID: 992
	private QCARManagerImpl.TrackableResultData[] mTrackableResultDataArray;

	// Token: 0x040003E1 RID: 993
	private LinkedList<int> mTrackableFoundQueue;

	// Token: 0x040003E2 RID: 994
	private IntPtr mImageHeaderData;

	// Token: 0x040003E3 RID: 995
	private int mNumImageHeaders;

	// Token: 0x040003E4 RID: 996
	private bool mDrawVideobackground;

	// Token: 0x040003E5 RID: 997
	private int mInjectedFrameIdx;

	// Token: 0x040003E6 RID: 998
	private IntPtr mLastProcessedFrameStatePtr;

	// Token: 0x040003E7 RID: 999
	private bool mInitialized;

	// Token: 0x020000B2 RID: 178
	[StructLayout(0, Pack = 1)]
	public struct PoseData
	{
		// Token: 0x040003E8 RID: 1000
		[MarshalAs(30, SizeConst = 3)]
		public Vector3 position;

		// Token: 0x040003E9 RID: 1001
		[MarshalAs(30, SizeConst = 4)]
		public Quaternion orientation;
	}

	// Token: 0x020000B3 RID: 179
	[StructLayout(0, Pack = 1)]
	public struct TrackableResultData
	{
		// Token: 0x040003EA RID: 1002
		public QCARManagerImpl.PoseData pose;

		// Token: 0x040003EB RID: 1003
		public TrackableBehaviour.Status status;

		// Token: 0x040003EC RID: 1004
		public int id;
	}

	// Token: 0x020000B4 RID: 180
	[StructLayout(0, Pack = 1)]
	public struct VirtualButtonData
	{
		// Token: 0x040003ED RID: 1005
		public int id;

		// Token: 0x040003EE RID: 1006
		public int isPressed;
	}

	// Token: 0x020000B5 RID: 181
	[StructLayout(0, Pack = 1)]
	private struct ImageHeaderData
	{
		// Token: 0x040003EF RID: 1007
		public int width;

		// Token: 0x040003F0 RID: 1008
		public int height;

		// Token: 0x040003F1 RID: 1009
		public int stride;

		// Token: 0x040003F2 RID: 1010
		public int bufferWidth;

		// Token: 0x040003F3 RID: 1011
		public int bufferHeight;

		// Token: 0x040003F4 RID: 1012
		public int format;

		// Token: 0x040003F5 RID: 1013
		public int reallocate;

		// Token: 0x040003F6 RID: 1014
		public int updated;

		// Token: 0x040003F7 RID: 1015
		public IntPtr data;
	}

	// Token: 0x020000B6 RID: 182
	[StructLayout(0, Pack = 1)]
	private struct FrameState
	{
		// Token: 0x040003F8 RID: 1016
		public int numTrackableResults;

		// Token: 0x040003F9 RID: 1017
		public int numVirtualButtonResults;

		// Token: 0x040003FA RID: 1018
		public int frameIndex;

		// Token: 0x040003FB RID: 1019
		public IntPtr trackableDataArray;

		// Token: 0x040003FC RID: 1020
		public IntPtr vbDataArray;
	}
}
