using System;
using System.Collections.Generic;
using ArkabaleN.Managers;

namespace ArkabaleN.Other
{
    internal class Offsets
    {
        public static List<string> ScanPatterns()
        {
            List<string> outdatedSignatures = new List<string> { };

            dwGlowObjectManager = MemoryManager.ScanPattern((int)Structs.Base.Client, "A1????????A801754B", 1, 4, true);
            dwEntityList = MemoryManager.ScanPattern((int)Structs.Base.Client, "BB????????83FF010F8C????????3BF8", 1, 0, true);
            dwClientState = MemoryManager.ScanPattern((int)Structs.Base.Engine, "A1????????33D26A006A0033C989B0", 1, 0, true);
            dwForceAttack = MemoryManager.ScanPattern((int)Structs.Base.Client, "890D????????8B0D????????8BF28BC183CE04", 2, 0, true);
            dwForceAttack2 = MemoryManager.ScanPattern((int)Structs.Base.Client, "890D????8B0D????8BF28BC183CE04", 2, 0, true);
            dwForceJump = MemoryManager.ScanPattern((int)Structs.Base.Client, "8B0D????????8BD68BC183CA02", 2, 0, true);
            dwForceLeft = MemoryManager.ScanPattern((int)Structs.Base.Client, "558BEC51538A5D08", 465, 0, true);
            dwForceRight = MemoryManager.ScanPattern((int)Structs.Base.Client, "558BEC51538A5D08", 512, 0, true);
            dwLocalPlayer = MemoryManager.ScanPattern((int)Structs.Base.Client, "8D3485????????8915????????8B41088B480483F9FF", 3, 4, true);
            dwRadarBase = MemoryManager.ScanPattern((int)Structs.Base.Client, "A1????????8B0CB08B01FF50??463B35????????7CEA8B0D", 1, 0, true);
            return outdatedSignatures;
        }

