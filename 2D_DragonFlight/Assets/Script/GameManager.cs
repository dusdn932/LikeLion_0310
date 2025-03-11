using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //싱글톤
    //어디에서나 접근 할 수있도록 static(정적)으로 자기자ㅅ신을 저장해서 싱글톤이라는 디자인패턴을 사용한다
    public static GameManager intance;
    public Text scoreText;//점수를 표시하는 Text객체를 에디터에서 받아옵니다
    public Text StartText;//게임시작전 3,2,1
    int score = 0; //점수관리
    private void Awake()
    {
        if(intance == null)//정적으로 자신을 체크 null인지
        {
            intance = this;//자기자신 저장
        }
    }
    void Start()
    {
        StartCoroutine(StartGame());
        StartCoroutine(playgame());
    }
    IEnumerator StartGame()
    {
        int i = 3;
        while (i > 0)
        {
            StartText.text = i.ToString();
            yield return new WaitForSeconds(1);
            i--;
            if (i == 0)
            {
                StartText.gameObject.SetActive(false); //UI감추기
            }
        }
    }
    IEnumerator playgame()
    {
        int i = 10;
        while (i > 0)
        {
            i--;
            yield return new WaitForSeconds(1);
        }
        SceneManager.LoadScene("GameOverScene");
    }
    public void AddScore(int num)
    {

        
        score += num; //정수를 더해줍니다.
        scoreText.text = "Score : " + score;//텍스트에 반영
        
    }
    
    void Update()
    {

        
    }
}
