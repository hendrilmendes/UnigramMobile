// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUser : TLUserBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Self = (1 << 10),
			Contact = (1 << 11),
			MutualContact = (1 << 12),
			Deleted = (1 << 13),
			Bot = (1 << 14),
			BotChatHistory = (1 << 15),
			BotNochats = (1 << 16),
			Verified = (1 << 17),
			Restricted = (1 << 18),
			Min = (1 << 20),
			BotInlineGeo = (1 << 21),
			AccessHash = (1 << 0),
			FirstName = (1 << 1),
			LastName = (1 << 2),
			Username = (1 << 3),
			Phone = (1 << 4),
			Photo = (1 << 5),
			Status = (1 << 6),
			BotInfoVersion = (1 << 14),
			RestrictionReason = (1 << 18),
			BotInlinePlaceholder = (1 << 19),
		}

		public bool IsSelf { get { return Flags.HasFlag(Flag.Self); } set { Flags = value ? (Flags | Flag.Self) : (Flags & ~Flag.Self); } }
		public bool IsContact { get { return Flags.HasFlag(Flag.Contact); } set { Flags = value ? (Flags | Flag.Contact) : (Flags & ~Flag.Contact); } }
		public bool IsMutualContact { get { return Flags.HasFlag(Flag.MutualContact); } set { Flags = value ? (Flags | Flag.MutualContact) : (Flags & ~Flag.MutualContact); } }
		public bool IsDeleted { get { return Flags.HasFlag(Flag.Deleted); } set { Flags = value ? (Flags | Flag.Deleted) : (Flags & ~Flag.Deleted); } }
		public bool IsBot { get { return Flags.HasFlag(Flag.Bot); } set { Flags = value ? (Flags | Flag.Bot) : (Flags & ~Flag.Bot); } }
		public bool IsBotChatHistory { get { return Flags.HasFlag(Flag.BotChatHistory); } set { Flags = value ? (Flags | Flag.BotChatHistory) : (Flags & ~Flag.BotChatHistory); } }
		public bool IsBotNochats { get { return Flags.HasFlag(Flag.BotNochats); } set { Flags = value ? (Flags | Flag.BotNochats) : (Flags & ~Flag.BotNochats); } }
		public bool IsVerified { get { return Flags.HasFlag(Flag.Verified); } set { Flags = value ? (Flags | Flag.Verified) : (Flags & ~Flag.Verified); } }
		public bool IsRestricted { get { return Flags.HasFlag(Flag.Restricted); } set { Flags = value ? (Flags | Flag.Restricted) : (Flags & ~Flag.Restricted); } }
		public bool IsMin { get { return Flags.HasFlag(Flag.Min); } set { Flags = value ? (Flags | Flag.Min) : (Flags & ~Flag.Min); } }
		public bool IsBotInlineGeo { get { return Flags.HasFlag(Flag.BotInlineGeo); } set { Flags = value ? (Flags | Flag.BotInlineGeo) : (Flags & ~Flag.BotInlineGeo); } }
		public bool HasAccessHash { get { return Flags.HasFlag(Flag.AccessHash); } set { Flags = value ? (Flags | Flag.AccessHash) : (Flags & ~Flag.AccessHash); } }
		public bool HasFirstName { get { return Flags.HasFlag(Flag.FirstName); } set { Flags = value ? (Flags | Flag.FirstName) : (Flags & ~Flag.FirstName); } }
		public bool HasLastName { get { return Flags.HasFlag(Flag.LastName); } set { Flags = value ? (Flags | Flag.LastName) : (Flags & ~Flag.LastName); } }
		public bool HasUsername { get { return Flags.HasFlag(Flag.Username); } set { Flags = value ? (Flags | Flag.Username) : (Flags & ~Flag.Username); } }
		public bool HasPhone { get { return Flags.HasFlag(Flag.Phone); } set { Flags = value ? (Flags | Flag.Phone) : (Flags & ~Flag.Phone); } }
		public bool HasPhoto { get { return Flags.HasFlag(Flag.Photo); } set { Flags = value ? (Flags | Flag.Photo) : (Flags & ~Flag.Photo); } }
		public bool HasStatus { get { return Flags.HasFlag(Flag.Status); } set { Flags = value ? (Flags | Flag.Status) : (Flags & ~Flag.Status); } }
		public bool HasBotInfoVersion { get { return Flags.HasFlag(Flag.BotInfoVersion); } set { Flags = value ? (Flags | Flag.BotInfoVersion) : (Flags & ~Flag.BotInfoVersion); } }
		public bool HasRestrictionReason { get { return Flags.HasFlag(Flag.RestrictionReason); } set { Flags = value ? (Flags | Flag.RestrictionReason) : (Flags & ~Flag.RestrictionReason); } }
		public bool HasBotInlinePlaceholder { get { return Flags.HasFlag(Flag.BotInlinePlaceholder); } set { Flags = value ? (Flags | Flag.BotInlinePlaceholder) : (Flags & ~Flag.BotInlinePlaceholder); } }

		public Flag Flags { get; set; }
		public Int64? AccessHash { get; set; }
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public String Username { get; set; }
		public String Phone { get; set; }
		public TLUserProfilePhotoBase Photo { get; set; }
		public TLUserStatusBase Status { get; set; }
		public Int32? BotInfoVersion { get; set; }
		public String RestrictionReason { get; set; }
		public String BotInlinePlaceholder { get; set; }

		public TLUser() { }
		public TLUser(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.User; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Id = from.ReadInt32();
			if (HasAccessHash) AccessHash = from.ReadInt64();
			if (HasFirstName) FirstName = from.ReadString();
			if (HasLastName) LastName = from.ReadString();
			if (HasUsername) Username = from.ReadString();
			if (HasPhone) Phone = from.ReadString();
			if (HasPhoto) Photo = TLFactory.Read<TLUserProfilePhotoBase>(from);
			if (HasStatus) Status = TLFactory.Read<TLUserStatusBase>(from);
			if (HasBotInfoVersion) BotInfoVersion = from.ReadInt32();
			if (HasRestrictionReason) RestrictionReason = from.ReadString();
			if (HasBotInlinePlaceholder) BotInlinePlaceholder = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0xD10D979A);
			to.Write((Int32)Flags);
			to.Write(Id);
			if (HasAccessHash) to.Write(AccessHash.Value);
			if (HasFirstName) to.Write(FirstName);
			if (HasLastName) to.Write(LastName);
			if (HasUsername) to.Write(Username);
			if (HasPhone) to.Write(Phone);
			if (HasPhoto) to.WriteObject(Photo);
			if (HasStatus) to.WriteObject(Status);
			if (HasBotInfoVersion) to.Write(BotInfoVersion.Value);
			if (HasRestrictionReason) to.Write(RestrictionReason);
			if (HasBotInlinePlaceholder) to.Write(BotInlinePlaceholder);
		}

		private void UpdateFlags()
		{
			HasAccessHash = AccessHash != null;
			HasFirstName = FirstName != null;
			HasLastName = LastName != null;
			HasUsername = Username != null;
			HasPhone = Phone != null;
			HasPhoto = Photo != null;
			HasStatus = Status != null;
			HasBotInfoVersion = BotInfoVersion != null;
			HasRestrictionReason = RestrictionReason != null;
			HasBotInlinePlaceholder = BotInlinePlaceholder != null;
		}
	}
}