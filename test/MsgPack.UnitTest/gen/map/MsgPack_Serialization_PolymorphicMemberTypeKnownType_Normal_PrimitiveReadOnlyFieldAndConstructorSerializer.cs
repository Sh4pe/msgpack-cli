﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer0;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor>> _packOperationTable;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<int>(schema0);
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor>>(1);
            packOperationTable["Primitive"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor>(this.PackValueOfPrimitive);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, UnpackingContext, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfPrimitive);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>>(1);
            unpackOperationTable["Primitive"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfPrimitive);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Primitive"};
        }
        
        private void PackValueOfPrimitive(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Primitive);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor objectTree) {
            MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
        }
        
        private MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor(unpackingContext.Primitive);
            return result;
        }
        
        private void UnpackValueOfPrimitive(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem) {
            System.Nullable<int> nullable = default(System.Nullable<int>);
            nullable = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor), "Primitive");
            if (nullable.HasValue) {
                unpackingContext.Primitive = nullable.Value;
            }
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            int ctorArg0 = default(int);
            ctorArg0 = 0;
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor>(this.CreateInstanceFromContext), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitiveReadOnlyFieldAndConstructor>(this.CreateInstanceFromContext), this._unpackOperationTable);
            }
        }
        
        public class UnpackingContext {
            
            public int Primitive;
            
            public UnpackingContext(int Primitive) {
                this.Primitive = Primitive;
            }
        }
    }
}
