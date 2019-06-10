using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour {
    public Text Score;
    public Text Win;

    void Start()
    {
        setScore();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("balls"))
        {
            other.gameObject.SetActive(false);
            PlayerController.count++;
            setScore();
        }
    }

    public void setScore()
    {
        Score.text = "Score: " + PlayerController.count.ToString();
        if (PlayerController.count >= 8)
        {
            Win.text = "You Win!";
        }
    }


}
