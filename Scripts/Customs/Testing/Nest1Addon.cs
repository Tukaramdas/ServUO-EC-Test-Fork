/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class AG_Nest1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AG_Nest1AddonDeed();
			}
		}

		[ Constructable ]
		public AG_Nest1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 7045 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 7044 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 7043 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 7041 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 7042 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 7046 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 7048 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 7049 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 7050 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 7052 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 7053 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 7053 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 7058 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 7059 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 7063 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 7066 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 7067 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 7054 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 7054 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 7056 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 7054 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 7052 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 7051 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 7050 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 7049 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 7063 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 7056 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 7068 );
			AddComponent( ac, 1, -2, 0 );

		}

		public AG_Nest1Addon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class AG_Nest1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AG_Nest1Addon();
			}
		}

		[Constructable]
		public AG_Nest1AddonDeed()
		{
			Name = "AG_Next1";
		}

		public AG_Nest1AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}
