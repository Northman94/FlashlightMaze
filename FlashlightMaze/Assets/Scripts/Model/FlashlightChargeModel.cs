using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObjControllers;

public class FlashlightChargeModel : FlashlightController
{
    private float _fillAmount = 1f; // 100% заполненность
    public float FillAmount 
    {
        get 
        {
            return _fillAmount; 
        }  
    } // для корутины


   
    private float _dischargeTime = 10;
   
    private float _rechargeTime = 15f;



    public void Awake()
    {
        _flashlightStatus = GetComponent<Light>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) & _fillAmount > 0.5f)
        {
            Debug.Log("F Key is pressed");
            Switch();
        }
    }


    private void OnEnable()
    {
        StartCoroutine(CapacityCoroutine());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }


    private IEnumerator CapacityCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Coroutine started");

            if (_flashlightStatus)
            {
                Debug.Log("Discharge");
                _fillAmount = Mathf.Clamp01(_fillAmount - (1f / _dischargeTime ));
                Debug.Log(_fillAmount);


                if (_fillAmount <= 0f)
                {
                    Debug.Log("Off");
                    Off();
                }
            }
            else 
                    {
                Debug.Log("Fill");
                _fillAmount = Mathf.Clamp01(_fillAmount + (1f / (_rechargeTime)));
                Debug.Log(_fillAmount);
                    }
           }
       }
}