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
    public class MsgPack_Serialization_EnumUInt64Serializer : MsgPack.Serialization.EnumMessagePackSerializer<MsgPack.Serialization.EnumUInt64> {
        
        public MsgPack_Serialization_EnumUInt64Serializer(MsgPack.Serialization.SerializationContext context) : 
                this(context, MsgPack.Serialization.EnumSerializationMethod.ByName) {
        }
        
        public MsgPack_Serialization_EnumUInt64Serializer(MsgPack.Serialization.SerializationContext context, MsgPack.Serialization.EnumSerializationMethod enumSerializationMethod) : 
                base(context, enumSerializationMethod) {
        }
        
        protected internal override void PackUnderlyingValueTo(MsgPack.Packer packer, MsgPack.Serialization.EnumUInt64 enumValue) {
            packer.Pack(((ulong)(enumValue)));
        }
        
        protected internal override MsgPack.Serialization.EnumUInt64 UnpackFromUnderlyingValue(MsgPack.MessagePackObject messagePackObject) {
            return ((MsgPack.Serialization.EnumUInt64)(messagePackObject.AsUInt64()));
        }
    }
}
