﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

namespace GosuMechanicsYasuo
{
    class Yasuo
    {
        public static Vector2 spot1 = new Vector2(7372, 5858);
        public static Vector2 spot2 = new Vector2(8222, 3158);
        public static Vector2 spot3 = new Vector2(3674, 7058);
        public static Vector2 spot4 = new Vector2(3788, 7422);
        public static Vector2 spot5 = new Vector2(8372, 9606);
        public static Vector2 spot6 = new Vector2(6650, 11766);
        public static Vector2 spot7 = new Vector2(1678, 8428);
        public static Vector2 spot8 = new Vector2(10822, 7456);
        public static Vector2 spot9 = new Vector2(11160, 7504);
        public static Vector2 spot10 = new Vector2(6424, 5208);
        public static Vector2 spot11 = new Vector2(13172, 6508);
        public static Vector2 spot12 = new Vector2(11222, 7856);
        public static Vector2 spot13 = new Vector2(10372, 8456);
        public static Vector2 spot14 = new Vector2(4324, 6258);
        public static Vector2 spot15 = new Vector2(6488, 11192);
        public static Vector2 spot16 = new Vector2(7672, 8906);
        public static float LastMoveC;
        public static void WallJump()
        {
            if (Program.myHero.Distance(spot1) <= 150)
            {
                MoveToLimited(spot1.To3D());
                if (Program.myHero.ServerPosition.Equals(spot1.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(7110, 5612).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot1.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot2) <= 150)
            {
                MoveToLimited(spot2.To3D());
                if (Program.myHero.ServerPosition.Equals(spot2.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(8372, 2908).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot2.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot3) <= 150)
            {
                MoveToLimited(spot3.To3D());
                if (Program.myHero.ServerPosition.Equals(spot3.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(3674, 6708).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot3.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot4) <= 150)
            {
                MoveToLimited(spot4.To3D());
                if (Program.myHero.ServerPosition.Equals(spot4.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(3774, 7706).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot4.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot5) <= 150)
            {
                MoveToLimited(spot5.To3D());
                if (Program.myHero.ServerPosition.Equals(spot5.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(7923, 9351).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot5.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot6) <= 150)
            {
                MoveToLimited(spot6.To3D());
                if (Program.myHero.ServerPosition.Equals(spot6.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(6426, 12138).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot6.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot7) <= 150)
            {
                MoveToLimited(spot7.To3D());
                if (Program.myHero.ServerPosition.Equals(spot7.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(2050, 8416).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot7.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot8) <= 150)
            {
                MoveToLimited(spot8.To3D());
                if (Program.myHero.ServerPosition.Equals(spot8.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(10894, 7192).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot8.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot9) <= 150)
            {
                MoveToLimited(spot9.To3D());
                if (Program.myHero.ServerPosition.Equals(spot9.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(11172, 7208).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot9.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot10) <= 150)
            {
                MoveToLimited(spot10.To3D());
                if (Program.myHero.ServerPosition.Equals(spot10.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(6824, 5308).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot10.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot11) <= 150)
            {
                MoveToLimited(spot11.To3D());
                if (Program.myHero.ServerPosition.Equals(spot11.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(12772, 6458).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot11.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot12) <= 150)
            {
                MoveToLimited(spot12.To3D());
                if (Program.myHero.ServerPosition.Equals(spot12.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(11072, 8156).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot12.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot13) <= 150)
            {
                MoveToLimited(spot13.To3D());
                if (Program.myHero.ServerPosition.Equals(spot13.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(10772, 8456).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot13.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot14) <= 150)
            {
                MoveToLimited(spot14.To3D());
                if (Program.myHero.ServerPosition.Equals(spot14.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(4024, 6358).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot14.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot15) <= 150)
            {
                MoveToLimited(spot15.To3D());
                if (Program.myHero.ServerPosition.Equals(spot15.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(66986, 10910).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot15.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
            if (Program.myHero.Distance(spot16) <= 150)
            {
                MoveToLimited(spot16.To3D());
                if (Program.myHero.ServerPosition.Equals(spot16.To3D()) && Program.W.IsReady())
                {
                    Program.W.Cast(new Vector2(7822, 9306).To3D(), true);
                }
                var jminions = MinionManager.GetMinions(Program.myHero.ServerPosition, Program.E.Range, MinionTypes.All, MinionTeam.Neutral);
                foreach (var jungleMobs in jminions.Where(x => x.IsValidTarget(Program.Q3.Range)))
                {
                    if (jungleMobs == null)
                    {
                        return;
                    }
                    if (Program.myHero.ServerPosition.Equals(spot16.To3D()) && jungleMobs.IsVisible && Program.E.IsReady() && jungleMobs != null && jungleMobs.IsValidTarget(Program.E.Range) && Program.CanCastE(jungleMobs))
                    {
                        Program.E.CastOnUnit(jungleMobs);
                    }
                }
            }
        }
        private static void MoveToLimited(Vector3 where)
        {
            if (Environment.TickCount - LastMoveC < 80)
            {
                return;
            }
            LastMoveC = Environment.TickCount;
            Program.myHero.IssueOrder(GameObjectOrder.MoveTo, where);
        }
    }
}
