﻿using System;

namespace MasterChief.DotNet4.Utilities.Enum
{
    [Flags]
    public enum WinStationAccess : uint
    {
        WINSTA_NONE = 0,

        WINSTA_ENUMDESKTOPS = 0x0001,
        WINSTA_READATTRIBUTES = 0x0002,
        WINSTA_ACCESSCLIPBOARD = 0x0004,
        WINSTA_CREATEDESKTOP = 0x0008,
        WINSTA_WRITEATTRIBUTES = 0x0010,
        WINSTA_ACCESSGLOBALATOMS = 0x0020,
        WINSTA_EXITWINDOWS = 0x0040,
        WINSTA_ENUMERATE = 0x0100,
        WINSTA_READSCREEN = 0x0200,

        WINSTA_ALL_ACCESS = WINSTA_ENUMDESKTOPS | WINSTA_READATTRIBUTES | WINSTA_ACCESSCLIPBOARD |
                            WINSTA_CREATEDESKTOP | WINSTA_WRITEATTRIBUTES | WINSTA_ACCESSGLOBALATOMS |
                            WINSTA_EXITWINDOWS | WINSTA_ENUMERATE | WINSTA_READSCREEN |
                            StandardAccess.STANDARD_RIGHTS_REQUIRED,

        GENERIC_ALL = StandardAccess.GENERIC_ALL
    }
}