using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.EVENT + nameof(IntEvent),
        fileName = nameof(IntEvent),
        order = 0
    )]
    public class IntEvent : GameEvent<int> { }
}
