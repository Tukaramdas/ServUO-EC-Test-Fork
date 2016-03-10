using System;
using Server;

namespace Server.Items
{
	public class LegsOfFrost : StuddedLegs
	{
		public override int LabelNumber{ get{ return 1061098; } } // Legs of Frost
		public override int ArtifactRarity{ get{ return 11; } }
		
		public override int BasePhysicalResistance{ get{ return 15; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public LegsOfFrost()
		{
			Name = "Legs of Frost";
		
			Hue = 0x4F2;
			Attributes.RegenStam = 5;
			Attributes.WeaponDamage = 5;
			Attributes.WeaponSpeed = 15;
		}

		public LegsOfFrost( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}