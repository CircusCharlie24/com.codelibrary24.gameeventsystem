using System.Collections.Generic;
using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    public abstract class GameEvent<T> : ScriptableObject
    {
        [SerializeField]
        private string tag;

        [SerializeField]
        [TextArea]
        private string description;

        private readonly List<IGameEventListener<T>> eventListeners =
            new List<IGameEventListener<T>>();

        public void Invoke(T data)
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
            {
                eventListeners[i].OnEventRaised(data);
            }
        }

        public void RegisterListener(IGameEventListener<T> gameEventListener)
        {
            if (!eventListeners.Contains(gameEventListener))
            {
                eventListeners.Add(gameEventListener);
            }
        }

        public void UnregisterListener(IGameEventListener<T> gameEventListener)
        {
            if (eventListeners.Contains(gameEventListener))
            {
                eventListeners.Remove(gameEventListener);
            }
        }

        public string GetTag()
        {
            return tag;
        }
    }
}
