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
    public class MsgPack_Serialization_EnumSByteFlagsSerializer : MsgPack.Serialization.EnumMessagePackSerializer<MsgPack.Serialization.EnumSByteFlags> {
        
        public MsgPack_Serialization_EnumSByteFlagsSerializer(MsgPack.Serialization.SerializationContext context) : 
                this(context, MsgPack.Serialization.EnumSerializationMethod.ByName) {
        }
        
        public MsgPack_Serialization_EnumSByteFlagsSerializer(MsgPack.Serialization.SerializationContext context, MsgPack.Serialization.EnumSerializationMethod enumSerializationMethod) : 
                base(context, enumSerializationMethod) {
        }
        
        protected internal override void PackUnderlyingValueTo(MsgPack.Packer packer, MsgPack.Serialization.EnumSByteFlags enumValue) {
            packer.Pack(((sbyte)(enumValue)));
        }
        
        protected internal override MsgPack.Serialization.EnumSByteFlags UnpackFromUnderlyingValue(MsgPack.MessagePackObject messagePackObject) {
            return ((MsgPack.Serialization.EnumSByteFlags)(messagePackObject.AsSByte()));
        }
    }
}
