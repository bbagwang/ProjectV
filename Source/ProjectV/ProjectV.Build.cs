// Copyright BBAGWANG. All Rights Reserved.

using UnrealBuildTool;

public class ProjectV : ModuleRules
{
	public ProjectV(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
