# As of version 3.0.21.825 the package Neodynamic.SDL.ZPLPrinter supports .Net6 and this issue is closed!

# TestZPL
Neodynamic.Sdk.ZPLPrinter v3.0.21.813 does not yet support .Net6. When instantiating a `ZPLPrinter` object the following exception gets thrown. This does not happen in .Net5 nor .NetCore3.1

```
System.Exception
  HResult=0x80131500
  Source=Neodynamic.SDK.ZPLPrinter
  StackTrace:
   at #=qIkPBYiB4hIke6CLjBWsINau1J4dfX0ujxhT95iP$Wpw=.#=zpwim4fv_OHdpO1AhPCvm0AsOFQfv(Byte[] #=zlK7pCyCM8CwZOcbVvcAUC7k0$Q2m)
   at #=qIkPBYiB4hIke6CLjBWsINau1J4dfX0ujxhT95iP$Wpw=.dje_z8WZXLM7HT3XAKGML97GPD7FXGY62AP2NSQ_ejd.#=z5wzauozF8Gsl9MnKqC96Im0$PWLQ(#=zlaISz02WjHDOwH4cveq$iSclcP$H #=zkOH_FN9m40wJfdFgrsbS58Qdu2k2)
   at #=qIkPBYiB4hIke6CLjBWsINau1J4dfX0ujxhT95iP$Wpw=.#=z2aeGDi6d3UHKmD_BvAUmP3I=(String #=zrlE50RfazSc7q8BEDLwAajAQzHkP)
   at #=qbafQ4c8neS5lXijzaTQFJwzQciqeFB6NIXbKDlGr4kE=.#=zyPeDfBu4U_OnlQX12zixjjpaKHuh.#=zAyf6GqURb2J6wKjHKiJ_Q_s$o43q(String #=zNCxuyqzLHZ3MtT_gq2$qGc0=)
   at #=qbafQ4c8neS5lXijzaTQFJwzQciqeFB6NIXbKDlGr4kE=.#=zyPeDfBu4U_OnlQX12zixjjpaKHuh.#=zImvs9JS7x6QsLDF6RnvBhAFhRXPK()
   at #=qbafQ4c8neS5lXijzaTQFJwzQciqeFB6NIXbKDlGr4kE=.#=zZNLQTXbCc2JCCSJksD_jHyoIMpvz(String #=zXF7IzO0=)
   at #=qbafQ4c8neS5lXijzaTQFJwzQciqeFB6NIXbKDlGr4kE=.#=zcPEWVlTCXFTMmrcXcPRj_IXiqkBC(Object #=zL9bGDR0VZ3_t4FjsgTxDL$sRn4RW, ResolveEventArgs #=zGDvkDNiiP2x$mDA1lG55nMcoI_wR)
   at System.Runtime.Loader.AssemblyLoadContext.InvokeResolveEvent(ResolveEventHandler eventHandler, RuntimeAssembly assembly, String name)
   at System.Runtime.Loader.AssemblyLoadContext.OnResourceResolve(RuntimeAssembly assembly, String resourceName)
   at System.Reflection.RuntimeAssembly.GetResource(QCallAssembly assembly, String resourceName, UInt32& length)
   at System.Reflection.RuntimeAssembly.GetManifestResourceStream(String name)
   at System.Reflection.RuntimeAssembly.GetManifestResourceStream(Type type, String name)
   at System.Resources.ManifestBasedResourceGroveler.GrovelForResourceSet(CultureInfo culture, Dictionary`2 localResourceSets, Boolean tryParents, Boolean createIfNotExists)
   at System.Resources.ResourceManager.InternalGetResourceSet(CultureInfo culture, Boolean createIfNotExists, Boolean tryParents)
   at System.Resources.ResourceManager.GetObject(String name, CultureInfo culture, Boolean wrapUnmanagedMemStream)
   at System.Resources.ResourceManager.GetObject(String name, CultureInfo culture)
   at #=zqf$F4jS3l3evNlyGe1KVKV1lePjpsq7ppxMk80QBKwgx.#=zRgNlxozG5hR7wwIAsA==()
   at #=zSdc4IHH6nE3cNoWt7tsRq1xmMCEnEjHtpBAE9hg=..ctor()
   at #=zmOqaf5x8QxvWNCOn0XLXDtFqLLcG12mpCubD1Cs=..ctor()
   at Neodynamic.SDK.ZPLPrinter.ZPLPrinter..ctor(String licenseOwner, String licenseKey)
   at ZPL_Net6.Program.Main(String[] args) in C:\Users\tim.degold\source\repos\TestZPL\ZPL_Net6\Program.cs:line 12
```

This repo is referenced in [this issue](https://github.com/neodynamic/ZPL-Printer-Emulator-SDK/issues/6)
