using System.Collections;
using System.IO;

namespace LipingShare.LCLib.Asn1Processor
{
	internal class Asn1Node
	{
		private byte tag;

		private long dataOffset;

		private long dataLength;

		private long lengthFieldBytes;

		private byte[] data;

		private ArrayList childNodeList;

		private byte unusedBits;

		private long deepness;

		private string path;

		private Asn1Node parentNode;

		private bool requireRecalculatePar;

		private bool isIndefiniteLength;

		private bool parseEncapsulatedData;

		public bool IsIndefiniteLength => false;

		public byte Tag => 0;

		public byte MaskedTag => 0;

		public long ChildNodeCount => 0L;

		public string TagName => null;

		public Asn1Node ParentNode => null;

		public long DataLength => 0L;

		public byte[] Data => null;

		public long Deepness => 0L;

		protected bool RequireRecalculatePar
		{
			set
			{
			}
		}

		private Asn1Node(Asn1Node parentNode, long dataOffset)
		{
		}

		private void Init()
		{
		}

		private string GetHexPrintingStr(Asn1Node startNode, string baseLine, string lStr, int lineLen)
		{
			return null;
		}

		private string FormatLineString(string lStr, int indent, int lineLen, string msg)
		{
			return null;
		}

		private string FormatLineHexString(string lStr, int indent, int lineLen, string msg)
		{
			return null;
		}

		public Asn1Node()
		{
		}

		public bool LoadData(Stream xdata)
		{
			return false;
		}

		public bool SaveData(Stream xdata)
		{
			return false;
		}

		public void ClearAll()
		{
		}

		public void AddChild(Asn1Node xdata)
		{
		}

		private Asn1Node GetLastChild()
		{
			return null;
		}

		public Asn1Node GetChildNode(int index)
		{
			return null;
		}

		public string GetText(Asn1Node startNode, int lineLen)
		{
			return null;
		}

		public string GetDataStr(bool pureHexMode)
		{
			return null;
		}

		protected void RecalculateTreePar()
		{
		}

		protected static long ResetBranchDataLength(Asn1Node node)
		{
			return 0L;
		}

		protected static void ResetDataLengthFieldWidth(Asn1Node node)
		{
		}

		protected void ResetChildNodePar(Asn1Node xNode, long subOffset)
		{
		}

		protected string GetListStr(Asn1Node startNode, int lineLen)
		{
			return null;
		}

		protected string GetIndentStr(Asn1Node startNode)
		{
			return null;
		}

		protected bool GeneralDecode(Stream xdata)
		{
			return false;
		}

		private bool AreTagsOk()
		{
			return false;
		}

		private bool GeneralDecodeKnownLengthWithChecks(Stream xdata, long start, long nodeMaxLen)
		{
			return false;
		}

		private bool IsGeneralStreamLengthOk(Stream xdata, long start, long nodeMaxLen)
		{
			return false;
		}

		private bool GeneralDecodeKnownLength(Stream xdata)
		{
			return false;
		}

		private void ReadStreamDataDefiniteLength(Stream xdata, int length)
		{
		}

		private bool GeneralDecodeIndefiniteLength(Stream xdata, long nodeMaxLen)
		{
			return false;
		}

		private bool ReadStreamDataIndefiniteLength(Stream xdata, long nodeMaxLen)
		{
			return false;
		}

		private long MeasureContentLength(Stream xdata)
		{
			return 0L;
		}

		private void ReadMeasuredLengthDataFromStart(Stream xdata, long startPosition, long length)
		{
		}

		protected bool ListDecode(Stream xdata)
		{
			return false;
		}

		private bool ListDecodeKnownLengthWithChecks(Stream xdata, long start, long childNodeMaxLen)
		{
			return false;
		}

		private bool IsListStreamLengthOk(Stream xdata, long childNodeMaxLen)
		{
			return false;
		}

		private bool ListDecodeKnownLength(Stream xdata, long start)
		{
			return false;
		}

		private long CalculateListEncodeFieldBytesAndOffset(Stream xdata, long start)
		{
			return 0L;
		}

		private bool HandleBitStringTag(Stream xdata, ref long offset)
		{
			return false;
		}

		private bool ListDecodeKnownLengthInternal(Stream xdata, long offset)
		{
			return false;
		}

		private Stream CreateAndPrepareListDecodeMemoryStreamKnownLength(Stream xdata)
		{
			return null;
		}

		private bool ListDecodeChildNodesWithKnownLength(Stream secData, long offset)
		{
			return false;
		}

		private bool CreateAndAddChildNode(Stream secData, ref long offset)
		{
			return false;
		}

		private bool ListDecodeIndefiniteLength(Stream xdata, long start, long childNodeMaxLen)
		{
			return false;
		}

		private bool ListDecodeIndefiniteLengthInternal(Stream xdata, long offset, long childNodeMaxLen)
		{
			return false;
		}

		private bool ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(Stream xdata, ref long offset, long childNodeMaxLen)
		{
			return false;
		}

		private Asn1EndOfIndefiniteLengthNodeType DetectEndOfIndefiniteListContents(Stream xdata)
		{
			return default(Asn1EndOfIndefiniteLengthNodeType);
		}

		private bool ReadNextChildNodeOfIndefiniteListClearIfInvalid(Stream xdata, ref long offset, long childNodeMaxLen)
		{
			return false;
		}

		protected bool InternalLoadData(Stream xdata)
		{
			return false;
		}
	}
}
