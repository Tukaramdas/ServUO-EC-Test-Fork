using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;

namespace Server.Mobiles
{
	[CorpseName( "death plague spawn corpse" )]
	public class DeathsPlagueSpawn : BaseCreature
	{
		private Mobile m_Owner;
		private DateTime m_ExpireTime;

		[CommandProperty( AccessLevel.GameMaster )]
		public Mobile Owner
		{
			get{ return m_Owner; }
			set{ m_Owner = value; }
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public DateTime ExpireTime
		{
			get{ return m_ExpireTime; }
			set{ m_ExpireTime = value; }
		}

		[Constructable]
		public DeathsPlagueSpawn() : this( null )
		{
		}

		public override bool AlwaysMurderer{ get{ return true; } }

		public override void DisplayPaperdollTo(Mobile to)
		{
		}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
		{
			base.GetContextMenuEntries( from, list );

			for ( int i = 0; i < list.Count; ++i )
			{
				if ( list[i] is ContextMenus.PaperdollEntry )
					list.RemoveAt( i-- );
			}
		}

		public override void OnThink()
		{
			bool expired;

			expired = ( DateTime.Now >= m_ExpireTime );

			if ( !expired && m_Owner != null )
				expired = m_Owner.Deleted || Map != m_Owner.Map || !InRange( m_Owner, 16 );

			if ( expired )
			{
				PlaySound( GetIdleSound() );
				Delete();
			}
			else
			{
				base.OnThink();
			}
		}

		public DeathsPlagueSpawn( Mobile owner ) : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			m_Owner = owner;
			m_ExpireTime = DateTime.Now + TimeSpan.FromMinutes( 0.3 );

			Name = "death plague spawn";
			Hue = Utility.Random( 0x11, 15 );

			switch ( Utility.Random( 12 ) )
			{
				case 0: // earth elemental
					Body = 14;
					BaseSoundID = 268;
					break;
				case 1: // headless one
					Body = 31;
					BaseSoundID = 0x39D;
					break;
				case 2: // person
					Body = Utility.RandomList( 400, 401 );
					break;
				case 3: // gorilla
					Body = 0x1D;
					BaseSoundID = 0x9E;
					break;
				case 4: // serpent
					Body = 0x15;
					BaseSoundID = 0xDB;
					break;
				default:
				case 5: // slime
					Body = 51;
					BaseSoundID = 456;
					break;
			}

			SetStr( 201, 300 );
			SetDex( 180 );
			SetInt( 16, 20 );

			SetHits( 1210, 1800 );

			SetDamage( 25, 45 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 55, 75 );
			SetResistance( ResistanceType.Fire, 50, 70 );
			SetResistance( ResistanceType.Cold, 55, 75 );
			SetResistance( ResistanceType.Poison, 75, 85 );
			SetResistance( ResistanceType.Energy, 55, 75 );

			SetSkill( SkillName.MagicResist, 85.0 );
			SetSkill( SkillName.Tactics, 75.0 );
			SetSkill( SkillName.Wrestling, 90.0 );

			Fame = 1000;
			Karma = -1000;

			VirtualArmor = 60;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Poor );
			AddLoot( LootPack.Gems );
		}

        public DeathsPlagueSpawn(Serial serial)
            : base(serial)
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}