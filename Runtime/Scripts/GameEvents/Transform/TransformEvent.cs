using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.EVENT + nameof(TransformEvent),
        fileName = nameof(TransformEvent),
        order = 0
    )]
    public class TransformEvent : GameEvent<Transform> { }
}
