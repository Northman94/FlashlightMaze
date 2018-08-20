using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class FlashlightView : MonoBehaviour
{
    private Image _frontImage; // наложенная картинка и ее шкала01
    private  FlashlightChargeModel _model; // FlashlightChargeModel для доступа в этот класс


    private void Awake()
    {
        _frontImage = GetComponent<Image>();

        _model = FindObjectOfType<FlashlightChargeModel>();
    }


    private void FixedUpdate()
    {
        _frontImage.fillAmount = _model.FillAmount;
    }
}
