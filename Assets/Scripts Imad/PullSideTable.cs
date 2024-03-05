using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullSideTable : MonoBehaviour
{
    public GameObject poignee;
    public GameObject tiroir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTiroir();
    }

    public void MoveTiroir()
    {
        if(poignee != null && tiroir != null && Input.GetKey(KeyCode.F))
        {
            poignee.transform.localPosition = new Vector3(0, 0, 0.25f);
            tiroir.transform.localPosition = new Vector3(0, 0, 0.25f);
        }
        
    }
}
