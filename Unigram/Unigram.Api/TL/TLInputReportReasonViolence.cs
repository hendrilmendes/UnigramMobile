// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputReportReasonViolence : TLReportReasonBase 
	{
		public TLInputReportReasonViolence() { }
		public TLInputReportReasonViolence(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputReportReasonViolence; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x1E22C78D);
		}
	}
}