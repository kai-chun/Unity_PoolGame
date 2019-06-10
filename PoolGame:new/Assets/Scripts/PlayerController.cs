using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public static float speed;
    public static float offset;
    private Rigidbody rb;

    public static int count;
    //public Text Score;

    void Start () {
        rb = GetComponent<Rigidbody>();
        speed = 50;
        offset = 1f;
        count = 0;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            this.gameObject.transform.position = new Vector3(0,0,0);
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
    public void setScore()
    {
        //Score.text = "Score: " + Score.ToString();
    }
}
