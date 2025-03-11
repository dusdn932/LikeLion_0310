using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bullet : MonoBehaviour
{
    private int collisionCount = 0; // 충돌 횟수 저장
    public int maxCollisions = 10; // 최대 충돌 횟수 설정
    public float Speed = 0.45f;
    public GameObject exposion;
    void Start()
    {
        
    }
    

    void Update()
    {
        //Y축이동
        transform.Translate(0, Speed * Time.deltaTime, 0);

    }

    private void OnBecameInvisible()
    {
        //미사일이 나가면 제거
        //자기자신 제거 시작 소문자 자신
        //대문자시작 지정할떄 사용
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(exposion, transform.position, Quaternion.identity);
            SoundManager.instance.SoundDie();
            GameManager.intance.AddScore(10);
            Destroy(collision.gameObject);
            Destroy(gameObject);  // 총알 삭제
        }
        else if (collision.gameObject.tag == "Enemy2")
        {
            collisionCount++; // 충돌 횟수 증가
            Instantiate(exposion, transform.position, Quaternion.identity);

            Debug.Log($"Bullet 충돌 횟수: {collisionCount}");

            if (collisionCount >= maxCollisions)
            {
                Destroy(collision.gameObject);  // 적 제거
            }

            Destroy(gameObject); // 총알 제거
            SoundManager.instance.SoundDie();
        }
    }
}
