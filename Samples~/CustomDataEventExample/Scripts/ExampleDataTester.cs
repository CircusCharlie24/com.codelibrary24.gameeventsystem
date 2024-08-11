using UnityEngine;

namespace CodeLibrary24.GameEventSystem
{
    public class ExampleDataTester : MonoBehaviour
    {
        // This class is both sender and reciever which would normally not be the case.
        public ExampleDataEvent exampleDataEvent;

        [ContextMenu("Raise Example Data Event")]
        public void RaiseExampleDataEvent()
        {
            ExampleData data =
                new()
                {
                    rollNo = 4,
                    name = "Divkaran Singh",
                    address = "Address of Divkaran Singh"
                };
            exampleDataEvent.Invoke(data);
        }

        public void OnExampleDataRecieved(ExampleData data)
        {
            Debug.Log("Roll No: " + data.rollNo);
            Debug.Log("Name: " + data.name);
            Debug.Log("Address: " + data.address);
        }
    }
}
