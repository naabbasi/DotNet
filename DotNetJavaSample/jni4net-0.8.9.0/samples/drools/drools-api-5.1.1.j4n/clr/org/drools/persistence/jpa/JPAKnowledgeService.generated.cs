//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.persistence.jpa {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class JPAKnowledgeService : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _newStatefulKnowledgeSession0;
        
        internal static global::net.sf.jni4net.jni.MethodId _loadStatefulKnowledgeSession1;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctorJPAKnowledgeService2;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public JPAKnowledgeService() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::org.drools.persistence.jpa.JPAKnowledgeService.staticClass, global::org.drools.persistence.jpa.JPAKnowledgeService.@__ctorJPAKnowledgeService2, this);
            }
        }
        
        protected JPAKnowledgeService(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.persistence.jpa.JPAKnowledgeService.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.persistence.jpa.JPAKnowledgeService.staticClass = @__class;
            global::org.drools.persistence.jpa.JPAKnowledgeService._newStatefulKnowledgeSession0 = @__env.GetStaticMethodID(global::org.drools.persistence.jpa.JPAKnowledgeService.staticClass, "newStatefulKnowledgeSession", "(Lorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lorg" +
                    "/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;");
            global::org.drools.persistence.jpa.JPAKnowledgeService._loadStatefulKnowledgeSession1 = @__env.GetStaticMethodID(global::org.drools.persistence.jpa.JPAKnowledgeService.staticClass, "loadStatefulKnowledgeSession", "(ILorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lor" +
                    "g/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;");
            global::org.drools.persistence.jpa.JPAKnowledgeService.@__ctorJPAKnowledgeService2 = @__env.GetMethodID(global::org.drools.persistence.jpa.JPAKnowledgeService.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lorg" +
            "/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;")]
        public static global::org.drools.runtime.StatefulKnowledgeSession newStatefulKnowledgeSession(global::org.drools.KnowledgeBase par0, global::org.drools.runtime.KnowledgeSessionConfiguration par1, global::org.drools.runtime.Environment par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatefulKnowledgeSession>(@__env, @__env.CallStaticObjectMethodPtr(global::org.drools.persistence.jpa.JPAKnowledgeService.staticClass, global::org.drools.persistence.jpa.JPAKnowledgeService._newStatefulKnowledgeSession0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.KnowledgeBase>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.KnowledgeSessionConfiguration>(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.Environment>(@__env, par2)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ILorg/drools/KnowledgeBase;Lorg/drools/runtime/KnowledgeSessionConfiguration;Lor" +
            "g/drools/runtime/Environment;)Lorg/drools/runtime/StatefulKnowledgeSession;")]
        public static global::org.drools.runtime.StatefulKnowledgeSession loadStatefulKnowledgeSession(int par0, global::org.drools.KnowledgeBase par1, global::org.drools.runtime.KnowledgeSessionConfiguration par2, global::org.drools.runtime.Environment par3) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 18)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatefulKnowledgeSession>(@__env, @__env.CallStaticObjectMethodPtr(global::org.drools.persistence.jpa.JPAKnowledgeService.staticClass, global::org.drools.persistence.jpa.JPAKnowledgeService._loadStatefulKnowledgeSession1, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.KnowledgeBase>(@__env, par1), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.KnowledgeSessionConfiguration>(@__env, par2), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.runtime.Environment>(@__env, par3)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.persistence.jpa.JPAKnowledgeService(@__env);
            }
        }
    }
    #endregion
}
