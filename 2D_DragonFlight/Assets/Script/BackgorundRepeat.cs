using UnityEngine;

public class BackgorundRepeat : MonoBehaviour
{
    //스크롤 할 속도를 상수로 지정
    public float scrollSpeed = 0.6f;
    //쿼드의 머터리얼 데이터를 받아올 객체를 선언
    private Material thisMaterial;
    void Start()
    {
        //현재 객체의 Comonent들을 참조해 Renderer라는 컴포넌트의 material정보
        //받아옴
        thisMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        //새롭게 지정해줄 Offset 객체를 선언
        Vector2 newoffset = thisMaterial.mainTextureOffset;
        //Y분에 현재 y값에 속도에 프레임 보정ㅇ해서 더해줌
        newoffset.Set(0, newoffset.y + (scrollSpeed * Time.deltaTime));
        //최종적으로 offset값을 지정해줍니다.
        thisMaterial.mainTextureOffset = newoffset;
    }
}
