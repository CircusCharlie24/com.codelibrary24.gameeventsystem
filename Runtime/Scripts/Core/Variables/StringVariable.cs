using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.VARIABLE + nameof(StringVariable),
        fileName = nameof(StringVariable),
        order = 0
    )]
    public class StringVariable : VariableSO<string> { }
}
