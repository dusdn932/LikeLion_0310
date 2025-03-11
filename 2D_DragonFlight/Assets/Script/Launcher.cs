using System.Collections;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;//미사일 프리팹

    void Start()
    {
        //invokeRepeating(함수이름 , 초기지연시간, 지연시간)
        InvokeRepeating("Shoot", 3f, 0.5f);
    }
    void Shoot()
    {
        //미사일프리팹, 런쳐포지션, 방향값 안줌
        Instantiate(bullet, transform.position, Quaternion.identity);
        //사운드 사용해보기 사운드매니져ㅕ에서 총사운드 바로실행함수 호출 싱글톤 사용
        SoundManager.instance.PlayBulletSound();
    }

    void Update()
    {
        
    }
}
