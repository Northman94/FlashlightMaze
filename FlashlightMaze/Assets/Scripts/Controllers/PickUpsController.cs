using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjControllers
{
    public class PickUpsController : BaseObjController
    {

        void Update()
        {

            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

        }
    }
}