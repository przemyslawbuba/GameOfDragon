using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hightscore : MonoBehaviour
{
    private string nickName;
    private string score;
    public Nickname Nn; 
    string url = "https://docs.google.com/forms/d/e/1FAIpQLSdBLH_CwhVmF5Up5PmdtuqCuJ5krOZBjkjFRY4BEuKL5MG9dw/formResponse";

    private IEnumerator Send(string nickName, string score)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1709103700", nickName);
        form.AddField("entry.680030740", score);
        byte[] bytes = form.data;
        WWW www = new WWW(url, bytes);
        yield return www;
    }

    public void SendScore()
    {
        StartCoroutine(Send(PlayerPrefs.GetString("Nickname"), PlayerPrefs.GetFloat("Gold").ToString()));
    }

  
}
