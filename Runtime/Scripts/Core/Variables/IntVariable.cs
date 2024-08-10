using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.VARIABLE + nameof(IntVariable),
        fileName = nameof(IntVariable),
        order = 0
    )]
    public class IntVariable : VariableSO<int> { }
}
