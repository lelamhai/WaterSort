using UnityEngine;

public abstract class BaseItemDatabase : ScriptableObject
{
    private void Awake()
    {
        //SetPrefab();
        SetInfo();
    }

    private void Reset()
    {
        //SetPrefab();
        SetInfo();
    }

    //protected abstract void SetPrefab();
    protected abstract void SetInfo();
}