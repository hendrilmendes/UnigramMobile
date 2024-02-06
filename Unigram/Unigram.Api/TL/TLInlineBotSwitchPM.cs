// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInlineBotSwitchPM : TLObject 
	{
		public String Text { get; set; }
		public String StartParam { get; set; }

		public TLInlineBotSwitchPM() { }
		public TLInlineBotSwitchPM(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InlineBotSwitchPM; } }

		public override void Read(TLBinaryReader from)
		{
			Text = from.ReadString();
			StartParam = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x3C20629F);
			to.Write(Text);
			to.Write(StartParam);
		}
	}
}