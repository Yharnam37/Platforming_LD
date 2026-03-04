using UnrealBuildTool;

public class PlatformTestServerTarget : TargetRules
{
	public PlatformTestServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("PlatformTest");
	}
}
