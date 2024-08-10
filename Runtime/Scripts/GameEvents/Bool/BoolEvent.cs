using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.EVENT + nameof(BoolEvent),
        fileName = nameof(BoolEvent),
        order = 0
    )]
    public class BoolEvent : GameEvent<bool> { }
}
