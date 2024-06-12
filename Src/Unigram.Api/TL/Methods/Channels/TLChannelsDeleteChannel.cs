// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Channels
{
	/// <summary>
	/// RCP method channels.deleteChannel.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLChannelsDeleteChannel : TLObject
	{
		public TLInputChannelBase Channel { get; set; }

		public TLChannelsDeleteChannel() { }
		public TLChannelsDeleteChannel(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsDeleteChannel; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xC0111FE3);
			to.WriteObject(Channel);
		}
	}
}