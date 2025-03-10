using System.Diagnostics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce = 5.0f;
    public float speed = 5.0f;
    void Start()
    {
        Stopwatch.StartNew();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ);
        transform.Translate(move * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Rigidbody : 물리효과를 축사해 중력을 적용
            //addForce :점프를 위해 오브젝트에 힘을 줍니다
            //ForceMode.Impulse : 순간적으로 힘을 가하는 옵션

            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        print(string.Format("골인 하셨습니다"));
    }
}
