
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class Desk3Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Desk3AddonDeed();
			}
		}

		[ Constructable ]
		public Desk3Addon()
		{



			AddComplexComponent( (BaseAddon) this, 2947, 0, 0, 0, 2127, -1, "Desk", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2949, -1, 1, 0, 2127, -1, "Desk", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2950, 0, 1, 0, 2127, -1, "Desk", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2612, -1, 0, 4, 2127, -1, "Desk", 1);// 4
			AddComplexComponent( (BaseAddon) this, 7802, -1, 1, 4, 2127, -1, "Desk", 1);// 5
			AddComplexComponent( (BaseAddon) this, 7802, -1, 1, 11, 2127, -1, "Desk", 1);// 6
			AddComplexComponent( (BaseAddon) this, 2950, -1, 0, 0, 2127, -1, "Desk", 1);// 7
			AddComplexComponent( (BaseAddon) this, 7792, -1, 1, 13, 2127, -1, "Desk", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2950, 1, 1, 0, 2127, -1, "Desk", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2948, 2, 1, 0, 2127, -1, "Desk", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2947, 2, 0, 0, 2127, -1, "Desk", 1);// 11

		}

		public Desk3Addon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class Desk3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Desk3Addon();
			}
		}

		[Constructable]
		public Desk3AddonDeed()
		{
			Name = "Desk3";
		}

		public Desk3AddonDeed( Serial serial ) : base( serial )
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