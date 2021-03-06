
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
	public class WheelChair4Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WheelChair4AddonDeed();
			}
		}

		[ Constructable ]
		public WheelChair4Addon()
		{



			AddComplexComponent( (BaseAddon) this, 6278, 0, 0, 0, 0, -1, "wheelchair", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6276, 0, 0, 0, 0, -1, "wheelchair", 1);// 2
			AddComplexComponent( (BaseAddon) this, 6278, 1, 0, 1, 0, -1, "wheelchair", 1);// 3
			AddComplexComponent( (BaseAddon) this, 6276, 1, 0, 1, 0, -1, "wheelchair", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2862, 0, 0, 1, 1001, -1, "wheelchair", 1);// 5

		}

		public WheelChair4Addon( Serial serial ) : base( serial )
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

	public class WheelChair4AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WheelChair4Addon();
			}
		}

		[Constructable]
		public WheelChair4AddonDeed()
		{
			Name = "WheelChair4";
		}

		public WheelChair4AddonDeed( Serial serial ) : base( serial )
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