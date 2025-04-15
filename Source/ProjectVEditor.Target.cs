// Copyright BBAGWANG. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectVEditorTarget : TargetRules
{
	public ProjectVEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
		ExtraModuleNames.Add("ProjectV");
	}
}
