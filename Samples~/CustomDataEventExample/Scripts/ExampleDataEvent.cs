using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    [CreateAssetMenu(
        menuName = ContextMenuConstants.EVENT + nameof(ExampleDataEvent),
        fileName = nameof(ExampleDataEvent),
        order = 0
    )]
    public class ExampleDataEvent : GameEvent<ExampleData> { }
}
