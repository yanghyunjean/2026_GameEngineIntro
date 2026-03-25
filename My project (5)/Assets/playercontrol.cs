using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;



public class playercontrol : MonoBehaviour
{
    private Vector2 moveinput;
    public float moveSpeed = 7f;
    public float jumpForce = 7f;
    private Rigidbody2D rb;
    private Animator myAnimator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myAnimator.SetBool("move", false);
    }

    public void OnMove(InputValue value)
    {
        moveinput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("PlayScene_" + collision.name);


        if (collision.name == "Death")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else

        {
            SceneManager.LoadScene("PlayScene_" + collision.name);
        }
    }

 

        // Update is called once per frame
        void Update()
        {
            if (moveinput.x > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (moveinput.x < 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            if (moveinput.magnitude > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (moveinput.x < 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            if (moveinput.magnitude > 0)
            {
                myAnimator.SetBool("move", true);
            }
            else
            {
                myAnimator.SetBool("move", false);
            }
            transform.Translate(Vector3.right * moveSpeed * moveinput.x * Time.deltaTime);
        }
    
    }

