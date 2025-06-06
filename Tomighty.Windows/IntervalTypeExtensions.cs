//
//  Tomighty - http://www.tomighty.org
//
//  This software is licensed under the Apache License Version 2.0:
//  http://www.apache.org/licenses/LICENSE-2.0.txt
//

using System;
using Tomighty.Windows.Properties;
using Tomighty.Windows.Resources;

namespace Tomighty.Windows
{
    internal static class IntervalTypeExtensions
    {
        public static string GetName(this IntervalType intervalType)
        {
            switch (intervalType)
            {
                case IntervalType.Pomodoro: return Misc.String_Pomodoro;
                case IntervalType.ShortBreak: return Misc.String_ShortBreak;
                case IntervalType.LongBreak: return Misc.String_LongBreak;
                default: throw new ArgumentException($"Unknown interval type: {intervalType}");
            }
        }
    }
}
