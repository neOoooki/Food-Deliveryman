using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<T>();
            return instance;
        }
    }
    protected SingletonMonoBehaviour() { }
}

public class GameElementManager<T>:SingletonMonoBehaviour<T> where T : MonoBehaviour
{
    private int m_value;
    public int initialValue;
    public int Value
    {
        get { return m_value; }
        set { m_value = value; }
    }
}