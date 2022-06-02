using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Dialogmanager : MonoBehaviour
{
    [SerializeField] GameObject dialogbox;
    
    [SerializeField] Text dialogText;
    [SerializeField] int lettersPerSecond;

    
    List<string> arrans = new List<string>
    {
        "B","A","A","D","A"
    };
     List<string> arrans2 = new List<string>
    {
        "D","C","B","A","A"
    };
     List<string> arrans3 = new List<string>
    {
        "C","A","D","A","A"
    };
     List<string>  arrans4 = new List<string>
    {
        "A","A","A","C","D"
    };
    List<string> arrans5 = new List<string>
    {
        "C","D","B","C","A"
    };
    public static Dialogmanager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    public static int currentLine = -1;
   public Dialog dialog;
    public static int k;
    bool isTyping=false;
    public static int i = -1;
    int j = -1;

    public  void ShowDialog(Dialog dialog)
    {

        
        this.dialog = dialog;
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Scene_real"))
        {
            k = dialog.Lines.Count;
            dialogbox.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Z) && isTyping == false)
            {

                currentLine++;
                if (currentLine <= dialog.Lines.Count)
                {
                    if (currentLine < dialog.Lines.Count)
                        StartCoroutine(TypeDialog(dialog.Lines[currentLine]));
                    if (currentLine % 2 == 0 && currentLine != 0)
                    {
                        j++;
                        Answercheck(j);
                    }
                    if (currentLine >= dialog.Lines.Count)
                    {
                        i = 1;
                        currentLine = -1;
                        dialogbox.SetActive(false);

                    }

                }

            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Scene_real_2"))
        {
            k = dialog.Lines2.Count;
            dialogbox.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Z) && isTyping == false)
            {
                currentLine++;
                if (currentLine <= dialog.Lines2.Count)
                {
                    if (currentLine < dialog.Lines2.Count)
                        StartCoroutine(TypeDialog(dialog.Lines2[currentLine]));
                    if (currentLine % 2 == 0 && currentLine != 0)
                    {
                        j++;
                        Answercheck(j);
                    }
                    if (currentLine >= dialog.Lines2.Count)
                    {
                        i = 1;
                        currentLine = -1;
                        dialogbox.SetActive(false);

                    }

                }
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Scene_real_3"))
        {
            k = dialog.Lines3.Count;
            dialogbox.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Z) && isTyping == false)
            {
                currentLine++;
                if (currentLine <= dialog.Lines3.Count)
                {
                    if (currentLine < dialog.Lines3.Count)
                        StartCoroutine(TypeDialog(dialog.Lines3[currentLine]));
                    if (currentLine % 2 == 0 && currentLine != 0)
                    {
                        j++;
                        Answercheck(j);
                    }
                    if (currentLine >= dialog.Lines3.Count)
                    {
                        i = 1;
                        currentLine = -1;
                        dialogbox.SetActive(false);

                    }

                }
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Scene_real_4"))
        {
            k = dialog.Lines4.Count;
            dialogbox.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Z) && isTyping == false)
            {
                currentLine++;
                if (currentLine <= dialog.Lines4.Count)
                {
                    if (currentLine < dialog.Lines4.Count)
                        StartCoroutine(TypeDialog(dialog.Lines4[currentLine]));
                    if (currentLine % 2 == 0 && currentLine != 0)
                    {
                        j++;
                        Answercheck(j);
                    }
                    if (currentLine >= dialog.Lines4.Count)
                    {
                        i = 1;
                        currentLine = -1;
                        dialogbox.SetActive(false);

                    }

                }
            }
        }

        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Scene_real_5"))
        {
            k = dialog.Lines5.Count;
            dialogbox.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Z) && isTyping == false)
            {
                currentLine++;
                if (currentLine <= dialog.Lines5.Count)
                {
                    if (currentLine < dialog.Lines5.Count)
                        StartCoroutine(TypeDialog(dialog.Lines5[currentLine]));
                    if (currentLine % 2 == 0 && currentLine != 0)
                    {
                        j++;
                        Answercheck(j);
                    }
                    if (currentLine >= dialog.Lines5.Count)
                    {
                        i = 1;
                        currentLine = -1;
                        dialogbox.SetActive(false);

                    }

                }
            }
        }



    }
    public void Answercheck(int ch)
    {

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Scene_real")) {
            if (Input_ans.ans == arrans[ch])
                Scorecount_check.scorevalue = Scorecount_check.scorevalue + 20;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Scene_real_2"))
        {
            if (Input_ans.ans == arrans2[ch])
                Scorecount_check.scorevalue = Scorecount_check.scorevalue + 20;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Scene_real_3"))
        {
            if (Input_ans.ans == arrans3[ch])
                Scorecount_check.scorevalue = Scorecount_check.scorevalue + 20;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Scene_real_4"))
        {
            if (Input_ans.ans == arrans4[ch])
                Scorecount_check.scorevalue = Scorecount_check.scorevalue + 20;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Scene_real_5"))
        {
            if (Input_ans.ans == arrans5[ch])
                Scorecount_check.scorevalue = Scorecount_check.scorevalue + 20;
        }


    }


    public IEnumerator TypeDialog(string line)
    {
        isTyping = true;
        dialogText.text = "";
        foreach (var letter in line.ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(1f / lettersPerSecond);
        }
        isTyping = false;
    }
}
