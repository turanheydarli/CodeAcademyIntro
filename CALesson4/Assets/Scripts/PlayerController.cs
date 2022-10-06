using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject body;
    [SerializeField] Color bodyColor;

    GameObject eye;
    [SerializeField] Color eyeColor;

    GameObject leftArm;
    [SerializeField] Color leftArmColor;

    GameObject rightArm;
    [SerializeField] Color rightArmColor;

    GameObject _enemy;

    // Start is called before the first frame update
    void Start()
    {
        body = gameObject;
        ColorizeBodyPart(body, bodyColor);

        eye = gameObject.transform.GetChild(0).gameObject;
        ColorizeBodyPart(eye, eyeColor);

        leftArm = gameObject.transform.GetChild(1).gameObject;
        ColorizeBodyPart(leftArm, leftArmColor);

        rightArm = gameObject.transform.GetChild(2).gameObject;
        ColorizeBodyPart(rightArm, rightArmColor);

        _enemy = GameObject.FindGameObjectWithTag("Enemy");

    }

    void ColorizeBodyPart(GameObject go, Color color)
    {
        go.GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Vector3.Distance(gameObject.transform.position, _enemy.transform.position));

        if(Vector3.Distance(gameObject.transform.position, _enemy.transform.position) <= 5)
        {
            Debug.Log("Fire");
        }

    }
}
