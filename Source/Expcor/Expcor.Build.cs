// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Expcor : ModuleRules
{
	public Expcor(ReadOnlyTargetRules Target) : base(Target)
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
			"Expcor",
			"Expcor/Variant_Platforming",
			"Expcor/Variant_Platforming/Animation",
			"Expcor/Variant_Combat",
			"Expcor/Variant_Combat/AI",
			"Expcor/Variant_Combat/Animation",
			"Expcor/Variant_Combat/Gameplay",
			"Expcor/Variant_Combat/Interfaces",
			"Expcor/Variant_Combat/UI",
			"Expcor/Variant_SideScrolling",
			"Expcor/Variant_SideScrolling/AI",
			"Expcor/Variant_SideScrolling/Gameplay",
			"Expcor/Variant_SideScrolling/Interfaces",
			"Expcor/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
