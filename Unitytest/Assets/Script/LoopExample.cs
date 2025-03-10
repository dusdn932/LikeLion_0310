using UnityEngine;

public class LoopExample : MonoBehaviour
{
    
    void Start()
    {
        /*for(int i = 1; i<=10; i++)
        {
            Debug.Log("Count : " + i);
        }*/
        int Countnum = 0;
        while(Countnum < 5)
        {
            Debug.Log(Countnum);
            Countnum++;
        }
    }

}
