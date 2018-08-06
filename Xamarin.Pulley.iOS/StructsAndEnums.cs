using System;
using ObjCRuntime;

namespace Xamarin.Pulley.iOS {
	[Native]
    public enum PulleyPosition : ulong
    {
        Collapsed = 0,
        PartiallyRevealed = 1,
        Open = 2,
        Closed = 3
    }   
}
