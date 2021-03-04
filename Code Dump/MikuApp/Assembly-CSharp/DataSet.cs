using System.Collections.Generic;
using UnityEngine;

public abstract class DataSet
{
	public enum StorageType
	{
		STORAGE_APP,
		STORAGE_APPRESOURCE,
		STORAGE_ABSOLUTE
	}

	public abstract string Path
	{
		get;
	}

	public abstract StorageType FileStorageType
	{
		get;
	}

	public static bool Exists(string name)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public static bool Exists(string path, StorageType storageType)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public abstract bool Load(string name);

	public abstract bool Load(string path, StorageType storageType);

	public abstract IEnumerable<Trackable> GetTrackables();

	public abstract DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, string gameObjectName);

	public abstract DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, GameObject gameObject);

	public abstract bool Destroy(Trackable trackable, bool destroyGameObject);

	public abstract bool HasReachedTrackableLimit();

	public abstract bool Contains(Trackable trackable);

	public abstract void DestroyAllTrackables(bool destroyGameObject);
}
