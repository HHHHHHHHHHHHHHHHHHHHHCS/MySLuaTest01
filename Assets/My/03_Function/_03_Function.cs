using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;
using System;

public class _03_Function : MonoBehaviour
{
    LuaTable luaTable;
    LuaFunction lf_Sum;
    LuaFunction lf_Mul;


    [CustomLuaClass]
    private delegate int Sum(int a, int b);

    [CustomLuaClass]
    private delegate int Mul(int a, int b);

    private Sum sum;
    private Mul mul;

    private void Start()
    {
        LuaSvr svr = new LuaSvr();
        svr.init(null, () =>
        {
            luaTable = (LuaTable)svr.start("03_Function");
            lf_Sum = (LuaFunction)luaTable["Sum"];
            lf_Mul = (LuaFunction)luaTable["Mul"];
            sum = lf_Sum.cast<Sum>();
            mul = lf_Mul.cast<Mul>();
        });


        Debug.Log(sum(3, 5));
        Debug.Log(mul(5, 8));
    }
}
