using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.EVENT + nameof(CharEvent),
        fileName = nameof(CharEvent),
        order = 0
    )]
    public class CharEvent : GameEvent<char> { }
}
