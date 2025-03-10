using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce = 5.0f;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Rigidbody : 물리효과를 축사해 중력을 적용
            //addForce :점프를 위해 오브젝트에 힘을 줍니다
            //ForceMode.Impulse : 순간적으로 힘을 가하는 옵션

            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
