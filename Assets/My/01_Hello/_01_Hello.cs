using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;

public class _01_Hello : MonoBehaviour
{
    private static LuaState luaState;

    private void Start()
    {
        luaState = new LuaState();
        luaState.doString("for i=1,10,1 do print(i) end");
    }
}
