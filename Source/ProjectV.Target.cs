// Copyright BBAGWANG. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectVTarget : TargetRules
{
	public ProjectVTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
		ExtraModuleNames.Add("ProjectV");
	}
}
