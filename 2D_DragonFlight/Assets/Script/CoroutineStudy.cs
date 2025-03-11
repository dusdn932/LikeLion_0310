using System.Collections;
using UnityEngine;

public class CoroutineStudy : MonoBehaviour
{
    //코루틴 정리
    //코루틴은 일바적인 함수와 달리 실해을 범췄다가 다시 이어서 실행할 수 있는기능
    //이를 이용하면 일정 시간 후 실행되거나, 특정 조건을 기다리는 등의기능을 쉽게 구현
    
    void Start()
    {
        StartCoroutine("ExampleCoroutine");
        StartCoroutine(ExampleCoroutine());
    }
    IEnumerator ExampleCoroutine()
    {
        Debug.Log("코루틴 시작");
        yield return new WaitForSeconds(2f);
        Debug.Log("2초후 실행");
    }

}
