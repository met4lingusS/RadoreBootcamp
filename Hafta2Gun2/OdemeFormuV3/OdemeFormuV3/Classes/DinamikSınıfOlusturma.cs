using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OdemeFormuV3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormuV3.Classes
{
    public class DinamikSınıfOlusturma
    {
        public static Type DinamikSınıfOlustur(string className, List<string> propertyNames)
        {
            var assemblyName = new AssemblyName("DinamikAssembly");
            var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            var moduleBuilder = assemblyBuilder.DefineDynamicModule("DinamikModule");
            var typeBuilder = moduleBuilder.DefineType(className, TypeAttributes.Public, typeof(object), new[] { typeof(IOdemeTipi) });

            foreach (var propertyName in propertyNames) 
            {
                var fieldBuilder = typeBuilder.DefineField($"_{propertyName.ToLower()}", typeof(string), FieldAttributes.Private);
                var propertyBuilder = typeBuilder.DefineProperty(propertyName, PropertyAttributes.HasDefault, typeof(string), null);

                var getMethodBuilder = typeBuilder.DefineMethod($"get_{propertyName}", MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig, typeof(string), Type.EmptyTypes);
                var getIL = getMethodBuilder.GetILGenerator();
                getIL.Emit(OpCodes.Ldarg_0);
                getIL.Emit(OpCodes.Ldfld, fieldBuilder);
                getIL.Emit(OpCodes.Ret);
                propertyBuilder.SetGetMethod(getMethodBuilder);


                var setMethodBuilder = typeBuilder.DefineMethod($"set_{propertyName}", MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig, null, new[] { typeof(string) });
                var setIL = setMethodBuilder.GetILGenerator();
                setIL.Emit(OpCodes.Ldarg_0);
                setIL.Emit(OpCodes.Ldarg_1);
                setIL.Emit(OpCodes.Stfld, fieldBuilder);
                setIL.Emit(OpCodes.Ret);
                propertyBuilder.SetSetMethod(setMethodBuilder);
            }

            var odeMethodBuilder = typeBuilder.DefineMethod("Ode", MethodAttributes.Public | MethodAttributes.Virtual, typeof(void), new[] { typeof(double) });
            var odeIL = odeMethodBuilder.GetILGenerator();
            odeIL.Emit(OpCodes.Ret);
            typeBuilder.DefineMethodOverride(odeMethodBuilder, typeof(IOdemeTipi).GetMethod("Ode"));

            return typeBuilder.CreateType();

            
        }
    }
}
