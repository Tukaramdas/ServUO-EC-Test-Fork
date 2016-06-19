using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Mobiles
{
    [CorpseName("a pale horse corpse")]
	public class PaleHorse : BaseMount
	{
		[Constructable]
        public PaleHorse()
            : this("Pale Horse")
		{
		}

		[Constructable]
		public PaleHorse( string name ) : base( name, 0x319, 0x3Ebb, AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			BaseSoundID = 0xA8;
            Hue = 161;
			SetStr( 496, 525 );
			SetDex( 86, 105 );
			SetInt( 86, 125 );

			SetHits( 1798, 1915 );

			SetDamage( 15, 35 );

			SetDamageType( ResistanceType.Physical, 0 );
			SetDamageType( ResistanceType.Fire, 100 );
			SetDamageType( ResistanceType.Energy, 0 );

			SetResistance( ResistanceType.Physical, 55, 65 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 30, 40 );
			SetResistance( ResistanceType.Energy, 20, 30 );

			SetSkill( SkillName.EvalInt, 100.4, 105.0 );
			SetSkill( SkillName.Magery, 101.4, 105.0 );
			SetSkill( SkillName.MagicResist, 110.3, 105.0 );
			SetSkill( SkillName.Tactics, 97.6, 120.0 );
			SetSkill( SkillName.Wrestling, 80.5, 120.0 );

			Fame = 14000;
			Karma = -14000;

			VirtualArmor = 35;

			Tamable = true;
			ControlSlots = 3;
			MinTameSkill = 110.0;

        

			PackItem( new SulfurousAsh( Utility.RandomMinMax( 3, 5 ) ) );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.Average );
			AddLoot( LootPack.LowScrolls );
			AddLoot( LootPack.Potions );
		}

		public override int GetAngerSound()
		{
			if ( !Controlled )
				return 0x16A;

			return base.GetAngerSound();
		}

		public override bool HasBreath{ get{ return true; } } // fire breath enabled
		public override int Meat{ get{ return 5; } }
		public override int Hides{ get{ return 10; } }
		public override HideType HideType{ get{ return HideType.Barbed; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat; } }
		public override bool CanAngerOnTame { get { return true; } }

        public PaleHorse(Serial serial)
            : base(serial)
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

			if ( BaseSoundID == 0x16A )
				BaseSoundID = 0xA8;
		}
	}
}