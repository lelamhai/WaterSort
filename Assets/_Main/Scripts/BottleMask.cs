using System.Collections.Generic;
using UnityEngine;

public class BottleMask : BaseMonoBehaviour
{
    [SerializeField] private SpriteRenderer _mask;

    public void UpdateColorsOnShader(List<BaseItemColorDatabase> _list, List<float> rotation)
    {
        string key = "_C";

        for (int i = 0; i < _list.Count; i++)
        {
            string keyTemp = key + (i+1);
            _mask.material.SetColor(keyTemp, _list[i].Model.Color);
            _mask.material.SetFloat("_FillAmount", rotation[i + 1]);
        }
    }

    public void SetScaleAndRotation(float angle)
    {
        _mask.material.SetFloat("_ScaleAndRotate",angle);
    }

    public void SetFillColor(float value)
    {
        _mask.material.SetFloat("_FillAmount", value);
    }

    protected override void SetDefaultValue()
    {
        LoadMask();
    }

    private void LoadMask()
    {
        _mask = GetComponent<SpriteRenderer>();
    }
}