using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    [SerializeField]
    float destroyTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        destroyTime = Random.Range(1,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(gameObject.name);   
        //Destroy(gameObject);   
        //Destroy(gameObject, destroyTime);

        transform.GetChild(0).GetComponent<Renderer>().material.color = Color.yellow;

        CubeDestroy();

        //Invoke("TestMethod", 2);

        StartCoroutine(TestLogWithString("deneme"));
    }

    private void CubeDestroy()
    {
        GetComponent<Renderer>().enabled = false;
        Destroy(gameObject, 3f);
    }

    private void TestMethod()
    {
        Debug.Log("test");
    }

    IEnumerator TestLogWithString(string txt)
    {
        yield return new WaitForSeconds(2f);

        Debug.Log(txt);
        
        yield return new WaitForSeconds(2f);
        Debug.Log(txt);

        //StopCoroutine(TestLogWithString("deneme"));
        //StopAllCoroutines();
    }
}
