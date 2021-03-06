using System;
using Server.Network;
using Server.Engines.Quests;
using System.Collections.Generic;
using Server.Mobiles;

namespace Server.Misc
{
    public class LoginStats
    {
        public static void Initialize()
        {
            // Register our event handler
            EventSink.Login += new LoginEventHandler(EventSink_Login);
        }

        private static void EventSink_Login(LoginEventArgs args)
        {
            int userCount = NetState.Instances.Count;
            int itemCount = World.Items.Count;
            int mobileCount = World.Mobiles.Count;

            Mobile m = args.Mobile;

            m.SendMessage("Welcome, {0}! There {1} currently {2} user{3} online, with {4} item{5} and {6} mobile{7} in the world.",
                args.Mobile.Name,
                userCount == 1 ? "is" : "are",
                userCount, userCount == 1 ? "" : "s",
                itemCount, itemCount == 1 ? "" : "s",
                mobileCount, mobileCount == 1 ? "" : "s");

            #region Enhance Client
            List<MondainQuester> listQuester = new List<MondainQuester>();
            List<BaseHealer> listHealers = new List<BaseHealer>();
            foreach (Mobile m_mobile in World.Mobiles.Values)
            {
                MondainQuester mQuester = m_mobile as MondainQuester;
                if (mQuester != null)
                {
                    listQuester.Add(mQuester);
                }

                BaseHealer mHealer = m_mobile as BaseHealer;
                if (mHealer != null)
                {
                    listHealers.Add(mHealer);
                }
            }

            foreach (MondainQuester quester in listQuester)
            {
                if (args.Mobile.NetState != null)
                {
                    string name = string.Empty;
                    if (quester.Name != null)
                    {
                        name += quester.Name;
                    }
                    if (quester.Title != null)
                    {
                        name += " " + quester.Title;
                    }
                    args.Mobile.NetState.Send(new DisplayWaypoint(quester.Serial, quester.X, quester.Y, quester.Z, quester.Map.MapID, WaypointType.QuestGiver, name));
                }
            }
            /* I think on Uo only see healer waypoints if you die. so this is commented out until tested more on Uo TC.
            foreach (BaseHealer healer in listHealers)
            {
                string name = string.Empty;
                if (healer.Name != null)
                    name += healer.Name;
                if (healer.Title != null)
                    name += " " + healer.Title;
                args.Mobile.NetState.Send(new DisplayWaypoint(healer.Serial, healer.X, healer.Y, healer.Z, healer.Map.MapID, WaypointType.Resurrection, name));
            }
             */
            #endregion

            if (m.IsStaff())
            {
                Server.Engines.Help.PageQueue.Pages_OnCalled(m);
            }
        }
    }
}