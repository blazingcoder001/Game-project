using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroycoin : MonoBehaviour
{
   static GameObject x;
    static string s;
    static public void destroy()
    {
        if (Scorecount_check.gameob != null)
        {
            foreach (var v in Scorecount_check.gameob)
            {
                s = v;

                x = GameObject.Find(s);
                Debug.Log(x);
                if(x!=null)
                Destroy(x.gameObject);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
