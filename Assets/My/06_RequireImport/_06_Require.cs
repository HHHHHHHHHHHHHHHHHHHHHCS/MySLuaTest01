using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;

namespace CS
{
    [CustomLuaClass]
    public class _06_Require : MonoBehaviour
    {
        public static void TestStatic()
        {
            Debug.Log("TestStatic");
        }

        public void TestPrivate()
        {
            Debug.Log("TestPrivate");
        }
    }

}
