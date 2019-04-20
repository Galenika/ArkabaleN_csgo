using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ArkabaleN.Other;

namespace ArkabaleN.Managers
{
    internal class ReaderManager
    {
        public static void Run()
        {
            while (true)
            {
                Thread.Sleep(5);

                /*
                 * LocalPlayer
                 */
                Structs.LocalPlayer.Base = MemoryManager.ReadMemory<int>(Structs.Base.Client + Offsets.dwLocalPlayer);

                Structs.LocalPlayer_t localPlayerStruct = MemoryManager.ReadMemory<Structs.LocalPlayer_t>(Structs.LocalPlayer.Base);

                Structs.LocalPlayer.LifeState = localPlayerStruct.LifeState;

                Structs.LocalPlayer.Health = localPlayerStruct.Health;

                Structs.LocalPlayer.Flags = localPlayerStruct.Flags;

                Structs.LocalPlayer.MoveType = localPlayerStruct.MoveType;

                Structs.LocalPlayer.Team = localPlayerStruct.Team;

                Structs.LocalPlayer.CrosshairID = localPlayerStruct.CrosshairID;

                Structs.LocalPlayer.ShotsFired = localPlayerStruct.ShotsFired;

                Structs.LocalPlayer.Position = localPlayerStruct.Position;

                Structs.LocalPlayer.AimPunch = localPlayerStruct.AimPunch;

                Structs.LocalPlayer.VecView = localPlayerStruct.VecView;

                /*
                 * ClientState
                 */
                Structs.ClientState.Base = MemoryManager.ReadMemory<int>(Structs.Base.Engine + Offsets.dwClientState);

                Structs.ClientState_t clientStateStruct = MemoryManager.ReadMemory<Structs.ClientState_t>(Structs.ClientState.Base);

                Structs.ClientState.GameState = clientStateStruct.GameState;

                Structs.ClientState.ViewAngles = clientStateStruct.ViewAngles;

                Structs.ClientState.MaxPlayers = clientStateStruct.MaxPlayers;


            }
        }
    }
}
