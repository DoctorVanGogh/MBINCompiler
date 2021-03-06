﻿namespace libMBIN.Models.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcMissionSequenceBounty : NMSTemplate      // size: 0x210
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string MessageGetToSpace;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string MessageEngage;
        [NMS(Size = 0x80)]
        /* 0x100 */ public string MessageDestroy;
        [NMS(Size = 0x10)]
        /* 0x180 */ public string Bounty;
        [NMS(Size = 0x80)]
        /* 0x190 */ public string DebugText;
    }
}
