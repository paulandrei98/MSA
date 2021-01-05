using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    [SerializeField] public Text pointsText;
    public GameObject CompleteScreen;
    public GameObject FailedScreen;
    public GameObject hide1;
    public GameObject hide2;
    private int myscore; 
    
    void Update(){
        myscore = GameController.currScore;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(myscore >= 250)
        {
            CompleteScreen.gameObject.SetActive(true);


        }
        else if(myscore < 250)
        {
            FailedScreen.gameObject.SetActive(true);
        }
            hide1.gameObject.SetActive(false);
            hide2.gameObject.SetActive(false);
            Time.timeScale = 0;

    }

        public void Setup(int score)
        {
            pointsText.text = "Your Score "+score.ToString();
        }


}
