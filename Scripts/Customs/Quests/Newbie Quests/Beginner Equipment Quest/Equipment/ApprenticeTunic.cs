using Server;
using System;
using Server.Items;

namespace Server.Items
{
	public class ApprenticeTunic : LeatherChest
	{ 
				
		public override int InitMinHits{ get{ return 125; } }
		public override int InitMaxHits{ get{ return 125; } }

		public override int BasePhysicalResistance{ get{ return 0; } }
		public override int BaseFireResistance{ get{ return 0; } }
		public override int BaseColdResistance{ get{ return 0; } }
		public override int BasePoisonResistance{ get{ return 0; } }
		public override int BaseEnergyResistance{ get{ return 0; } }

		public override int AosStrReq{ get{ return 15; } }
		public override int OldStrReq{ get{ return 15; } } 
		
		[Constructable]
		public ApprenticeTunic()
		{
			Hue = 57;
			Name = "Apprentice Tunic";
			Weight = 5;
			
			Attributes.LowerRegCost = 20;
			Attributes.ReflectPhysical = 10;
			Attributes.Luck = 100;
			
			LootType = LootType.Blessed;
			
			PhysicalBonus = 10;
			FireBonus = 10;
			ColdBonus = 10;
			PoisonBonus = 10;			
			EnergyBonus = 10;
		} 
		
		public ApprenticeTunic( Serial serial ) : base( serial )
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
