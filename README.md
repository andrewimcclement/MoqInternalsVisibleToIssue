Stack trace of failure on .NET 6.0:
```
System.ArgumentException : Type to mock (Production.InternalDerivedControl) must be an interface, a delegate, or a non-sealed, non-static class.
  ----> System.TypeLoadException : Method 'ShouldSerializeImeMode' on type 'Castle.Proxies.InternalDerivedControlProxy' from assembly 'DynamicProxyGenAssembly2, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null' is overriding a method that is not visible from that assembly.
   at Moq.CastleProxyFactory.CreateProxy(Type mockType, IInterceptor interceptor, Type[] interfaces, Object[] arguments) in /_/src/Moq/Interception/CastleProxyFactory.cs:line 114
   at Moq.Mock`1.InitializeInstance() in /_/src/Moq/Mock`1.cs:line 502
   at Moq.Mock`1.OnGetObject() in /_/src/Moq/Mock`1.cs:line 516
   at Moq.Mock.get_Object() in /_/src/Moq/Mock.cs:line 180
   at Moq.Mock`1.get_Object() in /_/src/Moq/Mock`1.cs:line 453
   at Production.Tests.InternalsVisibleToTests.FailsOnNetCore() in C:\Git\github\andrewimcclement\MoqInternalsVisibleToIssue\Production.Tests\UnitTest1.cs:line 21
--TypeLoadException
   at System.Reflection.Emit.TypeBuilder.CreateTypeNoLock()
   at System.Reflection.Emit.TypeBuilder.CreateTypeInfo()
   at Castle.DynamicProxy.Generators.Emitters.AbstractTypeEmitter.BuildType()
   at Castle.DynamicProxy.Generators.BaseClassProxyGenerator.GenerateType(String name, INamingScope namingScope)
   at Castle.DynamicProxy.Generators.BaseProxyGenerator.<>c__DisplayClass13_0.<GetProxyType>b__0(CacheKey cacheKey)
   at Castle.Core.Internal.SynchronizedDictionary`2.GetOrAdd(TKey key, Func`2 valueFactory)
   at Castle.DynamicProxy.Generators.BaseProxyGenerator.GetProxyType()
   at Castle.DynamicProxy.DefaultProxyBuilder.CreateClassProxyType(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
   at Castle.DynamicProxy.ProxyGenerator.CreateClassProxyType(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
   at Castle.DynamicProxy.ProxyGenerator.CreateClassProxy(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options, Object[] constructorArguments, IInterceptor[] interceptors)
   at Moq.CastleProxyFactory.CreateProxy(Type mockType, IInterceptor interceptor, Type[] interfaces, Object[] arguments) in /_/src/Moq/Interception/CastleProxyFactory.cs:line 110
```

Stack trace of failure on .NET 8.0:
```
System.ArgumentException : Type to mock (Production.InternalDerivedControl) must be an interface, a delegate, or a non-sealed, non-static class.
  ----> System.TypeLoadException : Method 'NotifyValidationResult' on type 'Castle.Proxies.InternalDerivedControlProxy' from assembly 'DynamicProxyGenAssembly2, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null' is overriding a method that is not visible from that assembly.
   at Moq.CastleProxyFactory.CreateProxy(Type mockType, IInterceptor interceptor, Type[] interfaces, Object[] arguments) in /_/src/Moq/Interception/CastleProxyFactory.cs:line 114
   at Moq.Mock`1.InitializeInstance() in /_/src/Moq/Mock`1.cs:line 502
   at Moq.Mock`1.OnGetObject() in /_/src/Moq/Mock`1.cs:line 516
   at Moq.Mock.get_Object() in /_/src/Moq/Mock.cs:line 180
   at Moq.Mock`1.get_Object() in /_/src/Moq/Mock`1.cs:line 453
   at Production.Tests.InternalsVisibleToTests.FailsOnNetCore() in C:\Git\github\andrewimcclement\MoqInternalsVisibleToIssue\Production.Tests\UnitTest1.cs:line 21
   at System.RuntimeMethodHandle.InvokeMethod(Object target, Void** arguments, Signature sig, Boolean isConstructor)
   at System.Reflection.MethodBaseInvoker.InvokeWithNoArgs(Object obj, BindingFlags invokeAttr)
--TypeLoadException
   at System.Reflection.Emit.RuntimeTypeBuilder.CreateTypeNoLock()
   at System.Reflection.Emit.RuntimeTypeBuilder.CreateTypeInfoImpl()
   at System.Reflection.Emit.TypeBuilder.CreateTypeInfo()
   at Castle.DynamicProxy.Generators.Emitters.AbstractTypeEmitter.CreateType(TypeBuilder type)
   at Castle.DynamicProxy.Generators.Emitters.AbstractTypeEmitter.BuildType()
   at Castle.DynamicProxy.Generators.BaseClassProxyGenerator.GenerateType(String name, INamingScope namingScope)
   at Castle.DynamicProxy.Generators.BaseProxyGenerator.<>c__DisplayClass13_0.<GetProxyType>b__0(CacheKey cacheKey)
   at Castle.Core.Internal.SynchronizedDictionary`2.GetOrAdd(TKey key, Func`2 valueFactory)
   at Castle.DynamicProxy.Generators.BaseProxyGenerator.GetProxyType()
   at Castle.DynamicProxy.DefaultProxyBuilder.CreateClassProxyType(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
   at Castle.DynamicProxy.ProxyGenerator.CreateClassProxyType(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options)
   at Castle.DynamicProxy.ProxyGenerator.CreateClassProxy(Type classToProxy, Type[] additionalInterfacesToProxy, ProxyGenerationOptions options, Object[] constructorArguments, IInterceptor[] interceptors)
   at Moq.CastleProxyFactory.CreateProxy(Type mockType, IInterceptor interceptor, Type[] interfaces, Object[] arguments) in /_/src/Moq/Interception/CastleProxyFactory.cs:line 110
```
