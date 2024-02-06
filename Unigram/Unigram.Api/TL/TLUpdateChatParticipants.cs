// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateChatParticipants : TLUpdateBase 
	{
		public TLChatParticipantsBase Participants { get; set; }

		public TLUpdateChatParticipants() { }
		public TLUpdateChatParticipants(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateChatParticipants; } }

		public override void Read(TLBinaryReader from)
		{
			Participants = TLFactory.Read<TLChatParticipantsBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x7761198);
			to.WriteObject(Participants);
		}
	}
}