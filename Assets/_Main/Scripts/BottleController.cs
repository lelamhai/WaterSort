using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleController : BaseMonoBehaviour
{
    [SerializeField] private List<Color> _colors;
    [SerializeField] private SpriteRenderer _bottleMask;
    [SerializeField] private float _timeToRotate = 1f;

    [SerializeField] private AnimationCurve _scaleAndRotationMultiplierCurve;
    [SerializeField] private AnimationCurve _fillAmountCurve;
    [SerializeField] private AnimationCurve _rotationSpeedMultipierCurve;

    private void Start()
    {
        UpdateColorsOnShader();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) {
            StartCoroutine(RotateBottleDown()); 
        }
    }

    private IEnumerator RotateBottleDown()
    {
        float t = 0;
        float lerpValue;
        float angleValue;

        while(t < _timeToRotate)
        {
            lerpValue = t / _timeToRotate;
            angleValue = Mathf.Lerp(0, 90f, lerpValue);

            transform.eulerAngles = new Vector3 (0, 0, angleValue);
            _bottleMask.material.
                SetFloat("_ScaleAndRotate", 
                _scaleAndRotationMultiplierCurve.Evaluate(angleValue));
            _bottleMask.material.
               SetFloat("_FillAmount",
               _fillAmountCurve.Evaluate(angleValue));


            t += Time.deltaTime * _rotationSpeedMultipierCurve.Evaluate(angleValue);

            yield return new WaitForEndOfFrame();
        }
        angleValue = 90f;
        transform.eulerAngles = new Vector3(0,0,angleValue);
        _bottleMask.material.
                SetFloat("_ScaleAndRotate",
                _scaleAndRotationMultiplierCurve.Evaluate(angleValue));
        _bottleMask.material.
              SetFloat("_FillAmount",
              _fillAmountCurve.Evaluate(angleValue));

        StartCoroutine(RotateBottleUp());
    }

    private IEnumerator RotateBottleUp()
    {
        float t = 0;
        float lerpValue;
        float angleValue;

        while (t < _timeToRotate)
        {
            lerpValue = t / _timeToRotate;
            angleValue = Mathf.Lerp(90f, 0, lerpValue);

            transform.eulerAngles = new Vector3(0, 0, angleValue);
            _bottleMask.material.
                SetFloat("_ScaleAndRotate",
                _scaleAndRotationMultiplierCurve.Evaluate(angleValue));

            t += Time.deltaTime;// * _rotationSpeedMultipierCurve.Evaluate(angleValue);

            yield return new WaitForEndOfFrame();
        }
        angleValue = 0;
        transform.eulerAngles = new Vector3(0, 0, angleValue);
        _bottleMask.material.
                SetFloat("_ScaleAndRotate",
                _scaleAndRotationMultiplierCurve.Evaluate(angleValue));
    }

    private void UpdateColorsOnShader()
    {
        _bottleMask.material.SetColor("_C1", _colors[0]);
        _bottleMask.material.SetColor("_C2", _colors[1]);
        _bottleMask.material.SetColor("_C3", _colors[2]);
        _bottleMask.material.SetColor("_C4", _colors[3]);
    }

    protected override void SetDefaultValue()
    {}
}