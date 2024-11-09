using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIDialog : SingletonMonoBehaviour<UIDialog>
{
    public TextMeshProUGUI textMeshProUGUI;
    public EventSystem eventSystem;
    public TypeStyle typeStyle;
    private string[] m_section;
    private int m_sectionLength;
    private int m_currIndex;
    private bool m_isPlaying;

    private readonly string[] sampleSeciotn1 =
    {
        "������11��9��",
        "������18��39",
        "������������",
        "����һ��ʾ������",
        "���㰴��Tabʱ����Ǯ��Money����������Energy����ѹ����stress��ϵͳ����Ӧ���¼�"
    };
    private readonly string[] sampleSection2 =
    {
        "aaaaaaaa",
        "bbbbbbbb",
        "cccccccc",
        "dddddddd"
    };

    public void StartSection(string[] section)
    {
        if (!m_isPlaying)
        {
            m_isPlaying = true;
            m_section = section;
            m_sectionLength = section.Length;
            m_currIndex = -1;
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            StartSection(sampleSeciotn1);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            StartSection(sampleSection2);
        if (m_isPlaying)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (eventSystem.IsPointerOverGameObject())
                {
                    if (typeStyle.IsTyping())
                    {
                        typeStyle.EndType();
                    }
                    else
                    {
                        if (++m_currIndex < m_sectionLength)
                        {
                            typeStyle.StartType(m_section[m_currIndex]);
                        }
                        else
                        {
                            m_isPlaying = false;
                        }

                    }
                }
            }
        }
    }
}
