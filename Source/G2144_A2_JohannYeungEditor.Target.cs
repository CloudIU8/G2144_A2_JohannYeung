// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class G2144_A2_JohannYeungEditorTarget : TargetRules
{
	public G2144_A2_JohannYeungEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "G2144_A2_JohannYeung" } );
	}
}
