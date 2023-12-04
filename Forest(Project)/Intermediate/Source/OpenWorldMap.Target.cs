using UnrealBuildTool;

public class OpenWorldMapTarget : TargetRules
{
	public OpenWorldMapTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("OpenWorldMap");
	}
}
