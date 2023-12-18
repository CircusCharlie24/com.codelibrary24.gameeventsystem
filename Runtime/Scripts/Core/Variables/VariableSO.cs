using UnityEngine;
using UnityEngine.Serialization;

namespace CodeLibrary24.GameEventSystem
{
    public class VariableSO<T> : ScriptableObject, ISerializationCallbackReceiver
    {
        [SerializeField]
        private T value;

        [FormerlySerializedAs("constant")]
        [FormerlySerializedAs("writeEnabled")]
        [SerializeField]
        private bool isConstant;

        [SerializeField]
        private bool applyRuntimeValue;

        private T _runtimeValue;

        public T GetValue()
        {
            return _runtimeValue;
        }

        public void SetValue(T newValue)
        {
            if (isConstant)
            {
                Debug.LogError("Can't set value. Variable is a constant");
                return;
            }

            _runtimeValue = newValue;
            if (applyRuntimeValue)
            {
                value = _runtimeValue;
            }
        }

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            _runtimeValue = value;
        }
    }
}