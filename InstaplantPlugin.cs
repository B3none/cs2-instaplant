using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Core.Attributes.Registration;

namespace InstaplantPlugin;

[MinimumApiVersion(129)]
public class InstaplantPlugin : BasePlugin
{
    private const string Version = "1.0.0";
    
    public override string ModuleName => "Instaplant Plugin";
    public override string ModuleVersion => Version;
    public override string ModuleAuthor => "B3none";
    public override string ModuleDescription => "Allows a terrorist to instantly plant the bomb.";
    
    [GameEventHandler]
    public HookResult OnBombBeginPlant(EventBombBeginplant @event, GameEventInfo info)
    {
        var bombEntities = Utilities.FindAllEntitiesByDesignerName<CC4>("weapon_c4").ToList();

        if (!bombEntities.Any())
        {
            return HookResult.Continue;
        }

        var bomb = bombEntities.FirstOrDefault();
        if (bomb == null)
        {
            return HookResult.Continue;
        }

        bomb.BombPlacedAnimation = false;
        bomb.ArmedTime = 0.0f;

        return HookResult.Continue;
    }
}
