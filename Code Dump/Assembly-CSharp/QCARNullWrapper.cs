using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020000CA RID: 202
public class QCARNullWrapper : IQCARWrapper
{
	// Token: 0x0600065F RID: 1631 RVA: 0x00003568 File Offset: 0x00001768
	public int CameraDeviceInitCamera(int camera)
	{
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x0000356C File Offset: 0x0000176C
	public int CameraDeviceDeinitCamera()
	{
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00003570 File Offset: 0x00001770
	public int CameraDeviceStartCamera()
	{
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00003574 File Offset: 0x00001774
	public int CameraDeviceStopCamera()
	{
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00003578 File Offset: 0x00001778
	public int CameraDeviceGetNumVideoModes()
	{
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x0000357C File Offset: 0x0000177C
	public void CameraDeviceGetVideoMode(int idx, [In] [Out] IntPtr videoMode)
	{
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00003580 File Offset: 0x00001780
	public int CameraDeviceSelectVideoMode(int idx)
	{
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00003584 File Offset: 0x00001784
	public int CameraDeviceSetFlashTorchMode(int on)
	{
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x00003588 File Offset: 0x00001788
	public int CameraDeviceSetFocusMode(int focusMode)
	{
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x0000358C File Offset: 0x0000178C
	public int CameraDeviceSetCameraConfiguration(int width, int height)
	{
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00003590 File Offset: 0x00001790
	public int QcarSetFrameFormat(int format, int enabled)
	{
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00003594 File Offset: 0x00001794
	public int DataSetExists(string relativePath, int storageType)
	{
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x00003598 File Offset: 0x00001798
	public int DataSetLoad(string relativePath, int storageType, IntPtr dataSetPtr)
	{
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x0000359C File Offset: 0x0000179C
	public int DataSetGetNumTrackableType(int trackableType, IntPtr dataSetPtr)
	{
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x000035A0 File Offset: 0x000017A0
	public int DataSetGetTrackablesOfType(int trackableType, [In] [Out] IntPtr trackableDataArray, int trackableDataArrayLength, IntPtr dataSetPtr)
	{
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x000035A4 File Offset: 0x000017A4
	public int DataSetGetTrackableName(IntPtr dataSetPtr, int trackableId, StringBuilder trackableName, int nameMaxLength)
	{
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x000035A8 File Offset: 0x000017A8
	public int DataSetCreateTrackable(IntPtr dataSetPtr, IntPtr trackableSourcePtr, StringBuilder trackableName, int nameMaxLength, [In] [Out] IntPtr trackableData)
	{
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x000035AC File Offset: 0x000017AC
	public int DataSetDestroyTrackable(IntPtr dataSetPtr, int trackableId)
	{
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x000035B0 File Offset: 0x000017B0
	public int DataSetHasReachedTrackableLimit(IntPtr dataSetPtr)
	{
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x000035B4 File Offset: 0x000017B4
	public int ImageTargetBuilderBuild(string targetName, float sceenSizeWidth)
	{
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x000035B8 File Offset: 0x000017B8
	public void ImageTargetBuilderStartScan()
	{
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x000035BC File Offset: 0x000017BC
	public void ImageTargetBuilderStopScan()
	{
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x000035C0 File Offset: 0x000017C0
	public int ImageTargetBuilderGetFrameQuality()
	{
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x000035C4 File Offset: 0x000017C4
	public IntPtr ImageTargetBuilderGetTrackableSource()
	{
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x000035C8 File Offset: 0x000017C8
	public int ImageTargetCreateVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In] [Out] IntPtr rectData)
	{
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x000035CC File Offset: 0x000017CC
	public int ImageTargetDestroyVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName)
	{
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x000035D0 File Offset: 0x000017D0
	public int VirtualButtonGetId(IntPtr dataSetPtr, string trackableName, string virtualButtonName)
	{
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x000035D4 File Offset: 0x000017D4
	public int ImageTargetGetNumVirtualButtons(IntPtr dataSetPtr, string trackableName)
	{
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x000035D8 File Offset: 0x000017D8
	public int ImageTargetGetVirtualButtons([In] [Out] IntPtr virtualButtonDataArray, [In] [Out] IntPtr rectangleDataArray, int virtualButtonDataArrayLength, IntPtr dataSetPtr, string trackableName)
	{
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x000035DC File Offset: 0x000017DC
	public int ImageTargetGetVirtualButtonName(IntPtr dataSetPtr, string trackableName, int idx, StringBuilder vbName, int nameMaxLength)
	{
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x000035E0 File Offset: 0x000017E0
	public int ImageTargetSetSize(IntPtr dataSetPtr, string trackableName, [In] [Out] IntPtr size)
	{
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x000035E4 File Offset: 0x000017E4
	public int ImageTargetGetSize(IntPtr dataSetPtr, string trackableName, [In] [Out] IntPtr size)
	{
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x000035E8 File Offset: 0x000017E8
	public int ImageTrackerStart()
	{
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x000035EC File Offset: 0x000017EC
	public void ImageTrackerStop()
	{
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x000035F0 File Offset: 0x000017F0
	public IntPtr ImageTrackerCreateDataSet()
	{
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x000035F4 File Offset: 0x000017F4
	public int ImageTrackerDestroyDataSet(IntPtr dataSetPtr)
	{
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x000035F8 File Offset: 0x000017F8
	public int ImageTrackerActivateDataSet(IntPtr dataSetPtr)
	{
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x000035FC File Offset: 0x000017FC
	public int ImageTrackerDeactivateDataSet(IntPtr dataSetPtr)
	{
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00003600 File Offset: 0x00001800
	public int MarkerTrackerStart()
	{
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00003604 File Offset: 0x00001804
	public void MarkerTrackerStop()
	{
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00003608 File Offset: 0x00001808
	public int MarkerTrackerCreateMarker(int id, string trackableName, float size)
	{
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x0000360C File Offset: 0x0000180C
	public int MarkerTrackerDestroyMarker(int trackableId)
	{
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00003610 File Offset: 0x00001810
	public void InitFrameState([In] [Out] IntPtr frameIndex)
	{
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00003614 File Offset: 0x00001814
	public void DeinitFrameState([In] [Out] IntPtr frameIndex)
	{
	}

	// Token: 0x0600068B RID: 1675 RVA: 0x00003618 File Offset: 0x00001818
	public void UpdateQCAR([In] [Out] IntPtr imageHeaderDataArray, int imageHeaderArrayLength, int bindVideoBackground, [In] [Out] IntPtr frameIndex, int screenOrientation)
	{
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x0000361C File Offset: 0x0000181C
	public int QcarGetBufferSize(int width, int height, int format)
	{
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00003620 File Offset: 0x00001820
	public void QcarAddCameraFrame(IntPtr pixels, int width, int height, int format, int stride, int frameIdx, int flipHorizontally)
	{
	}

	// Token: 0x0600068E RID: 1678 RVA: 0x00003624 File Offset: 0x00001824
	public void RendererSetVideoBackgroundCfg([In] [Out] IntPtr bgCfg)
	{
	}

	// Token: 0x0600068F RID: 1679 RVA: 0x00003628 File Offset: 0x00001828
	public void RendererGetVideoBackgroundCfg([In] [Out] IntPtr bgCfg)
	{
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x0000362C File Offset: 0x0000182C
	public void RendererGetVideoBackgroundTextureInfo([In] [Out] IntPtr texInfo)
	{
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00003630 File Offset: 0x00001830
	public int RendererSetVideoBackgroundTextureID(int textureID)
	{
	}

	// Token: 0x06000692 RID: 1682 RVA: 0x00003634 File Offset: 0x00001834
	public int RendererIsVideoBackgroundTextureInfoAvailable()
	{
	}

	// Token: 0x06000693 RID: 1683 RVA: 0x00003638 File Offset: 0x00001838
	public int GetInitErrorCode()
	{
	}

	// Token: 0x06000694 RID: 1684 RVA: 0x0000363C File Offset: 0x0000183C
	public int IsRendererDirty()
	{
	}

	// Token: 0x06000695 RID: 1685 RVA: 0x00003640 File Offset: 0x00001840
	public int QcarSetHint(int hint, int value)
	{
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x00003644 File Offset: 0x00001844
	public int QcarRequiresAlpha()
	{
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00003648 File Offset: 0x00001848
	public int GetProjectionGL(float nearClip, float farClip, [In] [Out] IntPtr projMatrix, int screenOrientation)
	{
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x0000364C File Offset: 0x0000184C
	public void SetUnityVersion(int major, int minor, int change)
	{
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00003650 File Offset: 0x00001850
	public int TargetFinderStartInit(string userKey, string secretKey)
	{
	}

	// Token: 0x0600069A RID: 1690 RVA: 0x00003654 File Offset: 0x00001854
	public int TargetFinderGetInitState()
	{
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x00003658 File Offset: 0x00001858
	public int TargetFinderDeinit()
	{
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x0000365C File Offset: 0x0000185C
	public int TargetFinderStartRecognition()
	{
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00003660 File Offset: 0x00001860
	public int TargetFinderStop()
	{
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00003664 File Offset: 0x00001864
	public void TargetFinderSetUIScanlineColor(float r, float g, float b)
	{
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00003668 File Offset: 0x00001868
	public void TargetFinderSetUIPointColor(float r, float g, float b)
	{
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x0000366C File Offset: 0x0000186C
	public void TargetFinderUpdate([In] [Out] IntPtr targetFinderState)
	{
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00003670 File Offset: 0x00001870
	public int TargetFinderGetResults([In] [Out] IntPtr searchResultArray, int searchResultArrayLength)
	{
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x00003674 File Offset: 0x00001874
	public int TargetFinderEnableTracking(IntPtr searchResult, [In] [Out] IntPtr trackableData)
	{
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00003678 File Offset: 0x00001878
	public void TargetFinderGetImageTargets([In] [Out] IntPtr trackableIdArray, int trackableIdArrayLength)
	{
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x0000367C File Offset: 0x0000187C
	public void TargetFinderClearTrackables()
	{
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00003680 File Offset: 0x00001880
	public int TrackerManagerInitTracker(int trackerType)
	{
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00003684 File Offset: 0x00001884
	public int TrackerManagerDeinitTracker(int trackerType)
	{
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00003688 File Offset: 0x00001888
	public int VirtualButtonSetEnabled(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int enabled)
	{
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x0000368C File Offset: 0x0000188C
	public int VirtualButtonSetSensitivity(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int sensitivity)
	{
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00003690 File Offset: 0x00001890
	public int VirtualButtonSetAreaRectangle(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In] [Out] IntPtr rectData)
	{
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00003694 File Offset: 0x00001894
	public int GetSurfaceOrientation()
	{
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x00003698 File Offset: 0x00001898
	public int QcarDeinit()
	{
	}
}
