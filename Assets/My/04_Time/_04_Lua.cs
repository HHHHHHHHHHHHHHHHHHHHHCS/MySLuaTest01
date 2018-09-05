using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;

public class _04_Lua : MonoBehaviour
{
    [CustomLuaClass]
    private delegate void LuaUpdate(object self);

    private LuaTable luaTable;
    private LuaUpdate luaUpdate;

    private void Awake()
    {
        LuaSvr svr = new LuaSvr();
        svr.init(null, () =>
         {
             luaTable = (LuaTable)svr.start("04_Time");
             luaUpdate = ((LuaFunction)luaTable["Update"]).cast<LuaUpdate>();
         });

    }


    private void Update()
    {
        luaUpdate(luaTable);
    }
}
