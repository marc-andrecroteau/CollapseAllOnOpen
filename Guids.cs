// Guids.cs
// MUST match guids.h
using System;

namespace Crotz.CollapseAllOnOpen
{
    static class GuidList
    {
        public const string guidCollapseAllOnOpenPkgString = "181eef7a-4fb4-4b6e-9c1b-90c8a87f3fbf";
        public const string guidCollapseAllOnOpenCmdSetString = "d6807f57-7b70-4757-a8fa-cac013f8322a";

        public static readonly Guid guidCollapseAllOnOpenCmdSet = new Guid(guidCollapseAllOnOpenCmdSetString);
    };
}