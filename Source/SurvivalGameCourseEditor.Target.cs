// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class SurvivalGameCourseEditorTarget : TargetRules
{   
	public SurvivalGameCourseEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
        BuildEnvironment = TargetBuildEnvironment.Shared;
        bOverrideBuildEnvironment = true;


        ExtraModuleNames.AddRange( new string[] { "SurvivalGameCourse" } );
        bUsesSteam = true;
        GlobalDefinitions.Add("UE5_PROJECT_STEAMGAMEDIR=\"spacewar\"");

    }
}
