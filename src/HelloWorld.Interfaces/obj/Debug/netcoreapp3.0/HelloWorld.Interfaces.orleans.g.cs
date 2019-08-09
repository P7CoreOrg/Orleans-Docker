// <auto-generated />
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 618
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::Orleans.Metadata.FeaturePopulatorAttribute(typeof(OrleansGeneratedCode.OrleansCodeGen2dde462ab5FeaturePopulator))]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute(@"HelloWorld.Interfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace HelloWorld.Interfaces
{
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof(global::HelloWorld.Interfaces.IHello))]
    internal class OrleansCodeGenHelloReference : global::Orleans.Runtime.GrainReference, global::HelloWorld.Interfaces.IHello
    {
        protected OrleansCodeGenHelloReference(global::Orleans.Runtime.GrainReference other): base(other)
        {
        }

        OrleansCodeGenHelloReference(global::Orleans.Runtime.GrainReference other, global::Orleans.CodeGeneration.InvokeMethodOptions invokeMethodOptions): base(other, invokeMethodOptions)
        {
        }

        protected OrleansCodeGenHelloReference(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context): base(info, context)
        {
        }

        public override global::System.Int32 InterfaceId
        {
            get
            {
                return -1093836014;
            }
        }

        public override global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return @"global::HelloWorld.Interfaces.IHello";
            }
        }

        public override global::System.Boolean IsCompatible(global::System.Int32 interfaceId)
        {
            return interfaceId == -1093836014;
        }

        public override global::System.String GetMethodName(global::System.Int32 interfaceId, global::System.Int32 methodId)
        {
            switch (interfaceId)
            {
                case -1093836014:
                    switch (methodId)
                    {
                        case 2110985857:
                            return @"SayHello";
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + -1093836014 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> SayHello(global::System.String greeting)
        {
            return base.InvokeMethodAsync<global::System.String>(2110985857, new global::System.Object[]{greeting});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof(global::HelloWorld.Interfaces.IHello), -1093836014), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenHelloMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public async global::System.Threading.Tasks.Task<global::System.Object> Invoke(global::Orleans.Runtime.IAddressable grain, global::Orleans.CodeGeneration.InvokeMethodRequest request)
        {
            global::System.Int32 interfaceId = request.InterfaceId;
            global::System.Int32 methodId = request.MethodId;
            global::System.Object[] arguments = request.Arguments;
            if (grain == null)
                throw new global::System.ArgumentNullException(@"grain");
            switch (interfaceId)
            {
                case -1093836014:
                    switch (methodId)
                    {
                        case 2110985857:
                            return await ((global::HelloWorld.Interfaces.IHello)grain).SayHello((global::System.String)arguments[0]);
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + -1093836014 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1093836014;
            }
        }

        public global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof(global::HelloWorld.Interfaces.IHelloArchive))]
    internal class OrleansCodeGenHelloArchiveReference : global::Orleans.Runtime.GrainReference, global::HelloWorld.Interfaces.IHelloArchive
    {
        protected OrleansCodeGenHelloArchiveReference(global::Orleans.Runtime.GrainReference other): base(other)
        {
        }

        OrleansCodeGenHelloArchiveReference(global::Orleans.Runtime.GrainReference other, global::Orleans.CodeGeneration.InvokeMethodOptions invokeMethodOptions): base(other, invokeMethodOptions)
        {
        }

        protected OrleansCodeGenHelloArchiveReference(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context): base(info, context)
        {
        }

        public override global::System.Int32 InterfaceId
        {
            get
            {
                return 1373428662;
            }
        }

        public override global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return @"global::HelloWorld.Interfaces.IHelloArchive";
            }
        }

        public override global::System.Boolean IsCompatible(global::System.Int32 interfaceId)
        {
            return interfaceId == 1373428662;
        }

        public override global::System.String GetMethodName(global::System.Int32 interfaceId, global::System.Int32 methodId)
        {
            switch (interfaceId)
            {
                case 1373428662:
                    switch (methodId)
                    {
                        case 2110985857:
                            return @"SayHello";
                        case 828150056:
                            return @"GetGreetings";
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + 1373428662 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.String> SayHello(global::System.String greeting)
        {
            return base.InvokeMethodAsync<global::System.String>(2110985857, new global::System.Object[]{greeting});
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<global::System.String>> GetGreetings()
        {
            return base.InvokeMethodAsync<global::System.Collections.Generic.IEnumerable<global::System.String>>(828150056, null);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute(typeof(global::HelloWorld.Interfaces.IHelloArchive), 1373428662), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenHelloArchiveMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public async global::System.Threading.Tasks.Task<global::System.Object> Invoke(global::Orleans.Runtime.IAddressable grain, global::Orleans.CodeGeneration.InvokeMethodRequest request)
        {
            global::System.Int32 interfaceId = request.InterfaceId;
            global::System.Int32 methodId = request.MethodId;
            global::System.Object[] arguments = request.Arguments;
            if (grain == null)
                throw new global::System.ArgumentNullException(@"grain");
            switch (interfaceId)
            {
                case 1373428662:
                    switch (methodId)
                    {
                        case 2110985857:
                            return await ((global::HelloWorld.Interfaces.IHelloArchive)grain).SayHello((global::System.String)arguments[0]);
                        case 828150056:
                            return await ((global::HelloWorld.Interfaces.IHelloArchive)grain).GetGreetings();
                        default:
                            throw new global::System.NotImplementedException(@"interfaceId=" + 1373428662 + @",methodId=" + methodId);
                    }

                default:
                    throw new global::System.NotImplementedException(@"interfaceId=" + interfaceId);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1373428662;
            }
        }

        public global::System.UInt16 InterfaceVersion
        {
            get
            {
                return 1;
            }
        }
    }
}

namespace OrleansGeneratedCodeC91C4514
{
    using global::Orleans;
    using global::System.Reflection;
}

namespace OrleansGeneratedCode
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(@"Orleans-CodeGenerator", @"2.0.0.0")]
    internal sealed class OrleansCodeGen2dde462ab5FeaturePopulator : global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainInterfaceFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Metadata.GrainClassFeature>, global::Orleans.Metadata.IFeaturePopulator<global::Orleans.Serialization.SerializerFeature>
    {
        public void Populate(global::Orleans.Metadata.GrainInterfaceFeature feature)
        {
            feature.Interfaces.Add(new global::Orleans.Metadata.GrainInterfaceMetadata(typeof(global::HelloWorld.Interfaces.IHello), typeof(HelloWorld.Interfaces.OrleansCodeGenHelloReference), typeof(HelloWorld.Interfaces.OrleansCodeGenHelloMethodInvoker), -1093836014));
            feature.Interfaces.Add(new global::Orleans.Metadata.GrainInterfaceMetadata(typeof(global::HelloWorld.Interfaces.IHelloArchive), typeof(HelloWorld.Interfaces.OrleansCodeGenHelloArchiveReference), typeof(HelloWorld.Interfaces.OrleansCodeGenHelloArchiveMethodInvoker), 1373428662));
        }

        public void Populate(global::Orleans.Metadata.GrainClassFeature feature)
        {
        }

        public void Populate(global::Orleans.Serialization.SerializerFeature feature)
        {
            feature.AddKnownType(@"System.Action`9,System.Runtime", @"Action`9'9");
            feature.AddKnownType(@"System.Action`10,System.Runtime", @"Action`10'10");
            feature.AddKnownType(@"System.Action`11,System.Runtime", @"Action`11'11");
            feature.AddKnownType(@"System.Action`12,System.Runtime", @"Action`12'12");
            feature.AddKnownType(@"System.Action`13,System.Runtime", @"Action`13'13");
            feature.AddKnownType(@"System.Action`14,System.Runtime", @"Action`14'14");
            feature.AddKnownType(@"System.Action`15,System.Runtime", @"Action`15'15");
            feature.AddKnownType(@"System.Action`16,System.Runtime", @"Action`16'16");
            feature.AddKnownType(@"System.Func`10,System.Runtime", @"Func`10'10");
            feature.AddKnownType(@"System.Func`11,System.Runtime", @"Func`11'11");
            feature.AddKnownType(@"System.Func`12,System.Runtime", @"Func`12'12");
            feature.AddKnownType(@"System.Func`13,System.Runtime", @"Func`13'13");
            feature.AddKnownType(@"System.Func`14,System.Runtime", @"Func`14'14");
            feature.AddKnownType(@"System.Func`15,System.Runtime", @"Func`15'15");
            feature.AddKnownType(@"System.Func`16,System.Runtime", @"Func`16'16");
            feature.AddKnownType(@"System.Func`17,System.Runtime", @"Func`17'17");
            feature.AddKnownType(@"System.Lazy`2,System.Runtime", @"Lazy`2'2");
            feature.AddKnownType(@"System.Threading.WaitHandleExtensions,System.Runtime", @"WaitHandleExtensions");
            feature.AddKnownType(@"System.Runtime.AssemblyTargetedPatchBandAttribute,System.Runtime", @"AssemblyTargetedPatchBandAttribute");
            feature.AddKnownType(@"System.Runtime.TargetedPatchingOptOutAttribute,System.Runtime", @"TargetedPatchingOptOutAttribute");
            feature.AddKnownType(@"System.Runtime.ConstrainedExecution.PrePrepareMethodAttribute,System.Runtime", @"PrePrepareMethodAttribute");
            feature.AddKnownType(@"System.Reflection.RuntimeReflectionExtensions,System.Runtime", @"RuntimeReflectionExtensions");
            feature.AddKnownType(@"System.IO.FileAttributes,System.Runtime", @"FileAttributes");
            feature.AddKnownType(@"System.IO.HandleInheritability,System.Runtime", @"HandleInheritability");
            feature.AddKnownType(@"HelloWorld.Interfaces.IHello,HelloWorld.Interfaces", @"HelloWorld.Interfaces.IHello");
            feature.AddKnownType(@"HelloWorld.Interfaces.IHelloArchive,HelloWorld.Interfaces", @"HelloWorld.Interfaces.IHelloArchive");
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
