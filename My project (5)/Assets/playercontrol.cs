using UnityEngine;
using UnityEngine.InputSystem;

public class playercontrol : MonoBehaviour
{
    private Vector2 moveinput;


    public void OnMove(InputValue value)
    {
        moveinput = value.Get<Vector2>();
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
        transform.Translate(Vector3.right * moveinput.x * Time.deltaTime);
    }
}
