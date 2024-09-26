using Mono.Cecil;

namespace Il2CppInterop.Generator.Utils;

internal static class DOTSUtil {
    public static bool ImplementsISystem(TypeDefinition typeDef) {
        foreach (var typeInterface in typeDef.Interfaces) {
            if (typeInterface.InterfaceType.Resolve().FullName.Equals("Unity.Entities.ISystem")) {
                return true;
            }
        }
        return false;
    }
}