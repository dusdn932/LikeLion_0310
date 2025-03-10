using UnityEngine;

public class NewMonoBehaviourExample : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Start: 게임이 시작될때 호출됩니다.");
    }

    void Update()
    {
        Debug.Log("Update : 프레임마다 호출됩니다.");
    }
    private void FixedUpdate()
    {
        Debug.Log("Fixedupdate : 물리연산에 사용됩니다.");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

}
