using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace WealthWatcher
{
    [StaticConstructorOnStartup]
    public static class Util
    {

        public static readonly Texture2D WealthIcon = ContentFinder<Texture2D>.Get("WealthIcon");

    }
}
