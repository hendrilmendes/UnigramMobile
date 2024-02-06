// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Contacts
{
	/// <summary>
	/// RCP method contacts.search.
	/// Returns <see cref="Telegram.Api.TL.TLContactsFound"/>
	/// </summary>
	public partial class TLContactsSearch : TLObject
	{
		public String Q { get; set; }
		public Int32 Limit { get; set; }

		public TLContactsSearch() { }
		public TLContactsSearch(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsSearch; } }

		public override void Read(TLBinaryReader from)
		{
			Q = from.ReadString();
			Limit = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x11F812D8);
			to.Write(Q);
			to.Write(Limit);
		}
	}
}