﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8670
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class System_Collections_ObjectModel_Collection_1_System_ObjectArray_Serializer : MsgPack.Serialization.CollectionSerializers.CollectionMessagePackSerializer<System.Collections.ObjectModel.Collection<object[]>, object[]> {
        
        public System_Collections_ObjectModel_Collection_1_System_ObjectArray_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, System_Collections_ObjectModel_Collection_1_System_ObjectArray_Serializer.RestoreSchema()) {
        }
        
        protected override System.Collections.ObjectModel.Collection<object[]> CreateInstance(int initialCapacity) {
            System.Collections.ObjectModel.Collection<object[]> collection = default(System.Collections.ObjectModel.Collection<object[]>);
            collection = new System.Collections.ObjectModel.Collection<object[]>();
            return collection;
        }
        
        private static MsgPack.Serialization.PolymorphismSchema RestoreSchema() {
            MsgPack.Serialization.PolymorphismSchema schema = default(MsgPack.Serialization.PolymorphismSchema);
            schema = null;
            return schema;
        }
    }
}
