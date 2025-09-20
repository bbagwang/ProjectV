// Copyright BBAGWANG (GyuTae Hong). All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ProjectVEditorTarget : TargetRules
{
	public ProjectVEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;
		ExtraModuleNames.Add("ProjectV");
	}
}
