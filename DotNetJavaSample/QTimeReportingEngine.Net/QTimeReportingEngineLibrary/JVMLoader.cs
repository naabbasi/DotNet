using net.sf.jni4net;
using com.qterminals.integration;
using com.qterminals.reporting;

namespace QTimeReportingEngineLibrary
{
    public class JVMLoader
    {
        private static BridgeSetup bridgeSetup;
        private string[] args;
        private string jdkHome;
        private string libPath;

        private JVMLoader() { }

        public JVMLoader(string jdkHome, string libPath)
        {
            this.jdkHome = jdkHome;
            this.libPath = libPath;
        }

        public JVMLoader(string[] args, string jdkHome, string libPath)
        {
            this.args = args;
            this.jdkHome = jdkHome;
            this.libPath = libPath;
        }

        private void checkBridgeInitialization()
        {
            if(bridgeSetup == null)
            {
                if(args == null)
                {
                    bridgeSetup = new BridgeSetup(new string[0]);
                } else
                {
                    bridgeSetup = new BridgeSetup(args);
                }
                
                bridgeSetup.JavaHome = jdkHome;
                bridgeSetup.IgnoreJavaHome = false;
                bridgeSetup.Verbose = true;
                bridgeSetup.AddAllJarsClassPath(libPath);
                Bridge.CreateJVM(bridgeSetup);

                java.lang.System.@out.println("Greetings from C# using Java System.out.println!");

                Bridge.RegisterAssembly(typeof(InitializeIntegration).Assembly);
                Bridge.RegisterAssembly(typeof(JasperReportEngine).Assembly);

                InitializeIntegration.Setup(new java.lang.String[0]);
            }
        }

        public JasperReportEngine GetJasperReportEngine()
        {
            checkBridgeInitialization();

            JasperReportEngine jasperReportEngine = new JasperReportEngineImpl();
            return jasperReportEngine;
        }
    }
}
