// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLAuthSentCodeTypeApp : TLAuthSentCodeTypeBase 
	{
		public Int32 Length { get; set; }

		public TLAuthSentCodeTypeApp() { }
		public TLAuthSentCodeTypeApp(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthSentCodeTypeApp; } }

		public override void Read(TLBinaryReader from)
		{
			Length = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x3DBB5986);
			to.Write(Length);
		}
	}
}