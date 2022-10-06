using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    [SerializeField] GameObject sphereObject;
    Vector3 position;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform fireTransform;

    // Start is called before the first frame update
    void Start()
    {
        position = new Vector3(Random.Range(0, 30), 0, Random.Range(0, 30));

        //Instantiate(sphereObject, position, Quaternion.Euler(0, 0, 0));
    }

    private void OnMouseDown()
    {
        Instantiate(bullet);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
