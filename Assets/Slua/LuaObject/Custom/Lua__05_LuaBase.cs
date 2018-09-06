using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua__05_LuaBase : LuaObject {
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"_05_LuaBase");
		createTypeMetatable(l,null, typeof(_05_LuaBase),typeof(UnityEngine.MonoBehaviour));
	}
}
