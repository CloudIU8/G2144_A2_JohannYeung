// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class G2144_A2_JohannYeungTarget : TargetRules
{
	public G2144_A2_JohannYeungTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "G2144_A2_JohannYeung" } );
	}
}
