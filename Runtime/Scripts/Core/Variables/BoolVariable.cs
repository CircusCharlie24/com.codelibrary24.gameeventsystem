using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.VARIABLE + nameof(BoolVariable),
        fileName = nameof(BoolVariable),
        order = 0
    )]
    public class BoolVariable : VariableSO<bool> { }
}
