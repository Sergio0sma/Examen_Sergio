using UnityEngine;

public class Scene01_Move : MonoBehaviour
{
    void Update()
    {
        Move();
    }

    private void Move()
    {


        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * 0.1f);


    }
}
