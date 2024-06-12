// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputChatUploadedPhoto : TLInputChatPhotoBase 
	{
		public TLInputFileBase File { get; set; }

		public TLInputChatUploadedPhoto() { }
		public TLInputChatUploadedPhoto(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputChatUploadedPhoto; } }

		public override void Read(TLBinaryReader from)
		{
			File = TLFactory.Read<TLInputFileBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x927C55B4);
			to.WriteObject(File);
		}
	}
}