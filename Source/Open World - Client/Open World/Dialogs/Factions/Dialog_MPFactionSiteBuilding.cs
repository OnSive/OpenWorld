﻿using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;
using Verse.Profile;

namespace OpenWorld
{
    public class Dialog_MPFactionSiteBuilding : Window
    {
        public override Vector2 InitialSize => new Vector2(325f, 355f);

        private string windowTitle = "Faction Site";
        private string windowDescription = "Build an utility site for your faction";

        private float buttonX = 150f;
        private float buttonY = 38f;

        bool isBuildingSilo;
        bool isBuildingMarketplace;
        bool isBuildingProductionSite;
        bool isBuildingWonder;

        public Dialog_MPFactionSiteBuilding()
        {
            soundAppear = SoundDefOf.CommsWindow_Open;
            soundClose = SoundDefOf.CommsWindow_Close;
            absorbInputAroundWindow = true;
            forcePause = false;
            closeOnAccept = false;
            closeOnCancel = true;
        }

        public override void DoWindowContents(Rect rect)
        {
            float centeredX = rect.width / 2;

            Text.Font = GameFont.Medium;
            Widgets.Label(new Rect(centeredX - Text.CalcSize(windowTitle).x / 2, rect.y, Text.CalcSize(windowTitle).x, Text.CalcSize(windowTitle).y), windowTitle);

            Widgets.DrawLineHorizontal(rect.xMin, (rect.y + Text.CalcSize(windowTitle).y + 10), rect.width);

            HandleWindowContents(rect);
        }

