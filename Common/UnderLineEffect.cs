using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FlatmateFinders.Common
{
    // Set Under Line in String
    public class UnderlineEffect : RoutingEffect
    {
        public const string EffectNamespace = "FF";

        public UnderlineEffect() : base($"{EffectNamespace}.{nameof(UnderlineEffect)}")
        {
        }
    }
}
