using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class TypeStyle : MonoBehaviour
{
    public float typeDelay;

    private TextMeshProUGUI textMeshProUGUI;
    private string m_targetStr;
    private int m_targetLength;
    private int m_currLength;
    private float m_timer;
    private bool m_isTyping;

    public void TypeOut(string str)
    {
        m_targetStr = str;
        m_targetLength = str.Length;
        m_currLength = 0;
        m_timer = 0;
        m_isTyping = true;
    }

    private void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    private void FixedUpdate()
    {
        if (m_isTyping)
        {
            m_timer += Time.fixedDeltaTime;
            if (m_timer > typeDelay)
            {
                m_timer = 0f;
                m_timer += Time.fixedDeltaTime;
                textMeshProUGUI.text = m_targetStr.Substring(0, m_currLength) + "_";
                ++m_currLength;
                if (m_currLength >= m_targetLength)
                {
                    textMeshProUGUI.text = m_targetStr;
                    m_isTyping = false;
                }
            }
        }
    }
}
