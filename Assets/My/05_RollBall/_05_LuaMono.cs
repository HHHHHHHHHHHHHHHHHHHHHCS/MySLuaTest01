using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;
using System;

[CustomLuaClass]
public class _05_LuaMono : MonoBehaviour
{
    public Action<Collider> triggerEnter;

    private void OnTriggerEnter(Collider other)
    {
        if (triggerEnter != null)
        {
            triggerEnter(other);
        }
    }
     
}
