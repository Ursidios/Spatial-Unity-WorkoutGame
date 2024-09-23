using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;
    public bool isFloating;

    public float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
        isFloating = true;
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;

        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }
        if(isFloating)
        {
            transform.Translate(0, 0, speed);
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Untagged"))
        {
            isFloating = false;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
