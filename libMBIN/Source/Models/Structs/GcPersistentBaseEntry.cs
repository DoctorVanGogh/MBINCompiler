﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcPersistentBaseEntry : NMSTemplate        // size: 0x90
    {
        /* 0x00 */ public ulong Timestamp;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string ObjectId;
        /* 0x18 */ public ulong UserData;
        /* 0x20 */ public Vector4f Position;
        /* 0x30 */ public Vector4f Up;
        /* 0x40 */ public Vector4f At;
        [NMS(Size = 0x40)]
        /* 0x50 */ public string Message;
    }
}
