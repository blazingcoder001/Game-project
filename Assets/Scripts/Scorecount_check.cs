using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Scorecount_check : MonoBehaviour
{
    [SerializeField]
    private Text Textbox;
    static public int scorevalue;
    static public int x;
    [SerializeField] private Text result;
    static public List<string> gameob = new List<string>(10);
    static public int m=0;
    GameObject l;
    string s;
    private void Update()
    {
        /*if(SceneManager.GetActiveScene()== SceneManager.GetSceneByName("scene_below") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Scene_real"))*/
        Textbox.text = "TotalScore:" + scorevalue;
        Destroycoin.destroy();
    }
private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByName("Scene_below"))
            x = SceneManager.GetActiveScene().buildIndex;
        if (collision.tag.Equals("Pickup") && SceneManager.GetSceneByName("Scene_real")== SceneManager.GetActiveScene())
        {
            scorevalue = scorevalue + 5;
            string a = collision.gameObject.name.ToString();
            gameob.Add(a); 
            m++;
            Destroy(collision.gameObject);
        }
        else if(collision.tag.Equals("Pickup"))
        {
            scorevalue = scorevalue + 5;
            Destroy(collision.gameObject);
        }

         if (collision.CompareTag("Finish") && Dialogmanager.i==1)
        {



            Dialogmanager.i = -1;
                SceneManager.LoadScene(++x);
            
        }
        else if (collision.CompareTag("Respawn"))
        {
            
            if (Scorecount_check.scorevalue >= 650)
            {
                result.text="Congratulations,you are a pro. Keep it up";
            }
            else if(Scorecount_check.scorevalue >=405 && Scorecount_check.scorevalue < 650)
            {
                result.text="You are a good explorer";

            }
            else if (Scorecount_check.scorevalue >= 200 && Scorecount_check.scorevalue < 405)
            {
                result.text="You are a nice player";

            }
            else if (Scorecount_check.scorevalue >= 50 && Scorecount_check.scorevalue < 200)
            {
                result.text="You should improve";

            }
            else if (Scorecount_check.scorevalue<=50)
            {
                result.text="It's bad. You should give more awareness to surroundings";

            }


        }
    }
}
