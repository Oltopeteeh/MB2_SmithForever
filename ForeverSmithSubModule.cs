//using SmithForever;
//using System;
//using System.Collections.Generic;
//using TaleWorlds.CampaignSystem;
////using TaleWorlds.CampaignSystem.SandBox.GameComponents.Map;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace SmithForever
{
    public class ForeverSmithSubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
        }
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);
            gameStarterObject.AddModel(new ForeverSmithModel());
        }
    }
}