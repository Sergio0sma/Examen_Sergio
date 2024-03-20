using System.Linq;
using UnityEditor;
using UnityEngine;

public class Scene06_SceneManager : MonoBehaviour
{
    public GameObject[] interactables;
    private void Update()
    {
        
        if (Input.GetKey(KeyCode.E))
        {
            interactables = GameObject.FindGameObjectsWithTag("Bolas");
            
            foreach (GameObject bola in interactables)
            {
                if (bola.GetComponent<Interactable>())
                {
                    
                    bola.GetComponent<SpriteRenderer>().color = Color.red;
                }
            }
        }
    }
}
