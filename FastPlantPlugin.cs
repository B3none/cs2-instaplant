using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes;
using CounterStrikeSharp.API.Modules.Utils;
using System.Numerics;
using CounterStrikeSharp.API.Core.Attributes.Registration;

namespace FastPlantPlugin;

[MinimumApiVersion(129)]
public class FastPlantPlugin : BasePlugin
{
    private const string Version = "1.0.0";
    
    public override string ModuleName => "Fast Plant Plugin";
    public override string ModuleVersion => Version;
    public override string ModuleAuthor => "B3none";
    public override string ModuleDescription => "Allows a CT to instantly defuse the bomb when all Ts are dead and nothing can prevent the defusal.";
    
    
}
