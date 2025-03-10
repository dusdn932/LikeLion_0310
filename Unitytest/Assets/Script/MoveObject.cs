using UnityEngine;

public class MoveObject : MonoBehaviour
{

    
    public float speed = 5.0f;
    
    void Start()
    {
        
    }

    void Update()
    {
        /*float move_h = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * move_h * speed * Time.deltaTime);*/

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //transform.position += move * speed * Time.deltaTime;
        transform.Translate(move * speed * Time.deltaTime);
    }
}
