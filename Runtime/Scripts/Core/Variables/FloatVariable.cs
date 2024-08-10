using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.VARIABLE + nameof(FloatVariable),
        fileName = nameof(FloatVariable),
        order = 0
    )]
    public class FloatVariable : VariableSO<float> { }
}
