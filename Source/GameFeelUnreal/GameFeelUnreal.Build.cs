// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GameFeelUnreal : ModuleRules
{
	public GameFeelUnreal(ReadOnlyTargetRules Target) : base(Target)
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
			"GameFeelUnreal",
			"GameFeelUnreal/Variant_Platforming",
			"GameFeelUnreal/Variant_Platforming/Animation",
			"GameFeelUnreal/Variant_Combat",
			"GameFeelUnreal/Variant_Combat/AI",
			"GameFeelUnreal/Variant_Combat/Animation",
			"GameFeelUnreal/Variant_Combat/Gameplay",
			"GameFeelUnreal/Variant_Combat/Interfaces",
			"GameFeelUnreal/Variant_Combat/UI",
			"GameFeelUnreal/Variant_SideScrolling",
			"GameFeelUnreal/Variant_SideScrolling/AI",
			"GameFeelUnreal/Variant_SideScrolling/Gameplay",
			"GameFeelUnreal/Variant_SideScrolling/Interfaces",
			"GameFeelUnreal/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
