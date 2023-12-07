using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleController : BaseMonoBehaviour
{
    //[SerializeField] private List<Color> _bottleColors;
    //[SerializeField] private SpriteRenderer _bottleMask;
    //[SerializeField] private float _timeToRotate = 1f;

    //[SerializeField] private AnimationCurve _scaleAndRotationMultiplierCurve;
    //[SerializeField] private AnimationCurve _fillAmountCurve;
    //[SerializeField] private AnimationCurve _rotationSpeedMultipierCurve;

    //[SerializeField] private float[] _fillAmount;
    //[SerializeField] private float[] _rotationValues;
    //[Range(0,4)]
    //[SerializeField] private int _numberOfColorsInBottle = 4;
    //[SerializeField] private int _numberOfTopColorLayer = 1;
    //[SerializeField] private Color _topColor;

    //public BottleController _bottleControllerRef;
    //public bool _justThisBottle = false;
    //private int _numberOfColorsToTranfer = 0;


    //private int _indexRotation = 0;

    //private void Start()
    //{
    //    _bottleMask.material.SetFloat("_FillAmount", _fillAmount[_numberOfColorsInBottle]);
    //    UpdateColorsOnShader();
    //    UpdateTopColorValues();
    //}

    //private void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.Space) && _justThisBottle == true) {

    //        UpdateTopColorValues();
    //        if(_bottleControllerRef.FillBottleCheck(_topColor))
    //        {
    //            _numberOfColorsToTranfer = Mathf.Min(_numberOfTopColorLayer, 4 - _bottleControllerRef._numberOfColorsInBottle);

    //            for (int i = 0; i < _numberOfColorsToTranfer; i++)
    //            {
    //                _bottleControllerRef._bottleColors[_bottleControllerRef._numberOfColorsInBottle + i] = _topColor;
    //            }
    //            _bottleControllerRef.UpdateColorsOnShader();
    //        }
    //        CalculateRotationIndex(4-_bottleControllerRef._numberOfColorsInBottle);
    //        StartCoroutine(RotateBottleDown()); 
    //    }
    //}

    //private IEnumerator RotateBottleDown()
    //{
    //    float t = 0;
    //    float lerpValue;
    //    float angleValue;

    //    float lastAngleValues = 0;

    //    while(t < _timeToRotate)
    //    {
    //        lerpValue = t / _timeToRotate;
    //        angleValue = Mathf.Lerp(0, _rotationValues[_indexRotation], lerpValue);

    //        transform.eulerAngles = new Vector3 (0, 0, angleValue);
    //        _bottleMask.material.
    //            SetFloat("_ScaleAndRotate", 
    //            _scaleAndRotationMultiplierCurve.Evaluate(angleValue));

    //        if (_fillAmount[_numberOfColorsInBottle] > _fillAmountCurve.Evaluate(angleValue))
    //        {
    //            _bottleMask.material.
    //                 SetFloat("_FillAmount",
    //                 _fillAmountCurve.Evaluate(angleValue));

    //            _bottleControllerRef.FillUp(_fillAmountCurve.Evaluate(lastAngleValues) - _fillAmountCurve.Evaluate(angleValue));
    //        }


    //        t += Time.deltaTime * _rotationSpeedMultipierCurve.Evaluate(angleValue);
    //        lastAngleValues = angleValue;


    //        yield return new WaitForEndOfFrame();
    //    }
    //    angleValue = _rotationValues[_indexRotation];
    //    transform.eulerAngles = new Vector3(0,0,angleValue);
    //    _bottleMask.material.
    //            SetFloat("_ScaleAndRotate",
    //            _scaleAndRotationMultiplierCurve.Evaluate(angleValue));
    //    _bottleMask.material.
    //          SetFloat("_FillAmount",
    //          _fillAmountCurve.Evaluate(angleValue));

    //    _numberOfColorsInBottle -= _numberOfColorsToTranfer;
    //    _bottleControllerRef._numberOfColorsInBottle += _numberOfColorsToTranfer;

    //    StartCoroutine(RotateBottleUp());
    //}

    //private IEnumerator RotateBottleUp()
    //{
    //    float t = 0;
    //    float lerpValue;
    //    float angleValue;

    //    while (t < _timeToRotate)
    //    {
    //        lerpValue = t / _timeToRotate;
    //        angleValue = Mathf.Lerp(_rotationValues[_indexRotation], 0, lerpValue);

    //        transform.eulerAngles = new Vector3(0, 0, angleValue);
    //        _bottleMask.material.
    //            SetFloat("_ScaleAndRotate",
    //            _scaleAndRotationMultiplierCurve.Evaluate(angleValue));

    //        t += Time.deltaTime;// * _rotationSpeedMultipierCurve.Evaluate(angleValue);

    //        yield return new WaitForEndOfFrame();
    //    }
    //    UpdateTopColorValues();
    //    angleValue = 0;
    //    transform.eulerAngles = new Vector3(0, 0, angleValue);
    //    _bottleMask.material.
    //            SetFloat("_ScaleAndRotate",
    //            _scaleAndRotationMultiplierCurve.Evaluate(angleValue));
    //}

    //private void UpdateColorsOnShader()
    //{
    //    _bottleMask.material.SetColor("_C1", _bottleColors[0]);
    //    _bottleMask.material.SetColor("_C2", _bottleColors[1]);
    //    _bottleMask.material.SetColor("_C3", _bottleColors[2]);
    //    _bottleMask.material.SetColor("_C4", _bottleColors[3]);
    //}

    //private void UpdateTopColorValues()
    //{
    //    if(_numberOfColorsInBottle != 0)
    //    {
    //        _numberOfTopColorLayer = 1;
    //        _topColor = _bottleColors[_numberOfColorsInBottle - 1];
    //        if(_numberOfColorsInBottle == 4)
    //        {
    //            if (_bottleColors[3].Equals(_bottleColors[2]))
    //            {
    //                _numberOfTopColorLayer = 2;
    //                if (_bottleColors[2].Equals(_bottleColors[1]))
    //                {
    //                    _numberOfTopColorLayer = 3;
    //                    if (_bottleColors[1].Equals(_bottleColors[0]))
    //                    {
    //                        _numberOfTopColorLayer = 4;
    //                    }
    //                }
    //            }
    //        }
    //        else if (_numberOfColorsInBottle == 3)
    //        {
    //            if (_bottleColors[2].Equals(_bottleColors[1]))
    //            {
    //                _numberOfTopColorLayer = 2;
    //                if (_bottleColors[1].Equals(_bottleColors[0]))
    //                {
    //                    _numberOfTopColorLayer = 3;
    //                }
    //            }
    //        } else if (_numberOfColorsInBottle == 2)
    //        {
    //            if (_bottleColors[1].Equals(_bottleColors[0]))
    //            {
    //                _numberOfTopColorLayer = 2;
    //            }
    //        }

    //        _indexRotation = 3 - (_numberOfColorsInBottle - _numberOfTopColorLayer);
    //    }
    //}

    //private bool FillBottleCheck(Color colorToCheck)
    //{
    //    if (_numberOfColorsInBottle == 0)
    //    {
    //        return true;
    //    } else 
    //    {
    //        if (_numberOfColorsInBottle == 4)
    //        {
    //            return false;
    //        } else
    //        {
    //            if (_topColor.Equals(colorToCheck))
    //            {
    //                return true;
    //            }
    //            else
    //            {
    //                return false;
    //            }
    //        }
    //    }
    //}

    //private void CalculateRotationIndex(int numberOfEmptySpaceInSecondBottle)
    //{
    //    _indexRotation = 3 - (_numberOfColorsInBottle - Mathf.Min(numberOfEmptySpaceInSecondBottle, _numberOfTopColorLayer));
    //}

    //private void FillUp(float fillAmountAdd)
    //{
    //    _bottleMask.material.SetFloat("_FillAmount", _bottleMask.material.GetFloat("_FillAmount") + fillAmountAdd);
    //}

    [SerializeField] private BottleMask _bottleMask;
    [SerializeField] private int _slots = 4;
    [SerializeField] private List<BaseItemColorDatabase> _listColors = new List<BaseItemColorDatabase>();
    [SerializeField] private List<float> _rotationBottle;
    [SerializeField] private List<float> _fillBottle;
    [SerializeField] private float _timePour = 3;

    [Header("Curve")]
    [SerializeField] private AnimationCurve _scaleAndRotation;
    [SerializeField] private AnimationCurve _fillColor;
    [SerializeField] private AnimationCurve _speed;


    private void Start()
    {
        UpdateColors();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PourWater();
        }
    }

    private void UpdateColors()
    {
        _bottleMask.UpdateColorsOnShader(_listColors, _fillBottle);
    }

    private void PourWater()
    {
        StartCoroutine(IE_BottleDown());
    }

    private IEnumerator IE_BottleDown()
    {
        float t = 0;
        float lerpValue;
        float angleValue;

        while (t < _timePour)
        {
            lerpValue = t / _timePour;
            angleValue = Mathf.Lerp(0, 90f, lerpValue);

            transform.eulerAngles = new Vector3(0, 0, angleValue);
            _bottleMask.SetScaleAndRotation(_scaleAndRotation.Evaluate(angleValue));
            _bottleMask.SetFillColor(_fillColor.Evaluate(angleValue));

            t += Time.deltaTime *_speed.Evaluate(angleValue);

            yield return new WaitForEndOfFrame();
        }

        angleValue = 90f;
        transform.eulerAngles = new Vector3 (0, 0, angleValue);
        _bottleMask.SetScaleAndRotation(_scaleAndRotation.Evaluate(angleValue));
        _bottleMask.SetFillColor(_fillColor.Evaluate(angleValue));

        StartCoroutine(IE_BottleUp());
    }

    private IEnumerator IE_BottleUp()
    {
        float t = 0;
        float lerpValue;
        float angleValue;

        while (t < _timePour)
        {
            lerpValue = t / _timePour;
            angleValue = Mathf.Lerp(90f, 0, lerpValue);

            transform.eulerAngles = new Vector3(0, 0, angleValue);
            _bottleMask.SetScaleAndRotation(_scaleAndRotation.Evaluate(angleValue));

            t += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }

        angleValue = 0;
        transform.eulerAngles = new Vector3(0, 0, angleValue);
        _bottleMask.SetScaleAndRotation(_scaleAndRotation.Evaluate(angleValue));
    }

    protected override void SetDefaultValue()
    {
        LoadBottleMask();
        LoadDataFillBottle();
        LoadDataRotationBottle();
        LoadTimePour();
    }

    private void LoadBottleMask()
    {
        _bottleMask = transform.Find("BottleMask").GetComponent<BottleMask>(); 
    }

    private void LoadDataFillBottle()
    {
        _fillBottle.Add(-0.5f);
        _fillBottle.Add(-0.29f);
        _fillBottle.Add(-0.08f);
        _fillBottle.Add(0.13f);
        _fillBottle.Add(0.34f);
    }

    private void LoadDataRotationBottle()
    {
        _rotationBottle.Add(51);
        _rotationBottle.Add(71);
        _rotationBottle.Add(83);
        _rotationBottle.Add(90);
    }

    private void LoadTimePour()
    {
        _timePour = 3f;
    }
}