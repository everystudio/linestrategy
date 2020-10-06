using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TenSecond : MonoBehaviour
{
    public Text m_txtTimer;
    public float m_fStartTime;

    void Start()
    {
        m_fStartTime = Time.time;
    }

    private void Update()
    {
        m_txtTimer.text = string.Format("{0:0.00}", 
            Time.time - m_fStartTime);
    }

    /*
    IEnumerator Start()
    {

        yield return new WaitForSeconds(3.0f);

        Debug.Log("1回だけなにかする");

        //m_fStartTime = Time.time;
    }
    */
    /*
    // Update is called once per frame
    void Update()
    {
        float fDeltaTime = Time.time - m_fStartTime;

        if( 3.0f <= fDeltaTime)
        {
            Debug.Log("シーンが切り替わって3秒たちましたよ！");

            enabled = false;
        }


    }
    */
}
