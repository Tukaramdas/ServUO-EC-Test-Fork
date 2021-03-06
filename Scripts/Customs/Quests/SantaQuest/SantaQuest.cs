//Created by Milva
//////////////////////////////////////////////////////////////////////
// Automatically generated by Bradley's GumpStudio and roadmaster's 
// exporter.dll,  Special thanks goes to Daegon whose work the exporter
// was based off of, and Shadow wolf for his Template Idea.
//////////////////////////////////////////////////////////////////////
#define RunUo2_0

using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Commands;

namespace Server.Gumps
{
    public class  SantaQuestGump : Gump
    {
        public static void Initialize()
        {
            CommandSystem.Register(" SantaQuestGump", AccessLevel.GameMaster, new CommandEventHandler(SantaQuestGump_OnCommand));
		} 
		
		private static void  SantaQuestGump_OnCommand( CommandEventArgs e ) 
		{ 
			e.Mobile.SendGump( new  SantaQuestGump( e.Mobile ) ); 
		}

        public SantaQuestGump(Mobile owner)
            : base(50, 50) 
		{
            this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
            AddPage(0);
            AddImageTiled(14, 10, 377, 433, 2524);
            AddImageTiled(14, 425, 379, 18, 3501);
            AddImage(14, 18, 2712, 37);
            AddImage(14, 220, 2712, 37);
            AddTextEntry(120, 44, 167, 25, 33, 0, @"Santa  Quest!");
            AddHtml(35, 83, 346, 281, "<BODY>" +	
"<BASEFONT COLOR=Red>Ho HO Ho Merry Christmas!<BR><BR>" +
"<BASEFONT COLOR=Red>Well.. it was Merry until about 20 minutes ago<BR><BR>" +
"<BASEFONT COLOR=Red>My elf's just reported an evil elf luking about!<BR>" +
"<BASEFONT COLOR=Red>So they decided to inspect the toy shop!!<BR>" +
"<BASEFONT COLOR=Red>Low and behold that evil elf stole,..<BR><BR>" +
"<BASEFONT COLOR=Red>Our last barrel of red paint!!!.<BR><BR>" +
"<BASEFONT COLOR=Red>We really need that barrel of paint to finish up the toys!...<BR><BR>" +
"<BASEFONT COLOR=Red>Please if you can find that elf and bring it back to me!.<BR><BR>" +
"<BASEFONT COLOR=Red>I will reward you with my Santa Gift Box!.<BR><BR>" +
"<BASEFONT COLOR=Red>You should check out Deceit Dungeon!<BR><BR>" +
"<BASEFONT COLOR=Red>Which would be the perfect place for an evil elf!<BR><BR>" +
                             "</BODY>", false, true);
            AddImageTiled(14, 7, 379, 18, 3501);
            AddItem(44, 17, 14943);
            AddItem(311, 17, 14951);
            AddItem(61, 361, 14983);
            AddItem(79, 357, 14984);
		
            AddButton(163, 385, 247, 248, 0, GumpButtonType.Reply, 0);

        }
       

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            Mobile from = sender.Mobile;

            switch(info.ButtonID)
            {
                case 0:
				{
					break;
				}

            }
        }
    }
}