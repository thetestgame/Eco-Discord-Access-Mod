// Copyright (c) Jordan Maxwell. All rights reserved.
// The Discord Access Mod for Eco is available under the MIT license.
// A copy of this license can be found in the repository root or at https://github.com/thetestgame/Eco-Discord-Access-Mod/blob/master/LICENSE

namespace Eco.DiscordAccessMod
{
    /// <summary>Represents a linked Discord/Eco user inside the Litedb database.</summary>
    public class DiscordEcoLink
    {
        /// <summary>Represents the user's Discord identifier.</summary>
        public ulong DiscordId { get; set; }
    
        /// <summary>Represents the user's Eco username.</summary>
        public string EcoUsername { get; set; }
    }
}
