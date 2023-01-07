using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cano : MonoBehaviour
{

    public float cano_speed = 3f;
    void Start()
    {
        
        transform.position = new Vector3(transform.position.x,Random.Range(-3.3f, 3.3f),transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * cano_speed * Time.deltaTime);
        if(transform.position.x <= -11){ Destroy(this.gameObject);}
    
    }
}
