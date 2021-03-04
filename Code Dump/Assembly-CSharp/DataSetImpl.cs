using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000A1 RID: 161
public class DataSetImpl : DataSet
{
	// Token: 0x06000464 RID: 1124 RVA: 0x000030BC File Offset: 0x000012BC
	public DataSetImpl(IntPtr dataSetPtr)
	{
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x06000465 RID: 1125 RVA: 0x000030C0 File Offset: 0x000012C0
	public IntPtr DataSetPtr
	{
		get
		{
		}
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x06000466 RID: 1126 RVA: 0x000030C4 File Offset: 0x000012C4
	public override string Path
	{
		get
		{
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x06000467 RID: 1127 RVA: 0x000030C8 File Offset: 0x000012C8
	public override DataSet.StorageType FileStorageType
	{
		get
		{
		}
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x000030CC File Offset: 0x000012CC
	public static bool ExistsImpl(string path, DataSet.StorageType storageType)
	{
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x000030D0 File Offset: 0x000012D0
	public override bool Load(string name)
	{
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x000030D4 File Offset: 0x000012D4
	public override bool Load(string path, DataSet.StorageType storageType)
	{
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x000030D8 File Offset: 0x000012D8
	public override IEnumerable<Trackable> GetTrackables()
	{
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x000030DC File Offset: 0x000012DC
	public override DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, string gameObjectName)
	{
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x000030E0 File Offset: 0x000012E0
	public override DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, GameObject gameObject)
	{
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x000030E4 File Offset: 0x000012E4
	public override bool Destroy(Trackable trackable, bool destroyGameObject)
	{
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x000030E8 File Offset: 0x000012E8
	public override bool HasReachedTrackableLimit()
	{
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x000030EC File Offset: 0x000012EC
	public override bool Contains(Trackable trackable)
	{
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x000030F0 File Offset: 0x000012F0
	public override void DestroyAllTrackables(bool destroyGameObject)
	{
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x000030F4 File Offset: 0x000012F4
	private void CreateImageTargets()
	{
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x000030F8 File Offset: 0x000012F8
	private void CreateMultiTargets()
	{
	}

	// Token: 0x040003BE RID: 958
	private IntPtr mDataSetPtr;

	// Token: 0x040003BF RID: 959
	private string mPath;

	// Token: 0x040003C0 RID: 960
	private DataSet.StorageType mStorageType;

	// Token: 0x040003C1 RID: 961
	private readonly Dictionary<int, Trackable> mTrackablesDict;
}
