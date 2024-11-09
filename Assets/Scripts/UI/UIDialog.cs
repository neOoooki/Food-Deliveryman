using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class UIDialog : SingletonMonoBehaviour<UIDialog>
{
    public TextMeshProUGUI textMeshProUGUI;
    public TypeStyle typeStyle;
    private string[] m_section;
    private int m_sectionLength;
    private int m_currIndex;
    private bool m_isPlaying;

    private readonly string[] sampleSeciotn =
    {
        "������11��9��",
        "������18��39",
        "������������",
        "����һ��ʾ������",
        "���㰴��Tabʱ����Ǯ��Money����������Energy����ѹ����stress��ϵͳ����Ӧ���¼�"
    };

    public void LoadSection(string[] section)
    {
        m_section = section;
        m_sectionLength = section.Length;
        m_currIndex = 0;
        m_isPlaying = true;
    }

    private void Start()
    {
        LoadSection(sampleSeciotn);
    }

    private void Update()
    {
        if (m_isPlaying)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                typeStyle.TypeOut(m_section[m_currIndex]);
                m_currIndex += 1;
                if (m_currIndex >= m_sectionLength)
                {
                    m_isPlaying = false;
                }
            }
        }
    }
}
