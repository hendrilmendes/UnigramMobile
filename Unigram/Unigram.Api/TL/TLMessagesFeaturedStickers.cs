// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessagesFeaturedStickers : TLMessagesFeaturedStickersBase 
	{
		public Int32 Hash { get; set; }
		public TLVector<TLStickerSetCoveredBase> Sets { get; set; }
		public TLVector<Int64> Unread { get; set; }

		public TLMessagesFeaturedStickers() { }
		public TLMessagesFeaturedStickers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesFeaturedStickers; } }

		public override void Read(TLBinaryReader from)
		{
			Hash = from.ReadInt32();
			Sets = TLFactory.Read<TLVector<TLStickerSetCoveredBase>>(from);
			Unread = TLFactory.Read<TLVector<Int64>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF89D88E5);
			to.Write(Hash);
			to.WriteObject(Sets);
			to.WriteObject(Unread);
		}
	}
}