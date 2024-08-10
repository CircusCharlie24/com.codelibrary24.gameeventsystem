using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.EVENT + nameof(Vector3Event),
        fileName = nameof(Vector3Event),
        order = 0
    )]
    public class Vector3Event : GameEvent<Vector3> { }
}
