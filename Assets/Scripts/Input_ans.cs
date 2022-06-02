using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Input_ans : MonoBehaviour
{
    [SerializeField]  GameObject answer;
    static public string ans;
    public void Store()
    {
        ans = answer.GetComponent<Text>().text;
        //Debug.Log(ans);
    }

}
