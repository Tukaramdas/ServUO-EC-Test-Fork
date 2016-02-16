using System;
using Server;
using Server.Gumps;

namespace Server.Gumps
{
	public class SatesFinish : Gump
	{
		public SatesFinish()
			: base( 200, 200 )
		{
			this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
			this.AddPage(0);
			this.AddBackground(0, 0, 353, 118, 9270);
           // AddBackground(85, 30, 329, 408, 3500);
			this.AddAlphaRegion( 2, 2, 349, 114 );
//			this.AddItem(297, 38, 4168);
			this.AddLabel(118, 15, 1149, @"Quest Completed");
			this.AddLabel(48, 39, 255, @"Well done, you have collected all of the");
			this.AddLabel(48, 55, 255, @"items I requested for the Blade.");
			this.AddLabel(48, 71, 255, @"Here it is, May it serve you well.");
//			this.AddItem(12, 38, 4171);

		}
		

	}
}
