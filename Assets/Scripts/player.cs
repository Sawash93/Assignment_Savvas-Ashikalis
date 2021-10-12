using UnityEngine;

public class player : MonoBehaviour
{
    //State
    [SerializeField] float snakeSpeed = 2f; //snake speed
    [SerializeField] float gameSpeed = 1f; //game speed
    [SerializeField] GameObject newBodyPrefab;

    //Cached variables
    protected Joystick joyStick; //protected outside this script
    Rigidbody2D rigidBody;
    GameObject bodyParent;
    const string BODY_PARENT_NAME = "Body Parts";
  

    void Start()
    {
        Time.timeScale = gameSpeed; //Reset timeScale
        rigidBody = GetComponent<Rigidbody2D>(); 
        joyStick = FindObjectOfType<Joystick>();
        CreateBodyParent();
    }

    void Update()
    {
        Move();
        
        
    }

    private void Move()
    {
        //Time.deltaTime to not allow PC CPU to affect gameplay speed
        rigidBody.velocity = new Vector2(joyStick.Horizontal * snakeSpeed, joyStick.Vertical * snakeSpeed);

        //for debugging speed input
        /* Debug.Log("I am moving with" + rigidBody.velocity.x + "," + rigidBody.velocity.y); 
        */
    }


    private void CreateBodyParent()
    {
        bodyParent = gameObject;
        if (!bodyParent)
        {
           bodyParent = new GameObject(BODY_PARENT_NAME);
        }
    }
    public void Grow()
    {
        var position = new Vector3(0f, 0f , 0f);
        GameObject newBody = Instantiate(newBodyPrefab, transform.position - position, Quaternion.identity) as GameObject;
        // newBody.transform.parent = bodyParent.transform;
    }

}
