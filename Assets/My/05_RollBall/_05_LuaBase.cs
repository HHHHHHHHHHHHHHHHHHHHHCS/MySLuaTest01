using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;
using System;

[CustomLuaClass]
public class _05_LuaBase : MonoBehaviour
{
    [SerializeField]
    private string luaPath;

    private LuaTable table;
    private Action update;

    private void Awake()
    {
        if (string.IsNullOrEmpty(luaPath))
        {
            return;
        }

        LuaSvr luaSvr = new LuaSvr();
        luaSvr.init(null, () =>
         {
             table = (LuaTable)luaSvr.start(luaPath);
             update = ((LuaFunction)table["Update"]).cast<Action>();
         });
    }

    private void Update()
    {
        return;
        if(update!=null)
        {
            update();
        }
        else
        {
            Debug.Log("update is null");
        }
    }

}
