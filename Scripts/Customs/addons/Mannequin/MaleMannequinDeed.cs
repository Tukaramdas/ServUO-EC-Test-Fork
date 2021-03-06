using System;
using Server;
using Server.Mobiles;

namespace Server.Items
{

	[Flipable( 0x14F0, 0x14EF )]
	public class MaleMannequinDeed : Item
	{
		[Constructable]
		public MaleMannequinDeed() : base( 0x14F0 )
		{
			Name = "A Male Mannequin Deed";
			LootType = LootType.Blessed;
		}

		public MaleMannequinDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( IsChildOf( from.Backpack ) )
			{
				Mannequin m = new Mannequin( from, false );
				m.Map = from.Map;
				m.Location = from.Location;
				m.Direction = from.Direction;
				this.Delete();
			}
			else
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
		}
	}
}
