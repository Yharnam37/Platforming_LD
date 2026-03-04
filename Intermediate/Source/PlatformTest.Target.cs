using UnrealBuildTool;

public class PlatformTestTarget : TargetRules
{
	public PlatformTestTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("PlatformTest");
	}
}
