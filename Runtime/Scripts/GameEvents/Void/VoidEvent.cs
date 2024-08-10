using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.EVENT + nameof(VoidEvent),
        fileName = nameof(VoidEvent),
        order = 0
    )]
    public class VoidEvent : GameEvent<Void>
    {
        public void Invoke() => Invoke(new Void());
    }
}
