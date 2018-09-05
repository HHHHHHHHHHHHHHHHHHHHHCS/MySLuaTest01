using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;

public class _02_SVR : MonoBehaviour
{
    private LuaSvr luaSvr;
    private void Start()
    {
        luaSvr = new LuaSvr();
        luaSvr.init(null,()=> { });
        luaSvr.start("02_SVR");

    }
}
