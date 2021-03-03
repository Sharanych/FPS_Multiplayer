// Sharanych, 2021

using UnrealBuildTool;
using System.Collections.Generic;

public class FPS_Multiplayer_BPEditorTarget : TargetRules
{
	public FPS_Multiplayer_BPEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
        bUsesSteam = true;

		ExtraModuleNames.AddRange( new string[] { "FPS_Multiplayer_BP" } );
	}
}
