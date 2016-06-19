/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;
using Server.Regions;

namespace Server.Items
{
	public class SanctuaryAddon : BaseAddon
	{
		/*private SanctuaryRegion m_Region;
		
		public SanctuaryRegion Region
		{
			get{ return m_Region; }
			set{ m_Region = value; }
		}
		*/
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SanctuaryAddonDeed();
			}
		}

		[ Constructable ]
		public SanctuaryAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3678 );
			AddComponent( ac, -4, -1, 0 );
			ac = new AddonComponent( 3678 );
			AddComponent( ac, 5, -2, 0 );
			ac = new AddonComponent( 3687 );
			AddComponent( ac, 1, -5, 0 );
			ac = new AddonComponent( 3684 );
			AddComponent( ac, -1, -4, 0 );
			ac = new AddonComponent( 3681 );
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 3690 );
			AddComponent( ac, 3, -4, 0 );
			ac = new AddonComponent( 3684 );
			AddComponent( ac, 5, 2, 0 );
			ac = new AddonComponent( 3678 );
			AddComponent( ac, 0, 6, 0 );
			ac = new AddonComponent( 3687 );
			AddComponent( ac, 4, 4, 0 );
			ac = new AddonComponent( 3690 );
			AddComponent( ac, 2, 5, 0 );
			ac = new AddonComponent( 3681 );
			AddComponent( ac, 6, 0, 0 );
			ac = new AddonComponent( 3684 );
			AddComponent( ac, -4, 3, 0 );
			ac = new AddonComponent( 3687 );
			AddComponent( ac, -5, 1, 0 );
			ac = new AddonComponent( 3681 );
			AddComponent( ac, -2, 5, 0 );

		}

		public SanctuaryAddon( Serial serial ) : base( serial )
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
			
			try
			{
				this.Delete();
			}
			
			catch
			{
				Console.WriteLine( "Error while deleting a Sanctuary." );
			}
		}
		
	/*	public override void OnDelete()
		{
			if( this.Region != null )
				this.Region.Unregister();
			
			base.OnDelete();
		}*/
	}

	public class SanctuaryAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SanctuaryAddon();
			}
		}

		[Constructable]
		public SanctuaryAddonDeed()
		{
			Name = "AG_Sanctuary";
		}

		public SanctuaryAddonDeed( Serial serial ) : base( serial )
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
			
			this.Delete();
		}
	}
}