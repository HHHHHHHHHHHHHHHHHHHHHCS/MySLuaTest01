using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;

public class _06_RequireImport : MonoBehaviour
{
    private void Awake()
    {
        LuaSvr svr = new LuaSvr();
        svr.init(null, () =>
        {
            svr.start("06_RequireImport/06_RequireImport");
        });

    }
}
