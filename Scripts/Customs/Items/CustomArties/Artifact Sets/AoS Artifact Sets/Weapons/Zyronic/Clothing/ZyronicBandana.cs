using System;
using Server;

namespace Server.Items
{
	public class ZyronicBandana : Bandana
	{
		public override int LabelNumber{ get{ return 1061088; } } // Zyronic Bandana
		public override int ArtifactRarity{ get{ return 11; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public ZyronicBandana()
		{
			Name = "Zyronic Bandana";
		
			Hue = 0x485;
			Attributes.RegenHits = 5;
			Attributes.AttackChance = 5;
			Attributes.WeaponDamage = 10;
		}

		public ZyronicBandana( Serial serial ) : base( serial )
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