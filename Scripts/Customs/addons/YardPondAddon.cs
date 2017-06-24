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
	public class YardPondAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new YardPondAddonDeed();
			}
		}

		[ Constructable ]
		public YardPondAddon()
		{
			AddComponent( new AddonComponent( 3234 ), 2, 3, 0 );
			AddComponent( new AddonComponent( 3211 ), 3, -2, 0 );
			AddComponent( new AddonComponent( 3318 ), -1, 3, 0 );
			AddComponent( new AddonComponent( 3317 ), -2, 3, 0 );
			AddComponent( new AddonComponent( 3232 ), -3, 3, 0 );
			AddComponent( new AddonComponent( 3319 ), 0, 3, 0 );
			AddonComponent ac;
			ac = new AddonComponent( 220 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 221 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 221 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 221 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 221 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 222 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 222 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 222 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 222 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 222 );
			AddComponent( ac, 2, -3, 0 );
			ac = new AddonComponent( 222 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 222 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 222 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 222 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 221 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 221 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 221 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 221 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 221 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 223 );
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, -2, -2, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, -2, -1, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, -2, 0, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, -2, 1, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, -1, -2, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, -1, -1, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, -1, 0, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, -1, 1, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 0, -2, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 0, -1, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 1, -2, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 1, -1, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 1, 0, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 1, 1, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 2, 2, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 2, -2, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 2, -1, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 2, 0, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 2, 1, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, -2, 2, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, -1, 2, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 0, 2, 1 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 1, 2, 1 );
			ac = new AddonComponent( 3518 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 3517 );
			AddComponent( ac, -1, -1, 1 );
			ac = new AddonComponent( 3334 );
			AddComponent( ac, 1, -1, 1 );
			ac = new AddonComponent( 3336 );
			AddComponent( ac, -2, 1, 1 );
			ac = new AddonComponent( 3332 );
			AddComponent( ac, -2, -2, 2 );
			ac = new AddonComponent( 3231 );
			AddComponent( ac, 2, -3, 4 );
			ac = new AddonComponent( 3235 );
			AddComponent( ac, -3, 0, 4 );
			ac = new AddonComponent( 3237 );
			AddComponent( ac, -2, -3, 4 );
			ac = new AddonComponent( 3204 );
			AddComponent( ac, -3, 1, 1 );

		}

		public YardPondAddon( Serial serial ) : base( serial )
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

	public class YardPondAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new YardPondAddon();
			}
		}

		[Constructable]
		public YardPondAddonDeed()
		{
			Name = "Yard Pond";
		}

		public YardPondAddonDeed( Serial serial ) : base( serial )
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