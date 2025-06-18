using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class SendScoreController : MonoBehaviour
{
    private const string url = "http://localhost/prograjp251/game1/upload_score.php";
    public void Execute(Action onCallback)
    {
        StartCoroutine(SendRequest(onCallback));
    }


    private IEnumerator SendRequest(Action onCallback)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", GameData.username);
        form.AddField("score", GameData.score);

        using (UnityWebRequest www = UnityWebRequest.Post(url, form))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.Success)
            {
                onCallback?.Invoke();
            }
            else
            {
                Debug.Log("Error");
            }
        }

    }
}
