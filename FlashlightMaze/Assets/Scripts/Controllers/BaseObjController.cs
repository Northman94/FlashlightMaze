using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ObjControllers
{
    public abstract class BaseObjController : MonoBehaviour
    {
        public bool _flashlightStatus = true;



        public virtual void On(){}

        public virtual void Off(){}

        public virtual void Switch(){}

    }
}