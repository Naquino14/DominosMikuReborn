using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000088 RID: 136
public abstract class DataSet
{
	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x060003D3 RID: 979
	public abstract string Path { get; }

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x060003D4 RID: 980
	public abstract DataSet.StorageType FileStorageType { get; }

	// Token: 0x060003D5 RID: 981 RVA: 0x00002F6C File Offset: 0x0000116C
	public static bool Exists(string name)
	{
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x00002F70 File Offset: 0x00001170
	public static bool Exists(string path, DataSet.StorageType storageType)
	{
	}

	// Token: 0x060003D7 RID: 983
	public abstract bool Load(string name);

	// Token: 0x060003D8 RID: 984
	public abstract bool Load(string path, DataSet.StorageType storageType);

	// Token: 0x060003D9 RID: 985
	public abstract IEnumerable<Trackable> GetTrackables();

	// Token: 0x060003DA RID: 986
	public abstract DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, string gameObjectName);

	// Token: 0x060003DB RID: 987
	public abstract DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, GameObject gameObject);

	// Token: 0x060003DC RID: 988
	public abstract bool Destroy(Trackable trackable, bool destroyGameObject);

	// Token: 0x060003DD RID: 989
	public abstract bool HasReachedTrackableLimit();

	// Token: 0x060003DE RID: 990
	public abstract bool Contains(Trackable trackable);

	// Token: 0x060003DF RID: 991
	public abstract void DestroyAllTrackables(bool destroyGameObject);

	// Token: 0x02000089 RID: 137
	public enum StorageType
	{
		// Token: 0x04000390 RID: 912
		STORAGE_APP,
		// Token: 0x04000391 RID: 913
		STORAGE_APPRESOURCE,
		// Token: 0x04000392 RID: 914
		STORAGE_ABSOLUTE
	}
}
