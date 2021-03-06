using System;
using Server;

namespace Server.Items
{
	public class MagiBandana : Bandana
	{
		public override int LabelNumber{ get{ return 1061088; } } // Magi Bandana
		public override int ArtifactRarity{ get{ return 11; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public MagiBandana()
		{
			Name = "Magi Bandana";
		
			Hue = 0x481;
			Attributes.CastSpeed = 1;
			Attributes.SpellDamage = 5;
			Attributes.RegenMana = 2;
			Attributes.AttackChance = 5;
		}

		public MagiBandana( Serial serial ) : base( serial )
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