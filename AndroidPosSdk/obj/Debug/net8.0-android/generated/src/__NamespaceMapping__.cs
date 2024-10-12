using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ciontek.ciontekposservice", Managed="Com.Ciontek.Ciontekposservice")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.ctk.sdk", Managed="Com.Ctk.Sdk")]

delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PPB_I (IntPtr jnienv, IntPtr klass, sbyte p0);
delegate int _JniMarshal_PPBB_I (IntPtr jnienv, IntPtr klass, sbyte p0, sbyte p1);
delegate int _JniMarshal_PPBBB_I (IntPtr jnienv, IntPtr klass, sbyte p0, sbyte p1, sbyte p2);
delegate int _JniMarshal_PPBBL_I (IntPtr jnienv, IntPtr klass, sbyte p0, sbyte p1, IntPtr p2);
delegate int _JniMarshal_PPBLILL_I (IntPtr jnienv, IntPtr klass, sbyte p0, IntPtr p1, int p2, IntPtr p3, IntPtr p4);
delegate int _JniMarshal_PPBLL_I (IntPtr jnienv, IntPtr klass, sbyte p0, IntPtr p1, IntPtr p2);
delegate int _JniMarshal_PPC_I (IntPtr jnienv, IntPtr klass, char p0);
delegate int _JniMarshal_PPI_I (IntPtr jnienv, IntPtr klass, int p0);
delegate int _JniMarshal_PPIIICC_I (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, char p3, char p4);
delegate int _JniMarshal_PPIIII_I (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3);
delegate bool _JniMarshal_PPILLI_Z (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, int p3);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate int _JniMarshal_PPLI_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate int _JniMarshal_PPLII_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate int _JniMarshal_PPLIIL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, IntPtr p3);
delegate int _JniMarshal_PPLLIIIL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3, int p4, IntPtr p5);
delegate int _JniMarshal_PPLLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

