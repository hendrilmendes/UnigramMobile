// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateDeleteMessages : TLUpdateBase, ITLMultiPts 
	{
		public TLVector<Int32> Messages { get; set; }
		public Int32 Pts { get; set; }
		public Int32 PtsCount { get; set; }

		public TLUpdateDeleteMessages() { }
		public TLUpdateDeleteMessages(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateDeleteMessages; } }

		public override void Read(TLBinaryReader from)
		{
			Messages = TLFactory.Read<TLVector<Int32>>(from);
			Pts = from.ReadInt32();
			PtsCount = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xA20DB0E5);
			to.WriteObject(Messages);
			to.Write(Pts);
			to.Write(PtsCount);
		}
	}
}