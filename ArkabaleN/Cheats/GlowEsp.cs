using ArkabaleN.Managers;
using ArkabaleN.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArkabaleN.Cheats
{
    internal class GlowEsp
    {
        public static void Run()
        {
            while (true)
            {
                Thread.Sleep(5);

                if (!Settings.Settings.GlowEsp.Enabled) continue;

                int gCount = MemoryManager.ReadMemory<int>(Structs.Base.Client + Offsets.dwGlowObjectManager + 0x4);

                for (int i = 0; i < gCount; i++)
                {
                    int EntityList = MemoryManager.ReadMemory<int>((int)Structs.Base.Client + Offsets.dwEntityList + (i - 1) * 0x10);
                    int OpponentTeam = MemoryManager.ReadMemory<int>(EntityList + Offsets.m_iTeamNum);
                    bool Dormant = MemoryManager.ReadMemory<bool>(EntityList + Offsets.m_bDormant);

                    if (!Dormant)
                    {
                        int GlowIndex = MemoryManager.ReadMemory<int>(EntityList + Offsets.m_iGlowIndex);
                        if (Settings.Settings.GlowEsp.ShowHealth)
                        {
                            int health = MemoryManager.ReadMemory<int>(EntityList + Offsets.m_iHealth);
                            if (Structs.LocalPlayer.Team != OpponentTeam)
                            {
                                if (health >= 75)
                                {
                                    EnableGlow(GlowIndex,
                                               Settings.Settings.GlowEsp.Red / 255,
                                               Settings.Settings.GlowEsp.Green / 255,
                                               Settings.Settings.GlowEsp.Blue / 255,
                                               Settings.Settings.GlowEsp.Opacity / 255);
                                }
                                else if (health >= 30 && health <= 75)
                                {
                                    EnableGlow(GlowIndex,
                                               219f / 255,
                                               198f / 255,
                                               8f / 255,
                                               Settings.Settings.GlowEsp.Opacity / 255);
                                }
                                else
                                {
                                    EnableGlow(GlowIndex,
                                               206f / 255,
                                               6f / 255,
                                               6f / 255,
                                               Settings.Settings.GlowEsp.Opacity / 255);
                                }
                            }
                            else if (Structs.LocalPlayer.Team == OpponentTeam)
                            {
                                if (Settings.Settings.GlowEsp.ShowTeam)
                                {
                                    EnableGlow(GlowIndex,
                                               5f / 255,
                                               183f / 255,
                                               20f / 255,
                                               Settings.Settings.GlowEsp.Opacity / 255);
                                }
                                else
                                {
                                    EnableGlow(GlowIndex,
                                               Settings.Settings.GlowEsp.Red / 255,
                                               Settings.Settings.GlowEsp.Green / 255,
                                               Settings.Settings.GlowEsp.Blue / 255,
                                               Settings.Settings.GlowEsp.Opacity / 255);
                                }
                            }
                            else
                            {
                                if (Settings.Settings.GlowEsp.ShowTeam)
                                {
                                    EnableGlow(GlowIndex,
                                               5f / 255,
                                               183f / 255,
                                               20f / 255,
                                               Settings.Settings.GlowEsp.Opacity / 255);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void EnableGlow(int GlowIndex, float r, float g, float b, float a)
        {
            int GlowObject = MemoryManager.ReadMemory<int>(Structs.Base.Client + Offsets.dwGlowObjectManager);

            int calculation = GlowIndex * 0x38 + 0x4;

            int current = GlowObject + calculation;
            MemoryManager.WriteMemory<float>(current, r);

            calculation = GlowIndex * 0x38 + 0x8;
            current = GlowObject + calculation;
            MemoryManager.WriteMemory<float>(current, g);

            calculation = GlowIndex * 0x38 + 0xC;
            current = GlowObject + calculation;
            MemoryManager.WriteMemory<float>(current, b);

            calculation = GlowIndex * 0x38 + 0x10;
            current = GlowObject + calculation;
            MemoryManager.WriteMemory<float>(current, a);

            calculation = GlowIndex * 0x38 + 0x24;
            current = GlowObject + calculation;
            MemoryManager.WriteMemory<bool>(current, true);

            calculation = GlowIndex * 0x38 + 0x25;
            current = GlowObject + calculation;
            MemoryManager.WriteMemory<bool>(current, false);

            calculation = GlowIndex * 0x38 + 0x26;
            current = GlowObject + calculation;
            MemoryManager.WriteMemory<bool>(current, false);

        }
    }
}
