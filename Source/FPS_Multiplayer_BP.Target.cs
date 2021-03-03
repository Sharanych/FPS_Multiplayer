// Sharanych, 2021

using UnrealBuildTool;
using System.Collections.Generic;

public class FPS_Multiplayer_BPTarget : TargetRules
{
	public FPS_Multiplayer_BPTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
        bUsesSteam = true;

        ExtraModuleNames.AddRange( new string[] { "FPS_Multiplayer_BP" } );
	}
}
