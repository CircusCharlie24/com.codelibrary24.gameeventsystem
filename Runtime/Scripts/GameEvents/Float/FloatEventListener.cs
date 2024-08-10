using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    public class FloatEventListener : GameEventListener<float, FloatEvent, UnityFloatEvent> { }

    // make for int, bool, char, string, vector 2 and vector 3

    public class IntEventListener : GameEventListener<int, IntEvent, UnityIntEvent> { }

    public class BoolEventListener : GameEventListener<bool, BoolEvent, UnityBoolEvent> { }

    public class CharEventListener : GameEventListener<char, CharEvent, UnityCharEvent> { }

    public class StringEventListener : GameEventListener<string, StringEvent, UnityStringEvent> { }

    public class Vector2EventListener
        : GameEventListener<Vector2, Vector2Event, UnityVector2Event> { }

    public class Vector3EventListener
        : GameEventListener<Vector3, Vector3Event, UnityVector3Event> { }
}
