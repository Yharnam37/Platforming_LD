using UnrealBuildTool;

public class PlatformTestClientTarget : TargetRules
{
	public PlatformTestClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("PlatformTest");
	}
}
