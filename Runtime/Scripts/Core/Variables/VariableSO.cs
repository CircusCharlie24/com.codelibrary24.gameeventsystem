using UnityEngine;
using UnityEngine.Serialization;

namespace CodeLibrary24.GameEventSystem
{
    public class VariableSO<T> : ScriptableObject, ISerializationCallbackReceiver
    {
        [SerializeField]
        private T runtimeValue;

        [SerializeField]
        private T value;

        [FormerlySerializedAs("constant")]
        [FormerlySerializedAs("writeEnabled")]
        [SerializeField]
        private bool isConstant;

        [SerializeField]
        private bool applyRuntimeValue;


        public T GetValue()
        {
            return runtimeValue;
        }

        public void SetValue(T newValue)
        {
            if (isConstant)
            {
                Debug.LogError("Can't set value. Variable is a constant");
                return;
            }

            runtimeValue = newValue;
            if (applyRuntimeValue)
            {
                value = runtimeValue;
            }
        }

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            runtimeValue = value;
        }
    }
}