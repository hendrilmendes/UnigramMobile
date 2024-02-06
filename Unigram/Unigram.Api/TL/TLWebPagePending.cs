// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLWebPagePending : TLWebPageBase 
	{
		public Int32 Date { get; set; }

		public TLWebPagePending() { }
		public TLWebPagePending(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.WebPagePending; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt64();
			Date = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xC586DA1C);
			to.Write(Id);
			to.Write(Date);
		}
	}
}