using System;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x2B02, 0x2B03 )]
	public class Pestilence: BaseQuiver, ITokunoDyable
	{		
	

		
		[Constructable]
		public Pestilence() : base( 0x2B02 )
        {
			Name = "Pestilence";
			Hue = 1151;
            DamageIncrease = 25;
			Attributes.DefendChance = 25;
			Attributes.AttackChance = 25;
			LowerAmmoCost = 50;
			WeightReduction = 50;
		}

		public Pestilence( Serial serial ) : base( serial )
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
	}
}