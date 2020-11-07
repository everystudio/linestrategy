using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTimer : MonoBehaviour
{
    public Animator anim = null;

    public class CheckParam
    {
        public int a;
        public float b;
    };
    public CheckParam[] table = new CheckParam[]
    {
        new CheckParam{a = 1 , b=0.0f },
        new CheckParam{a = 1 , b=0.0f },
    };

    void Start()
    {
        if (anim != null)
        {
            anim = GetComponent<Animator>();
            anim.SetBool("run", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        
    }
}
