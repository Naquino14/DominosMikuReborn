using System;
using System.Collections.Generic;
using UnityEngine;

public class DataSetImpl : DataSet
{
	private IntPtr mDataSetPtr;

	private string mPath;

	private StorageType mStorageType;

	private readonly Dictionary<int, Trackable> mTrackablesDict;

	public unsafe IntPtr DataSetPtr => (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;

	public override string Path => (string)/*Error near IL_0001: Stack underflow*/;

	public override StorageType FileStorageType => (StorageType)/*Error near IL_0001: Stack underflow*/;

	public DataSetImpl(IntPtr dataSetPtr)
	{
	}

	public static bool ExistsImpl(string path, StorageType storageType)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool Load(string name)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool Load(string path, StorageType storageType)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override IEnumerable<Trackable> GetTrackables()
	{
		return (IEnumerable<Trackable>)/*Error near IL_0001: Stack underflow*/;
	}

	public override DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, string gameObjectName)
	{
		return (DataSetTrackableBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	public override DataSetTrackableBehaviour CreateTrackable(TrackableSource trackableSource, GameObject gameObject)
	{
		return (DataSetTrackableBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	public override bool Destroy(Trackable trackable, bool destroyGameObject)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool HasReachedTrackableLimit()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool Contains(Trackable trackable)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override void DestroyAllTrackables(bool destroyGameObject)
	{
	}

	private void CreateImageTargets()
	{
	}

	private void CreateMultiTargets()
	{
	}
}