        #region Netvars
        public const Int32 cs_gamerules_data = 0x0;
        public const Int32 m_ArmorValue = 0xB328;
        public const Int32 m_Collision = 0x31C;
        public const Int32 m_CollisionGroup = 0x474;
        public const Int32 m_Local = 0x2FBC;
        public const Int32 m_MoveType = 0x25C;
        public const Int32 m_OriginalOwnerXuidHigh = 0x31B4;
        public const Int32 m_OriginalOwnerXuidLow = 0x31B0;
        public const Int32 m_SurvivalGameRuleDecisionTypes = 0x1320;
        public const Int32 m_SurvivalRules = 0xCF8;
        public const Int32 m_aimPunchAngle = 0x302C;
        public const Int32 m_aimPunchAngleVel = 0x3038;
        public const Int32 m_angEyeAnglesX = 0xB32C;
        public const Int32 m_angEyeAnglesY = 0xB330;
        public const Int32 m_bBombPlanted = 0x99D;
        public const Int32 m_bFreezePeriod = 0x20;
        public const Int32 m_bGunGameImmunity = 0x3928;
        public const Int32 m_bHasDefuser = 0xB338;
        public const Int32 m_bHasHelmet = 0xB31C;
        public const Int32 m_bInReload = 0x3285;
        public const Int32 m_bIsDefusing = 0x3914;
        public const Int32 m_bIsQueuedMatchmaking = 0x74;
        public const Int32 m_bIsScoped = 0x390A;
        public const Int32 m_bIsValveDS = 0x75;
        public const Int32 m_bSpotted = 0x93D;
        public const Int32 m_bSpottedByMask = 0x980;
        public const Int32 m_bStartedArming = 0x33C0;
        public const Int32 m_clrRender = 0x70;
        public const Int32 m_dwBoneMatrix = 0x26A8;
        public const Int32 m_fAccuracyPenalty = 0x3304;
        public const Int32 m_fFlags = 0x104;
        public const Int32 m_flC4Blow = 0x2990;
        public const Int32 m_flDefuseCountDown = 0x29AC;
        public const Int32 m_flDefuseLength = 0x29A8;
        public const Int32 m_flFallbackWear = 0x31C0;
        public const Int32 m_flFlashDuration = 0xA3E0;
        public const Int32 m_flFlashMaxAlpha = 0xA3DC;
        public const Int32 m_flLastBoneSetupTime = 0x2924;
        public const Int32 m_flLowerBodyYawTarget = 0x3A74;
        public const Int32 m_flNextAttack = 0x2D70;
        public const Int32 m_flNextPrimaryAttack = 0x3218;
        public const Int32 m_flSimulationTime = 0x268;
        public const Int32 m_flTimerLength = 0x2994;
        public const Int32 m_hActiveWeapon = 0x2EF8;
        public const Int32 m_hMyWeapons = 0x2DF8;
        public const Int32 m_hObserverTarget = 0x3388;
        public const Int32 m_hOwner = 0x29CC;
        public const Int32 m_hOwnerEntity = 0x14C;
        public const Int32 m_iAccountID = 0x2FC8;
        public const Int32 m_iClip1 = 0x3244;
        public const Int32 m_iCompetitiveRanking = 0x1A84;
        public const Int32 m_iCompetitiveWins = 0x1B88;
        public const Int32 m_iCrosshairId = 0xB394;
        public const Int32 m_iEntityQuality = 0x2FAC;
        public const Int32 m_iFOV = 0x31E4;
        public const Int32 m_iFOVStart = 0x31E8;
        public const Int32 m_iGlowIndex = 0xA3F8;
        public const Int32 m_iHealth = 0x100;
        public const Int32 m_iItemDefinitionIndex = 0x2FAA;
        public const Int32 m_iItemIDHigh = 0x2FC0;
        public const Int32 m_iMostRecentModelBoneCounter = 0x2690;
        public const Int32 m_iObserverMode = 0x3374;
        public const Int32 m_iShotsFired = 0xA370;
        public const Int32 m_iState = 0x3238;
        public const Int32 m_iTeamNum = 0xF4;
        public const Int32 m_lifeState = 0x25F;
        public const Int32 m_nFallbackPaintKit = 0x31B8;
        public const Int32 m_nFallbackSeed = 0x31BC;
        public const Int32 m_nFallbackStatTrak = 0x31C4;
        public const Int32 m_nForceBone = 0x268C;
        public const Int32 m_nTickBase = 0x342C;
        public const Int32 m_rgflCoordinateFrame = 0x444;
        public const Int32 m_szCustomName = 0x303C;
        public const Int32 m_szLastPlaceName = 0x35B0;
        public const Int32 m_thirdPersonViewAngles = 0x31D8;
        public const Int32 m_vecOrigin = 0x138;
        public const Int32 m_vecVelocity = 0x114;
        public const Int32 m_vecViewOffset = 0x108;
        public const Int32 m_viewPunchAngle = 0x3020;
        #endregion

        #region Signatures
        public const Int32 dwClientState_ViewAngles = 0x4D88;
        public const Int32 dwClientState_State = 0x108;
        public const Int32 dwClientState_MaxPlayer = 0x388;

        public static Int32 dwGlowObjectManager;
        public static Int32 dwEntityList;
        public static Int32 dwClientState;
        public static Int32 dwForceJump;
        public static Int32 dwLocalPlayer;
        public static Int32 dwRadarBase;
        public static Int32 dwForceAttack;
        public static Int32 dwForceAttack2;
        public static Int32 dwForceLeft;
        public static Int32 dwForceRight;

        public const Int32 m_dwRadarBasePointer = 0x6C;
        public const Int32 m_dwRadarStructSize = 0x168;
        public const Int32 m_dwRadarStructPos = 0x18;
        #endregion
        public const Int32 IsMenu = 0x8AC77C;

    }
}
