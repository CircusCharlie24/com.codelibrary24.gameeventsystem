using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.EVENT + nameof(Vector2Event),
        fileName = nameof(Vector2Event),
        order = 0
    )]
    public class Vector2Event : GameEvent<Vector2> { }
}
