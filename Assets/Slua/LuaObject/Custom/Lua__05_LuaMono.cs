using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua__05_LuaMono : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_triggerEnter(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			#if UNITY_5_5_OR_NEWER
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#else
			Profiler.BeginSample(methodName);
			#endif
			#endif
			_05_LuaMono self=(_05_LuaMono)checkSelf(l);
			System.Action<UnityEngine.Collider> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.triggerEnter=v;
			else if(op==1) self.triggerEnter+=v;
			else if(op==2) self.triggerEnter-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			#if UNITY_5_5_OR_NEWER
			UnityEngine.Profiling.Profiler.EndSample();
			#else
			Profiler.EndSample();
			#endif
		}
		#endif
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"_05_LuaMono");
		addMember(l,"triggerEnter",null,set_triggerEnter,true);
		createTypeMetatable(l,null, typeof(_05_LuaMono),typeof(UnityEngine.MonoBehaviour));
	}
}
