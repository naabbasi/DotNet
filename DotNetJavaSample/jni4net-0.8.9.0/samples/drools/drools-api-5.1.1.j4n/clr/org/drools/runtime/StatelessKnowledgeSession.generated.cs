//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.runtime {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface StatelessKnowledgeSession : global::org.drools.runtime.rule.StatelessRuleSession, global::org.drools.runtime.process.StatelessProcessSession, global::org.drools.runtime.CommandExecutor, global::org.drools.@event.KnowledgeRuntimeEventManager {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Object;)V")]
        void setGlobal(global::java.lang.String par0, global::java.lang.Object par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/drools/runtime/Globals;")]
        global::org.drools.runtime.Globals getGlobals();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class StatelessKnowledgeSession_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.runtime.StatelessKnowledgeSession), typeof(global::org.drools.runtime.StatelessKnowledgeSession_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.runtime.StatelessKnowledgeSession), typeof(global::org.drools.runtime.StatelessKnowledgeSession_))]
    internal sealed partial class @__StatelessKnowledgeSession : global::java.lang.Object, global::org.drools.runtime.StatelessKnowledgeSession {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _execute0;
        
        internal static global::net.sf.jni4net.jni.MethodId _execute1;
        
        internal static global::net.sf.jni4net.jni.MethodId _execute2;
        
        internal static global::net.sf.jni4net.jni.MethodId _addEventListener3;
        
        internal static global::net.sf.jni4net.jni.MethodId _addEventListener4;
        
        internal static global::net.sf.jni4net.jni.MethodId _removeEventListener5;
        
        internal static global::net.sf.jni4net.jni.MethodId _removeEventListener6;
        
        internal static global::net.sf.jni4net.jni.MethodId _getWorkingMemoryEventListeners7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getAgendaEventListeners8;
        
        internal static global::net.sf.jni4net.jni.MethodId _addEventListener9;
        
        internal static global::net.sf.jni4net.jni.MethodId _removeEventListener10;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProcessEventListeners11;
        
        internal static global::net.sf.jni4net.jni.MethodId _setGlobal12;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGlobals13;
        
        private @__StatelessKnowledgeSession(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass = @__class;
            global::org.drools.runtime.@__StatelessKnowledgeSession._execute0 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "execute", "(Ljava/lang/Iterable;)V");
            global::org.drools.runtime.@__StatelessKnowledgeSession._execute1 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "execute", "(Ljava/lang/Object;)V");
            global::org.drools.runtime.@__StatelessKnowledgeSession._execute2 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "execute", "(Lorg/drools/command/Command;)Ljava/lang/Object;");
            global::org.drools.runtime.@__StatelessKnowledgeSession._addEventListener3 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "addEventListener", "(Lorg/drools/event/rule/AgendaEventListener;)V");
            global::org.drools.runtime.@__StatelessKnowledgeSession._addEventListener4 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "addEventListener", "(Lorg/drools/event/rule/WorkingMemoryEventListener;)V");
            global::org.drools.runtime.@__StatelessKnowledgeSession._removeEventListener5 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "removeEventListener", "(Lorg/drools/event/rule/AgendaEventListener;)V");
            global::org.drools.runtime.@__StatelessKnowledgeSession._removeEventListener6 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "removeEventListener", "(Lorg/drools/event/rule/WorkingMemoryEventListener;)V");
            global::org.drools.runtime.@__StatelessKnowledgeSession._getWorkingMemoryEventListeners7 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "getWorkingMemoryEventListeners", "()Ljava/util/Collection;");
            global::org.drools.runtime.@__StatelessKnowledgeSession._getAgendaEventListeners8 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "getAgendaEventListeners", "()Ljava/util/Collection;");
            global::org.drools.runtime.@__StatelessKnowledgeSession._addEventListener9 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "addEventListener", "(Lorg/drools/event/process/ProcessEventListener;)V");
            global::org.drools.runtime.@__StatelessKnowledgeSession._removeEventListener10 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "removeEventListener", "(Lorg/drools/event/process/ProcessEventListener;)V");
            global::org.drools.runtime.@__StatelessKnowledgeSession._getProcessEventListeners11 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "getProcessEventListeners", "()Ljava/util/Collection;");
            global::org.drools.runtime.@__StatelessKnowledgeSession._setGlobal12 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "setGlobal", "(Ljava/lang/String;Ljava/lang/Object;)V");
            global::org.drools.runtime.@__StatelessKnowledgeSession._getGlobals13 = @__env.GetMethodID(global::org.drools.runtime.@__StatelessKnowledgeSession.staticClass, "getGlobals", "()Lorg/drools/runtime/Globals;");
        }
        
        public void execute(global::java.lang.Iterable par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.@__StatelessKnowledgeSession._execute0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Iterable>(@__env, par0));
            }
        }
        
        public void execute(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.@__StatelessKnowledgeSession._execute1, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0));
            }
        }
        
        public global::java.lang.Object execute(global::org.drools.command.Command par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.@__StatelessKnowledgeSession._execute2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.command.Command>(@__env, par0)));
            }
        }
        
        public void addEventListener(global::org.drools.@event.rule.AgendaEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.@__StatelessKnowledgeSession._addEventListener3, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.AgendaEventListener>(@__env, par0));
            }
        }
        
        public void addEventListener(global::org.drools.@event.rule.WorkingMemoryEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.@__StatelessKnowledgeSession._addEventListener4, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.WorkingMemoryEventListener>(@__env, par0));
            }
        }
        
        public void removeEventListener(global::org.drools.@event.rule.AgendaEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.@__StatelessKnowledgeSession._removeEventListener5, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.AgendaEventListener>(@__env, par0));
            }
        }
        
        public void removeEventListener(global::org.drools.@event.rule.WorkingMemoryEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.@__StatelessKnowledgeSession._removeEventListener6, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.rule.WorkingMemoryEventListener>(@__env, par0));
            }
        }
        
        public global::java.util.Collection getWorkingMemoryEventListeners() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.@__StatelessKnowledgeSession._getWorkingMemoryEventListeners7));
            }
        }
        
        public global::java.util.Collection getAgendaEventListeners() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.@__StatelessKnowledgeSession._getAgendaEventListeners8));
            }
        }
        
        public void addEventListener(global::org.drools.@event.process.ProcessEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.@__StatelessKnowledgeSession._addEventListener9, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.process.ProcessEventListener>(@__env, par0));
            }
        }
        
        public void removeEventListener(global::org.drools.@event.process.ProcessEventListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.@__StatelessKnowledgeSession._removeEventListener10, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.@event.process.ProcessEventListener>(@__env, par0));
            }
        }
        
        public global::java.util.Collection getProcessEventListeners() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.@__StatelessKnowledgeSession._getProcessEventListeners11));
            }
        }
        
        public void setGlobal(global::java.lang.String par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::org.drools.runtime.@__StatelessKnowledgeSession._setGlobal12, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1));
            }
        }
        
        public global::org.drools.runtime.Globals getGlobals() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.Globals>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.runtime.@__StatelessKnowledgeSession._getGlobals13));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__StatelessKnowledgeSession);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "execute", "execute0", "(Ljava/lang/Iterable;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "execute", "execute1", "(Ljava/lang/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "execute", "execute2", "(Lorg/drools/command/Command;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "addEventListener", "addEventListener3", "(Lorg/drools/event/rule/AgendaEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "addEventListener", "addEventListener4", "(Lorg/drools/event/rule/WorkingMemoryEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "removeEventListener", "removeEventListener5", "(Lorg/drools/event/rule/AgendaEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "removeEventListener", "removeEventListener6", "(Lorg/drools/event/rule/WorkingMemoryEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getWorkingMemoryEventListeners", "getWorkingMemoryEventListeners7", "()Ljava/util/Collection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getAgendaEventListeners", "getAgendaEventListeners8", "()Ljava/util/Collection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "addEventListener", "addEventListener9", "(Lorg/drools/event/process/ProcessEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "removeEventListener", "removeEventListener10", "(Lorg/drools/event/process/ProcessEventListener;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getProcessEventListeners", "getProcessEventListeners11", "()Ljava/util/Collection;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setGlobal", "setGlobal12", "(Ljava/lang/String;Ljava/lang/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getGlobals", "getGlobals13", "()Lorg/drools/runtime/Globals;"));
            return methods;
        }
        
        private static void execute0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Iterable;)V
            // (Ljava/lang/Iterable;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            ((global::org.drools.runtime.rule.StatelessRuleSession)(@__real)).execute(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Iterable>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void execute1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Object;)V
            // (Ljava/lang/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            ((global::org.drools.runtime.rule.StatelessRuleSession)(@__real)).execute(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle execute2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/command/Command;)Ljava/lang/Object;
            // (Lorg/drools/command/Command;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, ((global::org.drools.runtime.CommandExecutor)(@__real)).execute(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.command.Command>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void addEventListener3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/rule/AgendaEventListener;)V
            // (Lorg/drools/event/rule/AgendaEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            ((global::org.drools.@event.rule.WorkingMemoryEventManager)(@__real)).addEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.AgendaEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void addEventListener4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/rule/WorkingMemoryEventListener;)V
            // (Lorg/drools/event/rule/WorkingMemoryEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            ((global::org.drools.@event.rule.WorkingMemoryEventManager)(@__real)).addEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.WorkingMemoryEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void removeEventListener5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/rule/AgendaEventListener;)V
            // (Lorg/drools/event/rule/AgendaEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            ((global::org.drools.@event.rule.WorkingMemoryEventManager)(@__real)).removeEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.AgendaEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void removeEventListener6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/rule/WorkingMemoryEventListener;)V
            // (Lorg/drools/event/rule/WorkingMemoryEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            ((global::org.drools.@event.rule.WorkingMemoryEventManager)(@__real)).removeEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.WorkingMemoryEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getWorkingMemoryEventListeners7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Collection;
            // ()Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Collection>(@__env, ((global::org.drools.@event.rule.WorkingMemoryEventManager)(@__real)).getWorkingMemoryEventListeners());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getAgendaEventListeners8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Collection;
            // ()Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Collection>(@__env, ((global::org.drools.@event.rule.WorkingMemoryEventManager)(@__real)).getAgendaEventListeners());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void addEventListener9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/process/ProcessEventListener;)V
            // (Lorg/drools/event/process/ProcessEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            ((global::org.drools.@event.process.ProcessEventManager)(@__real)).addEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.process.ProcessEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void removeEventListener10(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/event/process/ProcessEventListener;)V
            // (Lorg/drools/event/process/ProcessEventListener;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            ((global::org.drools.@event.process.ProcessEventManager)(@__real)).removeEventListener(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.process.ProcessEventListener>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getProcessEventListeners11(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/util/Collection;
            // ()Ljava/util/Collection;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Collection>(@__env, ((global::org.drools.@event.process.ProcessEventManager)(@__real)).getProcessEventListeners());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void setGlobal12(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Ljava/lang/String;Ljava/lang/Object;)V
            // (Ljava/lang/String;Ljava/lang/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            @__real.setGlobal(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, par1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getGlobals13(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/runtime/Globals;
            // ()Lorg/drools/runtime/Globals;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.runtime.StatelessKnowledgeSession @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.StatelessKnowledgeSession>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.Globals>(@__env, @__real.getGlobals());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.runtime.@__StatelessKnowledgeSession(@__env);
            }
        }
    }
    #endregion
}