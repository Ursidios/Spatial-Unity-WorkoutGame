using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSpawner : MonoBehaviour
{
    public GameObject Weight;
    public GameObject DestroyOBJ;
    public void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Respawn"))
        {
            Instantiate(Weight, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(DestroyOBJ);
            
        }
    }
}
