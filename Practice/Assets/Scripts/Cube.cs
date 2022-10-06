using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    List<Transform> childTransforms;

    [SerializeField]
    Vector3 position;

    [SerializeField]
    Vector3 rotation;

    [SerializeField]
    GameObject firstChild;

    [SerializeField]
    bool switchWorld;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.transform.position);

        transform.position = new Vector3(2,4,5);

        gameObject.transform.localScale = new Vector3(2,3,1);

        gameObject.transform.rotation = Quaternion.Euler(30,60,90);

        transform.position = position;
 
        firstChild = transform.GetChild(0).gameObject;

        

        // for(int i = 0; i < transform.childCount; i++)
        // {
        //     childTransforms.Add(transform.GetChild(i));
        // }

        foreach(Transform item in transform) 
        {
            childTransforms.Add(item);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (switchWorld)
            firstChild.transform.rotation = Quaternion.Euler(rotation);
        else 
            firstChild.transform.localRotation = Quaternion.Euler(rotation);

        transform.position = position;
    }
}
