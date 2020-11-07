using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UnitorSeed : MonoBehaviour
{
    [SerializeField]
    private Button m_btnUnit;
    [SerializeField]
    private Button m_btnSeedMonster;
    private Image m_img;
    private Text m_textBase;
    private TextMeshProUGUI m_txtTextMeshProUGUI;

    public bool IsUnit
    {
        get { return m_bIsUnit; }
        set
        {
            m_btnUnit.interactable = !value;
            m_btnSeedMonster.interactable = value;
            m_bIsUnit = value;
        }
    }
    private bool m_bIsUnit;

    void Start()
    {
        Debug.Log(m_img.rectTransform);
        Debug.Log(m_textBase.rectTransform);
        Debug.Log(m_txtTextMeshProUGUI.rectTransform);

        m_btnUnit.onClick.AddListener(() =>
        {
            IsUnit = true;
        });
        m_btnSeedMonster.onClick.AddListener(() =>
        {
            IsUnit = false;
        });
    }

}
