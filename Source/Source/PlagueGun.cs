using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace Plague
{
    public class ThingDef_PlagueBullet : ThingDef
    {
        public float AddHediffChance = 0.99f; //The default chance of adding a hediff.
        public HediffDef HediffToAdd = HediffDefOf.Plague;
    }
}
