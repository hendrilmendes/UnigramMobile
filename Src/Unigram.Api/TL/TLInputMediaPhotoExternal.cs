// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputMediaPhotoExternal : TLInputMediaBase, ITLMediaCaption 
	{
		public String Url { get; set; }
		public String Caption { get; set; }

		public TLInputMediaPhotoExternal() { }
		public TLInputMediaPhotoExternal(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputMediaPhotoExternal; } }

		public override void Read(TLBinaryReader from)
		{
			Url = from.ReadString();
			Caption = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xB55F4F18);
			to.Write(Url);
			to.Write(Caption);
		}
	}
}