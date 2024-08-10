using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.EVENT + nameof(StringEvent),
        fileName = nameof(StringEvent),
        order = 0
    )]
    public class StringEvent : GameEvent<string> { }
}
