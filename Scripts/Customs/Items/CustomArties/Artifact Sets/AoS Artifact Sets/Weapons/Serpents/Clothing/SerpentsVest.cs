using System;
using Server;

namespace Server.Items
{
	public class SerpentsVest : JinBaori
	{
		public override int LabelNumber{ get{ return 1061088; } } // Serpents Vest
		public override int ArtifactRarity{ get{ return 11; } }
		
		public override int BasePoisonResistance{ get{ return 5; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public SerpentsVest()
		{
			Name = "Serpents Vest";
		
			Hue = 0x488;
			Attributes.AttackChance = 15;
			Attributes.WeaponDamage = 10;
			Attributes.BonusDex = 5;
			Attributes.RegenStam = 5;
		}

		public SerpentsVest( Serial serial ) : base( serial )
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

			if ( Hue == 0x44F )
				Hue = 0x76D;
		}
	}
}