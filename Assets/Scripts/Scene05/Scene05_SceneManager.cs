using System.Linq;
using UnityEngine;

public class Scene05_SceneManager : MonoBehaviour
{
    private void Awake()
    {
       
       //Me quedo con la longitud de la array de objetos
        int verdes = GameObject.FindGameObjectsWithTag("Verde").Length;
        int rojos = GameObject.FindGameObjectsWithTag("Rojo").Length;

        Debug.Log($"Circulos totales: {verdes + rojos}");
        Debug.Log($"Circulos Verdes: {verdes}");
        Debug.Log($"Circulos rojos: {rojos}");

        //Me quedo con el numero de componentes que tienen colliders
        int verdesColl = GameObject.FindGameObjectsWithTag("Verde").Where(Col => Col.GetComponent<Collider2D>() != null).Count();
        int rojosColl = GameObject.FindGameObjectsWithTag("Rojo").Where(Col => Col.GetComponent<Collider2D>() != null).Count();
        Debug.Log($"Circulos totales: {verdesColl + rojosColl}");
    }
}
