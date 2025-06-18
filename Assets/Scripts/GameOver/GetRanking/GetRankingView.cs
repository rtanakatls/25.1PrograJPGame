using TMPro;
using UnityEngine;

public class GetRankingView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI rankingText;

    private GetRankingController controller;


    private void Awake()
    {
        controller = GetComponent<GetRankingController>();
    }


    public void Execute()
    {
        controller.Execute(OnCallback);
    }

    private void OnCallback(RankingModel model)
    {
        if(model.message=="success")
        {
            rankingText.text = "";
            foreach(UserRankingModel user in model.data)
            {
                rankingText.text += $"{user.username} - {user.score}\n";
            }
        }
        else
        {
            Debug.Log("Error");
        }
    }
}
