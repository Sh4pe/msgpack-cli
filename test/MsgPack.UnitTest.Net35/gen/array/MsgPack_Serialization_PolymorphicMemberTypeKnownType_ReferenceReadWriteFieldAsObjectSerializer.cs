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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObjectSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject> {
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject>> _packOperationList;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObjectSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<object>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject>(this.PackValueOfReference);
            this._packOperationList = packOperationList;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject, int>(this.UnpackValueOfReference);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject, int>>(1);
            unpackOperationTable["Reference"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject, int>(this.UnpackValueOfReference);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Reference"};
        }
        
        private void PackValueOfReference(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject objectTree) {
            this._serializer0.PackTo(packer, objectTree.Reference);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject objectTree) {
            MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
        }
        
        private void UnpackValueOfReference(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject unpackingContext, int indexOfItem) {
            object nullable = default(object);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "Reference", unpacker);
            }
            if (((unpacker.IsArrayHeader == false) 
                        && (unpacker.IsMapHeader == false))) {
                nullable = this._serializer0.UnpackFrom(unpacker);
            }
            else {
                MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                disposable = unpacker.ReadSubtree();
                try {
                    nullable = this._serializer0.UnpackFrom(disposable);
                }
                finally {
                    if (((disposable == null) 
                                == false)) {
                        disposable.Dispose();
                    }
                }
            }
            if (((nullable == null) 
                        == false)) {
                unpackingContext.Reference = nullable;
            }
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_ReferenceReadWriteFieldAsObject>(), this._unpackOperationTable);
            }
        }
    }
}
