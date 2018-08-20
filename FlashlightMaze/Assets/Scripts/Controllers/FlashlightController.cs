using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ObjControllers
{
    public class FlashlightController : BaseObjController
    {

        void Awake()
        {
            Off();
        }


       public override void Off()
        {
            _flashlightStatus = false;
            gameObject.GetComponentInChildren<Light>().enabled = false;
        }

        public override void On()
        {
            _flashlightStatus = true;
            gameObject.GetComponentInChildren<Light>().enabled = true;
        }



        public override void Switch()
        {
            base.Switch();

            if (!_flashlightStatus)
            {
                On();
            }
            else Off();

        }
    }
}