        private void HandleWindowContents(Rect rect)
        {
            float centeredX = rect.width / 2;

            float windowDescriptionDif = Text.CalcSize(windowDescription).y + StandardMargin;

            float descriptionLineDif = windowDescriptionDif + Text.CalcSize(windowDescription).y;

            if (isBuildingSilo)
            {
                windowDescription = "About silo construction";

                string siteDescription = "Global faction storage";

                string materialList = "Cost: 5000x silver";

                Text.Font = GameFont.Small;
                Widgets.Label(new Rect(centeredX - Text.CalcSize(windowDescription).x / 2, windowDescriptionDif, Text.CalcSize(windowDescription).x, Text.CalcSize(windowDescription).y), windowDescription);

                Widgets.DrawLineHorizontal(rect.x, descriptionLineDif, rect.width);

                Widgets.Label(new Rect(centeredX - Text.CalcSize(siteDescription).x / 2, rect.y + 80, Text.CalcSize(siteDescription).x, Text.CalcSize(siteDescription).y), siteDescription);

                Widgets.Label(new Rect(centeredX - Text.CalcSize(materialList).x / 2, rect.y + 100, Text.CalcSize(materialList).x, Text.CalcSize(materialList).y), materialList);
                Text.Font = GameFont.Medium;

                if (Widgets.ButtonText(new Rect(new Vector2(centeredX - (buttonX / 2) * 2, rect.yMax - buttonY * 2 - 10), new Vector2(buttonX * 2, buttonY)), "Build"))
                {
                    Find.WindowStack.Add(new Dialog_MPFactionSiteBuild(0, 5000));
                    Close();
                }

                if (Widgets.ButtonText(new Rect(new Vector2(centeredX - (buttonX / 2) * 1.5f, rect.yMax - buttonY), new Vector2(buttonX * 1.5f, buttonY)), "Back"))
                {
                    isBuildingSilo = false;
                }
            }

            else if (isBuildingMarketplace)
            {
                windowDescription = "About marketplace construction";

                string siteDescription = "Global trading between members";

                string materialList = "Cost: 7500x silver";

                Text.Font = GameFont.Small;
                Widgets.Label(new Rect(centeredX - Text.CalcSize(windowDescription).x / 2, windowDescriptionDif, Text.CalcSize(windowDescription).x, Text.CalcSize(windowDescription).y), windowDescription);

                Widgets.DrawLineHorizontal(rect.x, descriptionLineDif, rect.width);

                Widgets.Label(new Rect(centeredX - Text.CalcSize(siteDescription).x / 2, rect.y + 80, Text.CalcSize(siteDescription).x, Text.CalcSize(siteDescription).y), siteDescription);

                Widgets.Label(new Rect(centeredX - Text.CalcSize(materialList).x / 2, rect.y + 100, Text.CalcSize(materialList).x, Text.CalcSize(materialList).y), materialList);
                Text.Font = GameFont.Medium;

                if (Widgets.ButtonText(new Rect(new Vector2(centeredX - (buttonX / 2) * 2, rect.yMax - buttonY * 2 - 10), new Vector2(buttonX * 2, buttonY)), "Build"))
                {
                    Find.WindowStack.Add(new Dialog_MPFactionSiteBuild(1, 7500));
                    Close();
                }

                if (Widgets.ButtonText(new Rect(new Vector2(centeredX - (buttonX / 2) * 1.5f, rect.yMax - buttonY), new Vector2(buttonX * 1.5f, buttonY)), "Back"))
                {
                    isBuildingMarketplace = false;
                }
            }

            else if (isBuildingProductionSite)
            {
                windowDescription = "About production site construction";

                string siteDescription = "Passive material generation";

                string materialList = "Cost: 10000x silver";

                Text.Font = GameFont.Small;
                Widgets.Label(new Rect(centeredX - Text.CalcSize(windowDescription).x / 2, windowDescriptionDif, Text.CalcSize(windowDescription).x, Text.CalcSize(windowDescription).y), windowDescription);

                Widgets.DrawLineHorizontal(rect.x, descriptionLineDif, rect.width);

                Widgets.Label(new Rect(centeredX - Text.CalcSize(siteDescription).x / 2, rect.y + 80, Text.CalcSize(siteDescription).x, Text.CalcSize(siteDescription).y), siteDescription);

                Widgets.Label(new Rect(centeredX - Text.CalcSize(materialList).x / 2, rect.y + 100, Text.CalcSize(materialList).x, Text.CalcSize(materialList).y), materialList);
                Text.Font = GameFont.Medium;

                if (Widgets.ButtonText(new Rect(new Vector2(centeredX - (buttonX / 2) * 2, rect.yMax - buttonY * 2 - 10), new Vector2(buttonX * 2, buttonY)), "Build"))
                {
                    Find.WindowStack.Add(new Dialog_MPFactionSiteBuild(2, 10000));
                    Close();
                }

                if (Widgets.ButtonText(new Rect(new Vector2(centeredX - (buttonX / 2) * 1.5f, rect.yMax - buttonY), new Vector2(buttonX * 1.5f, buttonY)), "Back"))
                {
                    isBuildingProductionSite = false;
                }
            }

            else if (isBuildingWonder)
            {
                windowDescription = "About wonder construction";

                string siteDescription = "Unique server structure";

                string materialList = "Cost: 100000x silver";

                Text.Font = GameFont.Small;
                Widgets.Label(new Rect(centeredX - Text.CalcSize(windowDescription).x / 2, windowDescriptionDif, Text.CalcSize(windowDescription).x, Text.CalcSize(windowDescription).y), windowDescription);

                Widgets.DrawLineHorizontal(rect.x, descriptionLineDif, rect.width);

                Widgets.Label(new Rect(centeredX - Text.CalcSize(siteDescription).x / 2, rect.y + 80, Text.CalcSize(siteDescription).x, Text.CalcSize(siteDescription).y), siteDescription);

                Widgets.Label(new Rect(centeredX - Text.CalcSize(materialList).x / 2, rect.y + 100, Text.CalcSize(materialList).x, Text.CalcSize(materialList).y), materialList);
                Text.Font = GameFont.Medium;

                if (Widgets.ButtonText(new Rect(new Vector2(centeredX - (buttonX / 2) * 2, rect.yMax - buttonY * 2 - 10), new Vector2(buttonX * 2, buttonY)), "Build"))
                {
                    Find.WindowStack.Add(new Dialog_MPFactionSiteBuild(3, 100000));
                    Close();
                }

                if (Widgets.ButtonText(new Rect(new Vector2(centeredX - (buttonX / 2) * 1.5f, rect.yMax - buttonY), new Vector2(buttonX * 1.5f, buttonY)), "Back"))
                {
                    isBuildingWonder = false;
                }
            }

            else
            {
                windowDescription = "Build an utility site for your faction";

                Text.Font = GameFont.Small;
                Widgets.Label(new Rect(centeredX - Text.CalcSize(windowDescription).x / 2, windowDescriptionDif, Text.CalcSize(windowDescription).x, Text.CalcSize(windowDescription).y), windowDescription);
                Text.Font = GameFont.Medium;

                Widgets.DrawLineHorizontal(rect.x, descriptionLineDif, rect.width);

                if (Widgets.ButtonText(new Rect(new Vector2(centeredX - (buttonX / 2) * 2, rect.yMax - buttonY * 5 - 40), new Vector2(buttonX * 2, buttonY)), "Resource Silo"))
                {
                    isBuildingSilo = true;
                }

                if (Widgets.ButtonText(new Rect(new Vector2(centeredX - (buttonX / 2) * 2, rect.yMax - buttonY * 4 - 30), new Vector2(buttonX * 2, buttonY)), "Marketplace"))
                {
                    isBuildingMarketplace = true;
                }

                if (Widgets.ButtonText(new Rect(new Vector2(centeredX - (buttonX / 2) * 2, rect.yMax - buttonY * 3 - 20), new Vector2(buttonX * 2, buttonY)), "Production Site"))
                {
                    isBuildingProductionSite = true;
                }

                if (Widgets.ButtonText(new Rect(new Vector2(centeredX - (buttonX / 2) * 2, rect.yMax - buttonY * 2 - 10), new Vector2(buttonX * 2, buttonY)), "Wonder Structure"))
                {
                    isBuildingWonder = true;
                }

                if (Widgets.ButtonText(new Rect(new Vector2(centeredX - (buttonX / 2) * 1.5f, rect.yMax - buttonY), new Vector2(buttonX * 1.5f, buttonY)), "Close"))
                {
                    Close();
                }
            }
        }
    }
}