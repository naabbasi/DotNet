//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.builder {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface DirectoryLookupFactoryService {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Lorg/drools/runtime/CommandExecutor;)V")]
        void register(global::java.lang.String par0, global::org.drools.runtime.CommandExecutor par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Lorg/drools/runtime/CommandExecutor;")]
        global::org.drools.runtime.CommandExecutor lookup(global::java.lang.String par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Map;")]
        global::java.util.Map getDirectoryMap();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class DirectoryLookupFactoryService_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.builder.@__DirectoryLookupFactoryService.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.builder.DirectoryLookupFactoryService), typeof(global::org.drools.builder.DirectoryLookupFactoryService_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.builder.DirectoryLookupFactoryService), typeof(global::org.drools.builder.DirectoryLookupFactoryService_))]
    internal sealed partial class @__DirectoryLookupFactoryService : global::java.lang.Object, global::org.drools.builder.DirectoryLookupFactoryService {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _register0;
        
        internal static global::net.sf.jni4net.jni.MethodId _lookup1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getDirectoryMap2;
        
        private @__DirectoryLookupFactoryService(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.builder.@__DirectoryLookupFactoryService.staticClass = @__class;
            global::org.drools.builder.@__DirectoryLookupFactoryService._register0 = @__env.GetMethodID(global::org.drools.builder.@__DirectoryLookupFactoryService.staticClass, "register", "(Ljava/lang/String;Lorg/drools/runtime/CommandExecutor;)V");
            global::org.drools.builder.@__DirectoryLookupFactoryService._lookup1 = @__env.GetMethodID(global::org.drools.builder.@__DirectoryLookupFactoryService.staticClass, "lookup", "(Ljava/lang/String;)Lorg/drools/runtime/CommandExecutor;");
            global::org.drools.builder.@__DirectoryLookupFactoryService._getDirectoryMap2 = @__env.GetMethodID(global::org.drools.builder.@__DirectoryLookupFactoryService.staticClass, "getDirectoryMap", "()Ljava/util/Map;");
        }
        
        public void register(global::java.lang.String par0, global::org.drools.runtime.CommandExecutor par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::org.drools.builder.@__DirectoryLookupFactoryService._register0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.CommandExecutor>(@__env, par1));
            }
        }
        
        public global::org.drools.runtime.CommandExecutor lookup(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.CommandExecutor>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.@__DirectoryLookupFactoryService._lookup1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        public global::java.util.Map getDirectoryMap() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.@__DirectoryLookupFactoryService._getDirectoryMap2));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__DirectoryLookupFactoryService);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "register", "register0", "(Ljava/lang/String;Lorg/drools/runtime/CommandExecutor;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "lookup", "lookup1", "(Ljava/lang/String;)Lorg/drools/runtime/CommandExecutor;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getDirectoryMap", "getDirectoryMap2", "()Ljava/util/Map;"));
            return methods;
        }
        
        private static void register0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Ljava/lang/String;Lorg/drools/runtime/CommandExecutor;)V
            // (Ljava/lang/String;Lorg/drools/runtime/CommandExecutor;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.builder.DirectoryLookupFactoryService @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.DirectoryLookupFactoryService>(@__env, @__obj);
            @__real.register(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.CommandExecutor>(@__env, par1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle lookup1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/String;)Lorg/drools/runtime/CommandExecutor;
            // (Ljava/lang/String;)Lorg/drools/runtime/CommandExecutor;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.builder.DirectoryLookupFactoryService @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.DirectoryLookupFactoryService>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.CommandExecutor>(@__env, @__real.lookup(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getDirectoryMap2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Map;
            // ()Ljava/util/Map;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.builder.DirectoryLookupFactoryService @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.DirectoryLookupFactoryService>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Map>(@__env, @__real.getDirectoryMap());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.builder.@__DirectoryLookupFactoryService(@__env);
            }
        }
    }
    #endregion
}
