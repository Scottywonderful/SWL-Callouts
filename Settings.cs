﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rage;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SWLCallouts
{
    internal static class Settings
    {
        // Check the department
        internal static string Department = "police"; // Default to police department //
        // Callouts below //
        internal static bool HighSpeedChase = true;
        internal static bool WelfareCheck = true;
        // Extras below //
        internal static bool ActivateAIBackup = true;
        internal static bool HelpMessages = true;
        // Keys below //
        internal static Keys EndCall = Keys.End;
        internal static Keys Dialog = Keys.Y;

        internal static void LoadSettings()
        {
            // Read settings from INI file
            Game.LogTrivial("[LOG]: Loading config file from SWLCallouts.");
            var path = "Plugins/LSPDFR/SWLCallouts/SWLCallouts.ini";
            var ini = new InitializationFile(path);
            ini.Create();
            // Callouts below //
            HighSpeedChase = ini.ReadBoolean("Callouts", "HighSpeedChase", true);
            WelfareCheck = ini.ReadBoolean("Callouts", "WelfareCheck", true);
            // Settings Below //
            Department = ini.ReadString("Settings", "Department", "police"); // Default to police department if not specified //
            ActivateAIBackup = ini.ReadBoolean("Settings", "ActivateAIBackup", true);
            ActivateAIBackup = ini.ReadBoolean("Settings", "HelpMessages", true);
            // Keys Below //
            EndCall = ini.ReadEnum("Keys", "EndCall", Keys.End);
            Dialog = ini.ReadEnum("Keys", "Dialog", Keys.Y);
        }
        public static readonly string PluginVersion = "A0.2.0";
    }
}