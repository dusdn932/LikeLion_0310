using UnityEngine;

public class FuncExample : MonoBehaviour
{
    void Start()
    {
        SayHello(); // �Լ� ȣ��
        int total = AddNumbers(3, 5);
        Debug.Log("Total: " + total);

    }
    void SayHello()
    {
        Debug.Log("Hello, Unity!");
    }
    int AddNumbers(int a, int b)
    {
        return a + b;
    }


}
