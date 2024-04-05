﻿using StardewModdingAPI;

namespace InstantAnimals
{
    public class ModConfig
    {
        /// <summary>
        /// Indicates if animals should cost their usual resources.
        /// </summary>
        public bool BuyUsesResources { get; set; } = true;

        /// <summary>
        /// Button to open and close the Instant Animals menu
        /// </summary>
        public SButton ToggleInstantBuyMenuButton { get; set; } = SButton.J;

    }
}