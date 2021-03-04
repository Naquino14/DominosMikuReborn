using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020000C9 RID: 201
public class QCARNativeWrapper : IQCARWrapper
{
	// Token: 0x060005C5 RID: 1477 RVA: 0x0000342C File Offset: 0x0000162C
	public int CameraDeviceInitCamera(int camera)
	{
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x00003430 File Offset: 0x00001630
	public int CameraDeviceDeinitCamera()
	{
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x00003434 File Offset: 0x00001634
	public int CameraDeviceStartCamera()
	{
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x00003438 File Offset: 0x00001638
	public int CameraDeviceStopCamera()
	{
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x0000343C File Offset: 0x0000163C
	public int CameraDeviceGetNumVideoModes()
	{
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x00003440 File Offset: 0x00001640
	public void CameraDeviceGetVideoMode(int idx, [In] [Out] IntPtr videoMode)
	{
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x00003444 File Offset: 0x00001644
	public int CameraDeviceSelectVideoMode(int idx)
	{
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x00003448 File Offset: 0x00001648
	public int CameraDeviceSetFlashTorchMode(int on)
	{
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x0000344C File Offset: 0x0000164C
	public int CameraDeviceSetFocusMode(int focusMode)
	{
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00003450 File Offset: 0x00001650
	public int CameraDeviceSetCameraConfiguration(int width, int height)
	{
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00003454 File Offset: 0x00001654
	public int QcarSetFrameFormat(int format, int enabled)
	{
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x00003458 File Offset: 0x00001658
	public int DataSetExists(string relativePath, int storageType)
	{
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x0000345C File Offset: 0x0000165C
	public int DataSetLoad(string relativePath, int storageType, IntPtr dataSetPtr)
	{
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x00003460 File Offset: 0x00001660
	public int DataSetGetNumTrackableType(int trackableType, IntPtr dataSetPtr)
	{
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x00003464 File Offset: 0x00001664
	public int DataSetGetTrackablesOfType(int trackableType, [In] [Out] IntPtr trackableDataArray, int trackableDataArrayLength, IntPtr dataSetPtr)
	{
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x00003468 File Offset: 0x00001668
	public int DataSetGetTrackableName(IntPtr dataSetPtr, int trackableId, StringBuilder trackableName, int nameMaxLength)
	{
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x0000346C File Offset: 0x0000166C
	public int DataSetCreateTrackable(IntPtr dataSetPtr, IntPtr trackableSourcePtr, StringBuilder trackableName, int nameMaxLength, [In] [Out] IntPtr trackableData)
	{
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x00003470 File Offset: 0x00001670
	public int DataSetDestroyTrackable(IntPtr dataSetPtr, int trackableId)
	{
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x00003474 File Offset: 0x00001674
	public int DataSetHasReachedTrackableLimit(IntPtr dataSetPtr)
	{
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x00003478 File Offset: 0x00001678
	public int ImageTargetBuilderBuild(string targetName, float sceenSizeWidth)
	{
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0000347C File Offset: 0x0000167C
	public void ImageTargetBuilderStartScan()
	{
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x00003480 File Offset: 0x00001680
	public void ImageTargetBuilderStopScan()
	{
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x00003484 File Offset: 0x00001684
	public int ImageTargetBuilderGetFrameQuality()
	{
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x00003488 File Offset: 0x00001688
	public IntPtr ImageTargetBuilderGetTrackableSource()
	{
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x0000348C File Offset: 0x0000168C
	public int ImageTargetCreateVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In] [Out] IntPtr rectData)
	{
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00003490 File Offset: 0x00001690
	public int ImageTargetDestroyVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName)
	{
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00003494 File Offset: 0x00001694
	public int VirtualButtonGetId(IntPtr dataSetPtr, string trackableName, string virtualButtonName)
	{
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x00003498 File Offset: 0x00001698
	public int ImageTargetGetNumVirtualButtons(IntPtr dataSetPtr, string trackableName)
	{
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x0000349C File Offset: 0x0000169C
	public int ImageTargetGetVirtualButtons([In] [Out] IntPtr virtualButtonDataArray, [In] [Out] IntPtr rectangleDataArray, int virtualButtonDataArrayLength, IntPtr dataSetPtr, string trackableName)
	{
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x000034A0 File Offset: 0x000016A0
	public int ImageTargetGetVirtualButtonName(IntPtr dataSetPtr, string trackableName, int idx, StringBuilder vbName, int nameMaxLength)
	{
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x000034A4 File Offset: 0x000016A4
	public int ImageTargetSetSize(IntPtr dataSetPtr, string trackableName, [In] [Out] IntPtr size)
	{
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x000034A8 File Offset: 0x000016A8
	public int ImageTargetGetSize(IntPtr dataSetPtr, string trackableName, [In] [Out] IntPtr size)
	{
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x000034AC File Offset: 0x000016AC
	public int ImageTrackerStart()
	{
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x000034B0 File Offset: 0x000016B0
	public void ImageTrackerStop()
	{
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x000034B4 File Offset: 0x000016B4
	public IntPtr ImageTrackerCreateDataSet()
	{
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x000034B8 File Offset: 0x000016B8
	public int ImageTrackerDestroyDataSet(IntPtr dataSetPtr)
	{
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x000034BC File Offset: 0x000016BC
	public int ImageTrackerActivateDataSet(IntPtr dataSetPtr)
	{
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x000034C0 File Offset: 0x000016C0
	public int ImageTrackerDeactivateDataSet(IntPtr dataSetPtr)
	{
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x000034C4 File Offset: 0x000016C4
	public int MarkerTrackerStart()
	{
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x000034C8 File Offset: 0x000016C8
	public void MarkerTrackerStop()
	{
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x000034CC File Offset: 0x000016CC
	public int MarkerTrackerCreateMarker(int id, string trackableName, float size)
	{
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x000034D0 File Offset: 0x000016D0
	public int MarkerTrackerDestroyMarker(int trackableId)
	{
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x000034D4 File Offset: 0x000016D4
	public void InitFrameState([In] [Out] IntPtr frameIndex)
	{
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x000034D8 File Offset: 0x000016D8
	public void DeinitFrameState([In] [Out] IntPtr frameIndex)
	{
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x000034DC File Offset: 0x000016DC
	public void UpdateQCAR([In] [Out] IntPtr imageHeaderDataArray, int imageHeaderArrayLength, int bindVideoBackground, [In] [Out] IntPtr frameIndex, int screenOrientation)
	{
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x000034E0 File Offset: 0x000016E0
	public int QcarGetBufferSize(int width, int height, int format)
	{
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x000034E4 File Offset: 0x000016E4
	public void QcarAddCameraFrame(IntPtr pixels, int width, int height, int format, int stride, int frameIdx, int flipHorizontally)
	{
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x000034E8 File Offset: 0x000016E8
	public void RendererSetVideoBackgroundCfg([In] [Out] IntPtr bgCfg)
	{
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x000034EC File Offset: 0x000016EC
	public void RendererGetVideoBackgroundCfg([In] [Out] IntPtr bgCfg)
	{
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x000034F0 File Offset: 0x000016F0
	public void RendererGetVideoBackgroundTextureInfo([In] [Out] IntPtr texInfo)
	{
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x000034F4 File Offset: 0x000016F4
	public int RendererSetVideoBackgroundTextureID(int textureID)
	{
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x000034F8 File Offset: 0x000016F8
	public int RendererIsVideoBackgroundTextureInfoAvailable()
	{
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x000034FC File Offset: 0x000016FC
	public int GetInitErrorCode()
	{
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x00003500 File Offset: 0x00001700
	public int IsRendererDirty()
	{
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00003504 File Offset: 0x00001704
	public int QcarSetHint(int hint, int value)
	{
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x00003508 File Offset: 0x00001708
	public int QcarRequiresAlpha()
	{
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x0000350C File Offset: 0x0000170C
	public int GetProjectionGL(float nearClip, float farClip, [In] [Out] IntPtr projMatrix, int screenOrientation)
	{
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00003510 File Offset: 0x00001710
	public void SetUnityVersion(int major, int minor, int change)
	{
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x00003514 File Offset: 0x00001714
	public int TargetFinderStartInit(string userKey, string secretKey)
	{
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00003518 File Offset: 0x00001718
	public int TargetFinderGetInitState()
	{
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x0000351C File Offset: 0x0000171C
	public int TargetFinderDeinit()
	{
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00003520 File Offset: 0x00001720
	public int TargetFinderStartRecognition()
	{
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00003524 File Offset: 0x00001724
	public int TargetFinderStop()
	{
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00003528 File Offset: 0x00001728
	public void TargetFinderSetUIScanlineColor(float r, float g, float b)
	{
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x0000352C File Offset: 0x0000172C
	public void TargetFinderSetUIPointColor(float r, float g, float b)
	{
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00003530 File Offset: 0x00001730
	public void TargetFinderUpdate([In] [Out] IntPtr targetFinderState)
	{
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00003534 File Offset: 0x00001734
	public int TargetFinderGetResults([In] [Out] IntPtr searchResultArray, int searchResultArrayLength)
	{
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00003538 File Offset: 0x00001738
	public int TargetFinderEnableTracking(IntPtr searchResult, [In] [Out] IntPtr trackableData)
	{
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x0000353C File Offset: 0x0000173C
	public void TargetFinderGetImageTargets([In] [Out] IntPtr trackableIdArray, int trackableIdArrayLength)
	{
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00003540 File Offset: 0x00001740
	public void TargetFinderClearTrackables()
	{
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00003544 File Offset: 0x00001744
	public int TrackerManagerInitTracker(int trackerType)
	{
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00003548 File Offset: 0x00001748
	public int TrackerManagerDeinitTracker(int trackerType)
	{
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x0000354C File Offset: 0x0000174C
	public int VirtualButtonSetEnabled(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int enabled)
	{
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00003550 File Offset: 0x00001750
	public int VirtualButtonSetSensitivity(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int sensitivity)
	{
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00003554 File Offset: 0x00001754
	public int VirtualButtonSetAreaRectangle(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In] [Out] IntPtr rectData)
	{
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00003558 File Offset: 0x00001758
	public int GetSurfaceOrientation()
	{
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x0000355C File Offset: 0x0000175C
	public int QcarDeinit()
	{
	}

	// Token: 0x06000612 RID: 1554
	[DllImport("__Internal")]
	private static extern int cameraDeviceInitCamera(int camera);

	// Token: 0x06000613 RID: 1555
	[DllImport("__Internal")]
	private static extern int cameraDeviceDeinitCamera();

	// Token: 0x06000614 RID: 1556
	[DllImport("__Internal")]
	private static extern int cameraDeviceStartCamera();

	// Token: 0x06000615 RID: 1557
	[DllImport("__Internal")]
	private static extern int cameraDeviceStopCamera();

	// Token: 0x06000616 RID: 1558
	[DllImport("__Internal")]
	private static extern int cameraDeviceGetNumVideoModes();

	// Token: 0x06000617 RID: 1559
	[DllImport("__Internal")]
	private static extern void cameraDeviceGetVideoMode(int idx, [In] [Out] IntPtr videoMode);

	// Token: 0x06000618 RID: 1560
	[DllImport("__Internal")]
	private static extern int cameraDeviceSelectVideoMode(int idx);

	// Token: 0x06000619 RID: 1561
	[DllImport("__Internal")]
	private static extern int cameraDeviceSetFlashTorchMode(int on);

	// Token: 0x0600061A RID: 1562
	[DllImport("__Internal")]
	private static extern int cameraDeviceSetFocusMode(int focusMode);

	// Token: 0x0600061B RID: 1563
	[DllImport("__Internal")]
	private static extern int qcarSetFrameFormat(int format, int enabled);

	// Token: 0x0600061C RID: 1564
	[DllImport("__Internal")]
	private static extern int dataSetExists(string relativePath, int storageType);

	// Token: 0x0600061D RID: 1565
	[DllImport("__Internal")]
	private static extern int dataSetLoad(string relativePath, int storageType, IntPtr dataSetPtr);

	// Token: 0x0600061E RID: 1566
	[DllImport("__Internal")]
	private static extern int dataSetGetNumTrackableType(int trackableType, IntPtr dataSetPtr);

	// Token: 0x0600061F RID: 1567
	[DllImport("__Internal")]
	private static extern int dataSetGetTrackablesOfType(int trackableType, [In] [Out] IntPtr trackableDataArray, int trackableDataArrayLength, IntPtr dataSetPtr);

	// Token: 0x06000620 RID: 1568
	[DllImport("__Internal")]
	private static extern int dataSetGetTrackableName(IntPtr dataSetPtr, int trackableId, StringBuilder trackableName, int nameMaxLength);

	// Token: 0x06000621 RID: 1569
	[DllImport("__Internal")]
	private static extern int dataSetCreateTrackable(IntPtr dataSetPtr, IntPtr trackableSourcePtr, StringBuilder trackableName, int nameMaxLength, [In] [Out] IntPtr trackableData);

	// Token: 0x06000622 RID: 1570
	[DllImport("__Internal")]
	private static extern int dataSetDestroyTrackable(IntPtr dataSetPtr, int trackableId);

	// Token: 0x06000623 RID: 1571
	[DllImport("__Internal")]
	private static extern int dataSetHasReachedTrackableLimit(IntPtr dataSetPtr);

	// Token: 0x06000624 RID: 1572
	[DllImport("__Internal")]
	private static extern int imageTargetBuilderBuild(string targetName, float sceenSizeWidth);

	// Token: 0x06000625 RID: 1573
	[DllImport("__Internal")]
	private static extern void imageTargetBuilderStartScan();

	// Token: 0x06000626 RID: 1574
	[DllImport("__Internal")]
	private static extern void imageTargetBuilderStopScan();

	// Token: 0x06000627 RID: 1575
	[DllImport("__Internal")]
	private static extern int imageTargetBuilderGetFrameQuality();

	// Token: 0x06000628 RID: 1576
	[DllImport("__Internal")]
	private static extern IntPtr imageTargetBuilderGetTrackableSource();

	// Token: 0x06000629 RID: 1577
	[DllImport("__Internal")]
	private static extern int imageTargetCreateVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In] [Out] IntPtr rectData);

	// Token: 0x0600062A RID: 1578
	[DllImport("__Internal")]
	private static extern int imageTargetDestroyVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName);

	// Token: 0x0600062B RID: 1579
	[DllImport("__Internal")]
	private static extern int virtualButtonGetId(IntPtr dataSetPtr, string trackableName, string virtualButtonName);

	// Token: 0x0600062C RID: 1580
	[DllImport("__Internal")]
	private static extern int imageTargetGetNumVirtualButtons(IntPtr dataSetPtr, string trackableName);

	// Token: 0x0600062D RID: 1581
	[DllImport("__Internal")]
	private static extern int imageTargetGetVirtualButtons([In] [Out] IntPtr virtualButtonDataArray, [In] [Out] IntPtr rectangleDataArray, int virtualButtonDataArrayLength, IntPtr dataSetPtr, string trackableName);

	// Token: 0x0600062E RID: 1582
	[DllImport("__Internal")]
	private static extern int imageTargetGetVirtualButtonName(IntPtr dataSetPtr, string trackableName, int idx, StringBuilder vbName, int nameMaxLength);

	// Token: 0x0600062F RID: 1583
	[DllImport("__Internal")]
	private static extern int imageTargetSetSize(IntPtr dataSetPtr, string trackableName, [In] [Out] IntPtr size);

	// Token: 0x06000630 RID: 1584
	[DllImport("__Internal")]
	private static extern int imageTargetGetSize(IntPtr dataSetPtr, string trackableName, [In] [Out] IntPtr size);

	// Token: 0x06000631 RID: 1585
	[DllImport("__Internal")]
	private static extern int imageTrackerStart();

	// Token: 0x06000632 RID: 1586
	[DllImport("__Internal")]
	private static extern void imageTrackerStop();

	// Token: 0x06000633 RID: 1587
	[DllImport("__Internal")]
	private static extern IntPtr imageTrackerCreateDataSet();

	// Token: 0x06000634 RID: 1588
	[DllImport("__Internal")]
	private static extern int imageTrackerDestroyDataSet(IntPtr dataSetPtr);

	// Token: 0x06000635 RID: 1589
	[DllImport("__Internal")]
	private static extern int imageTrackerActivateDataSet(IntPtr dataSetPtr);

	// Token: 0x06000636 RID: 1590
	[DllImport("__Internal")]
	private static extern int imageTrackerDeactivateDataSet(IntPtr dataSetPtr);

	// Token: 0x06000637 RID: 1591
	[DllImport("__Internal")]
	private static extern int markerTrackerStart();

	// Token: 0x06000638 RID: 1592
	[DllImport("__Internal")]
	private static extern void markerTrackerStop();

	// Token: 0x06000639 RID: 1593
	[DllImport("__Internal")]
	private static extern int markerTrackerCreateMarker(int id, string trackableName, float size);

	// Token: 0x0600063A RID: 1594
	[DllImport("__Internal")]
	private static extern int markerTrackerDestroyMarker(int trackableId);

	// Token: 0x0600063B RID: 1595
	[DllImport("__Internal")]
	private static extern void initFrameState([In] [Out] IntPtr frameIndex);

	// Token: 0x0600063C RID: 1596
	[DllImport("__Internal")]
	private static extern void deinitFrameState([In] [Out] IntPtr frameIndex);

	// Token: 0x0600063D RID: 1597
	[DllImport("__Internal")]
	private static extern void updateQCAR([In] [Out] IntPtr imageHeaderDataArray, int imageHeaderArrayLength, int bindVideoBackground, [In] [Out] IntPtr frameIndex, int screenOrientation);

	// Token: 0x0600063E RID: 1598
	[DllImport("__Internal")]
	private static extern int qcarGetBufferSize(int width, int height, int format);

	// Token: 0x0600063F RID: 1599 RVA: 0x00003560 File Offset: 0x00001760
	private static void qcarAddCameraFrame(IntPtr pixels, int width, int height, int format, int stride, int frameIdx, int flipHorizontally)
	{
	}

	// Token: 0x06000640 RID: 1600
	[DllImport("__Internal")]
	private static extern void rendererSetVideoBackgroundCfg([In] [Out] IntPtr bgCfg);

	// Token: 0x06000641 RID: 1601
	[DllImport("__Internal")]
	private static extern void rendererGetVideoBackgroundCfg([In] [Out] IntPtr bgCfg);

	// Token: 0x06000642 RID: 1602
	[DllImport("__Internal")]
	private static extern void rendererGetVideoBackgroundTextureInfo([In] [Out] IntPtr texInfo);

	// Token: 0x06000643 RID: 1603
	[DllImport("__Internal")]
	private static extern int rendererSetVideoBackgroundTextureID(int textureID);

	// Token: 0x06000644 RID: 1604
	[DllImport("__Internal")]
	private static extern int rendererIsVideoBackgroundTextureInfoAvailable();

	// Token: 0x06000645 RID: 1605
	[DllImport("__Internal")]
	private static extern int getInitErrorCode();

	// Token: 0x06000646 RID: 1606
	[DllImport("__Internal")]
	private static extern int isRendererDirty();

	// Token: 0x06000647 RID: 1607
	[DllImport("__Internal")]
	private static extern int qcarSetHint(int hint, int value);

	// Token: 0x06000648 RID: 1608
	[DllImport("__Internal")]
	private static extern int qcarRequiresAlpha();

	// Token: 0x06000649 RID: 1609
	[DllImport("__Internal")]
	private static extern int getProjectionGL(float nearClip, float farClip, [In] [Out] IntPtr projMatrix, int screenOrientation);

	// Token: 0x0600064A RID: 1610
	[DllImport("__Internal")]
	private static extern void setUnityVersion(int major, int minor, int change);

	// Token: 0x0600064B RID: 1611
	[DllImport("__Internal")]
	private static extern int targetFinderStartInit(string userKey, string secretKey);

	// Token: 0x0600064C RID: 1612
	[DllImport("__Internal")]
	private static extern int targetFinderGetInitState();

	// Token: 0x0600064D RID: 1613
	[DllImport("__Internal")]
	private static extern int targetFinderDeinit();

	// Token: 0x0600064E RID: 1614
	[DllImport("__Internal")]
	private static extern int targetFinderStartRecognition();

	// Token: 0x0600064F RID: 1615
	[DllImport("__Internal")]
	private static extern int targetFinderStop();

	// Token: 0x06000650 RID: 1616
	[DllImport("__Internal")]
	private static extern void targetFinderSetUIScanlineColor(float r, float g, float b);

	// Token: 0x06000651 RID: 1617
	[DllImport("__Internal")]
	private static extern void targetFinderSetUIPointColor(float r, float g, float b);

	// Token: 0x06000652 RID: 1618
	[DllImport("__Internal")]
	private static extern void targetFinderUpdate([In] [Out] IntPtr targetFinderState);

	// Token: 0x06000653 RID: 1619
	[DllImport("__Internal")]
	private static extern int targetFinderGetResults([In] [Out] IntPtr searchResultArray, int searchResultArrayLength);

	// Token: 0x06000654 RID: 1620
	[DllImport("__Internal")]
	private static extern int targetFinderEnableTracking(IntPtr searchResult, [In] [Out] IntPtr trackableData);

	// Token: 0x06000655 RID: 1621
	[DllImport("__Internal")]
	private static extern void targetFinderGetImageTargets([In] [Out] IntPtr trackableIdArray, int trackableIdArrayLength);

	// Token: 0x06000656 RID: 1622
	[DllImport("__Internal")]
	private static extern void targetFinderClearTrackables();

	// Token: 0x06000657 RID: 1623
	[DllImport("__Internal")]
	private static extern int trackerManagerInitTracker(int trackerType);

	// Token: 0x06000658 RID: 1624
	[DllImport("__Internal")]
	private static extern int trackerManagerDeinitTracker(int trackerType);

	// Token: 0x06000659 RID: 1625
	[DllImport("__Internal")]
	private static extern int virtualButtonSetEnabled(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int enabled);

	// Token: 0x0600065A RID: 1626
	[DllImport("__Internal")]
	private static extern int virtualButtonSetSensitivity(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int sensitivity);

	// Token: 0x0600065B RID: 1627
	[DllImport("__Internal")]
	private static extern int virtualButtonSetAreaRectangle(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In] [Out] IntPtr rectData);

	// Token: 0x0600065C RID: 1628
	[DllImport("__Internal")]
	private static extern int getSurfaceOrientation();

	// Token: 0x0600065D RID: 1629
	[DllImport("__Internal")]
	private static extern int qcarDeinit();
}
