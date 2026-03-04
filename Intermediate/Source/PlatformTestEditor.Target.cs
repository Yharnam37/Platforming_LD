using UnrealBuildTool;

public class PlatformTestEditorTarget : TargetRules
{
	public PlatformTestEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("PlatformTest");
	}
}
