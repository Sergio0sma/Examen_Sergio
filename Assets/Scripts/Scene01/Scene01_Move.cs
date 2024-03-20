using UnityEngine;

public class Scene01_Move : MonoBehaviour
{
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W)) { transform.Translate(0, 0, 0.1f); }
        if (Input.GetKey(KeyCode.S)) { transform.Translate(0, 0, -0.1f); }
        if (Input.GetKey(KeyCode.A)) { transform.Translate(-0.1f, 0, 0); }
        if (Input.GetKey(KeyCode.D)) { transform.Translate(0.1f, 0, 0); }
        
        
    }
}
