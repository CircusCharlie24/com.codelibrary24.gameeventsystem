using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.EVENT + nameof(GameObjectEvent),
        fileName = nameof(GameObjectEvent),
        order = 0
    )]
    public class GameObjectEvent : GameEvent<GameObject> { }
}
