using UnityEngine;

public class Scene03_CheckPoint : MonoBehaviour
{
    
    void Start()
    {
    }


    void Update()
    {
       
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
     Debug.Log("Nombre del checkpoint: "+ this.name);
        //Cambiar el color del checkpoint
        GetComponent<Renderer>().material.color = Color.green;
    }

}
