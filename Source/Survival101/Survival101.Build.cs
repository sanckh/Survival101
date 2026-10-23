// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Survival101 : ModuleRules
{
	public Survival101(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Survival101",
			"Survival101/Variant_Platforming",
			"Survival101/Variant_Platforming/Animation",
			"Survival101/Variant_Combat",
			"Survival101/Variant_Combat/AI",
			"Survival101/Variant_Combat/Animation",
			"Survival101/Variant_Combat/Gameplay",
			"Survival101/Variant_Combat/Interfaces",
			"Survival101/Variant_Combat/UI",
			"Survival101/Variant_SideScrolling",
			"Survival101/Variant_SideScrolling/AI",
			"Survival101/Variant_SideScrolling/Gameplay",
			"Survival101/Variant_SideScrolling/Interfaces",
			"Survival101/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
