using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
    // Since we want to check every frame for player input and 
    //then want to apply that input to the player Game Object every frame as movement.
    private Rigidbody rb;
    private int count;

    // The speed of the object
    public float speed;
    public Text countText;
    public Text winText;

    void Start ()
    {//Called in the first frame
       
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    // void Update{//Called before rendering a frame

    // }
    void FixedUpdate () //这里是FixedUpdate, 不是FixUpdate！
    {//Called before any physics calculations
        float moveHorizontal = Input.GetAxis ("Horizontal"); 
        float moveVertical = Input.GetAxis ("Vertical"); 

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement*speed);
        // Vector3: Representation of 3D vectors and points 
    }
    void OnTriggerEnter(Collider other)
    {// 且，我们只需要改变prefab的那个tag即可，其他都会跟着变
        if (other.gameObject.CompareTag("Pick Up"))//即，如果那是一个小方块， 这里需要自己增加tag
        {
            other.gameObject.SetActive(false);//de-active即，让其消失咯
            count++;
            SetCountText();
        }
    }
    //Notes: rigid body + collider = dynamic object; if only collider -> static (waste resources).
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 8)
        {
            winText.text = "You Win!啦啦啦";
        }
    }
}
