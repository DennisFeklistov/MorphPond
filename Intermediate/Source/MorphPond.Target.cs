using UnrealBuildTool;

public class MorphPondTarget : TargetRules
{
	public MorphPondTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MorphPond");
	}
}
