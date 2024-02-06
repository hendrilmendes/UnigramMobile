// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Contacts
{
	/// <summary>
	/// RCP method contacts.importCard.
	/// Returns <see cref="Telegram.Api.TL.TLUserBase"/>
	/// </summary>
	public partial class TLContactsImportCard : TLObject
	{
		public TLVector<Int32> ExportCard { get; set; }

		public TLContactsImportCard() { }
		public TLContactsImportCard(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ContactsImportCard; } }

		public override void Read(TLBinaryReader from)
		{
			ExportCard = TLFactory.Read<TLVector<Int32>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x4FE196FE);
			to.WriteObject(ExportCard);
		}
	}
}