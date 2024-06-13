using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{
    
    public TGUnity TGC;
    public bool consF=false;
    public float devBy = 10.0f;
    private Rigidbody rb;

    private float att=0.0f;
    private float med=0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        att = (att+TGC.tgd.eSense.attention/devBy)/2.0f;
        med = (med+TGC.tgd.eSense.meditation/devBy)/2.0f;
        rb.transform.localScale = new Vector3(att, med, (att+med)/2.0f);
        if( consF ){
            Debug.Log( att + " " + med);
        }
    }
}
