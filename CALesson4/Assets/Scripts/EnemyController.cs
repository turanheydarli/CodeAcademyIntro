using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject body;
    [SerializeField] Color bodyColor;

    GameObject eye;
    [SerializeField] Color eyeColor;

    GameObject leftArm;
    [SerializeField] Color leftArmColor;

    GameObject rightArm;
    [SerializeField] Color rightArmColor;

    [Range(0,20)]
    [SerializeField] float speed = 5;

    GameObject _player;

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

        _player = GameObject.FindGameObjectWithTag("Player");

    }

    void ColorizeBodyPart(GameObject go, Color color)
    {
        go.GetComponent<Renderer>().material.color = color;
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, _player.transform.position) <= 3f)
        {
            return;
        }
        transform.LookAt(_player.transform.position);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
