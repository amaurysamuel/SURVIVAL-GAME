// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class SurvivalGameCourseServerTarget : TargetRules
{
    public SurvivalGameCourseServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;

        DefaultBuildSettings = BuildSettingsVersion.V2;
        BuildEnvironment = TargetBuildEnvironment.Shared;
        bOverrideBuildEnvironment = true;


        ExtraModuleNames.Add("SurvivalGameCourse");
        bUsesSteam = true;
        GlobalDefinitions.Add("UE5_PROJECT_STEAMGAMEDESC=\"Survival Craft\"");
        GlobalDefinitions.Add("UE5_PROJECT_STEAMPRODUCTNAME=\"spacewar\"");
        GlobalDefinitions.Add("UE5_PROJECT_STEAMGAMEDIR=\"spacewar\"");
    }
}
