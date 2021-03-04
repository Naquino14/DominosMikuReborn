using System;
using System.Runtime.InteropServices;
using System.Text;

public class QCARNullWrapper : IQCARWrapper
{
	public int CameraDeviceInitCamera(int camera)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int CameraDeviceDeinitCamera()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int CameraDeviceStartCamera()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int CameraDeviceStopCamera()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int CameraDeviceGetNumVideoModes()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public void CameraDeviceGetVideoMode(int idx, [In][Out] IntPtr videoMode)
	{
	}

	public int CameraDeviceSelectVideoMode(int idx)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int CameraDeviceSetFlashTorchMode(int on)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int CameraDeviceSetFocusMode(int focusMode)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int CameraDeviceSetCameraConfiguration(int width, int height)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int QcarSetFrameFormat(int format, int enabled)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int DataSetExists(string relativePath, int storageType)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int DataSetLoad(string relativePath, int storageType, IntPtr dataSetPtr)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int DataSetGetNumTrackableType(int trackableType, IntPtr dataSetPtr)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int DataSetGetTrackablesOfType(int trackableType, [In][Out] IntPtr trackableDataArray, int trackableDataArrayLength, IntPtr dataSetPtr)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int DataSetGetTrackableName(IntPtr dataSetPtr, int trackableId, StringBuilder trackableName, int nameMaxLength)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int DataSetCreateTrackable(IntPtr dataSetPtr, IntPtr trackableSourcePtr, StringBuilder trackableName, int nameMaxLength, [In][Out] IntPtr trackableData)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int DataSetDestroyTrackable(IntPtr dataSetPtr, int trackableId)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int DataSetHasReachedTrackableLimit(IntPtr dataSetPtr)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int ImageTargetBuilderBuild(string targetName, float sceenSizeWidth)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public void ImageTargetBuilderStartScan()
	{
	}

	public void ImageTargetBuilderStopScan()
	{
	}

	public int ImageTargetBuilderGetFrameQuality()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public unsafe IntPtr ImageTargetBuilderGetTrackableSource()
	{
		return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
	}

	public int ImageTargetCreateVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int ImageTargetDestroyVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int VirtualButtonGetId(IntPtr dataSetPtr, string trackableName, string virtualButtonName)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int ImageTargetGetNumVirtualButtons(IntPtr dataSetPtr, string trackableName)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int ImageTargetGetVirtualButtons([In][Out] IntPtr virtualButtonDataArray, [In][Out] IntPtr rectangleDataArray, int virtualButtonDataArrayLength, IntPtr dataSetPtr, string trackableName)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int ImageTargetGetVirtualButtonName(IntPtr dataSetPtr, string trackableName, int idx, StringBuilder vbName, int nameMaxLength)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int ImageTargetSetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int ImageTargetGetSize(IntPtr dataSetPtr, string trackableName, [In][Out] IntPtr size)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int ImageTrackerStart()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public void ImageTrackerStop()
	{
	}

	public unsafe IntPtr ImageTrackerCreateDataSet()
	{
		return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
	}

	public int ImageTrackerDestroyDataSet(IntPtr dataSetPtr)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int ImageTrackerActivateDataSet(IntPtr dataSetPtr)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int ImageTrackerDeactivateDataSet(IntPtr dataSetPtr)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int MarkerTrackerStart()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public void MarkerTrackerStop()
	{
	}

	public int MarkerTrackerCreateMarker(int id, string trackableName, float size)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int MarkerTrackerDestroyMarker(int trackableId)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public void InitFrameState([In][Out] IntPtr frameIndex)
	{
	}

	public void DeinitFrameState([In][Out] IntPtr frameIndex)
	{
	}

	public void UpdateQCAR([In][Out] IntPtr imageHeaderDataArray, int imageHeaderArrayLength, int bindVideoBackground, [In][Out] IntPtr frameIndex, int screenOrientation)
	{
	}

	public int QcarGetBufferSize(int width, int height, int format)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public void QcarAddCameraFrame(IntPtr pixels, int width, int height, int format, int stride, int frameIdx, int flipHorizontally)
	{
	}

	public void RendererSetVideoBackgroundCfg([In][Out] IntPtr bgCfg)
	{
	}

	public void RendererGetVideoBackgroundCfg([In][Out] IntPtr bgCfg)
	{
	}

	public void RendererGetVideoBackgroundTextureInfo([In][Out] IntPtr texInfo)
	{
	}

	public int RendererSetVideoBackgroundTextureID(int textureID)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int RendererIsVideoBackgroundTextureInfoAvailable()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int GetInitErrorCode()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int IsRendererDirty()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int QcarSetHint(int hint, int value)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int QcarRequiresAlpha()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int GetProjectionGL(float nearClip, float farClip, [In][Out] IntPtr projMatrix, int screenOrientation)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public void SetUnityVersion(int major, int minor, int change)
	{
	}

	public int TargetFinderStartInit(string userKey, string secretKey)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int TargetFinderGetInitState()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int TargetFinderDeinit()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int TargetFinderStartRecognition()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int TargetFinderStop()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public void TargetFinderSetUIScanlineColor(float r, float g, float b)
	{
	}

	public void TargetFinderSetUIPointColor(float r, float g, float b)
	{
	}

	public void TargetFinderUpdate([In][Out] IntPtr targetFinderState)
	{
	}

	public int TargetFinderGetResults([In][Out] IntPtr searchResultArray, int searchResultArrayLength)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int TargetFinderEnableTracking(IntPtr searchResult, [In][Out] IntPtr trackableData)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public void TargetFinderGetImageTargets([In][Out] IntPtr trackableIdArray, int trackableIdArrayLength)
	{
	}

	public void TargetFinderClearTrackables()
	{
	}

	public int TrackerManagerInitTracker(int trackerType)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int TrackerManagerDeinitTracker(int trackerType)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int VirtualButtonSetEnabled(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int enabled)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int VirtualButtonSetSensitivity(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int sensitivity)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int VirtualButtonSetAreaRectangle(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In][Out] IntPtr rectData)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int GetSurfaceOrientation()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public int QcarDeinit()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}
}
