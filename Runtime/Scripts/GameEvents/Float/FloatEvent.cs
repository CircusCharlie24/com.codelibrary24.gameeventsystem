using CodeLibrary24.GameEventSystem;
using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.EVENT + nameof(FloatEvent),
        fileName = nameof(FloatEvent),
        order = 0
    )]
    public class FloatEvent : GameEvent<float> { }
}
