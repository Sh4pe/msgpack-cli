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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWritePropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<object, object>> _serializer0;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty>> _packOperationTable;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWritePropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema keysSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> keysSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            keysSchemaTypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            keysSchemaTypeMap0.Add("0", typeof(MsgPack.Serialization.FileEntry));
            keysSchemaTypeMap0.Add("1", typeof(MsgPack.Serialization.DirectoryEntry));
            keysSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(object), keysSchemaTypeMap0);
            MsgPack.Serialization.PolymorphismSchema valuesSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> valuesSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            valuesSchemaTypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            valuesSchemaTypeMap0.Add("1", typeof(MsgPack.Serialization.DirectoryEntry));
            valuesSchemaTypeMap0.Add("0", typeof(MsgPack.Serialization.FileEntry));
            valuesSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(object), valuesSchemaTypeMap0);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<object, object>), keysSchema0, valuesSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<object, object>>(schema0);
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty>>(1);
            packOperationTable["DictObjectKeyAndItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty>(this.PackValueOfDictObjectKeyAndItem);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty, int>(this.UnpackValueOfDictObjectKeyAndItem);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty, int>>(1);
            unpackOperationTable["DictObjectKeyAndItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty, int>(this.UnpackValueOfDictObjectKeyAndItem);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "DictObjectKeyAndItem"};
        }
        
        private void PackValueOfDictObjectKeyAndItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictObjectKeyAndItem);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty objectTree) {
            MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
        }
        
        private void UnpackValueOfDictObjectKeyAndItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty unpackingContext, int indexOfItem) {
            System.Collections.Generic.IDictionary<object, object> nullable = default(System.Collections.Generic.IDictionary<object, object>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "DictObjectKeyAndItem", unpacker);
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
                unpackingContext.DictObjectKeyAndItem = nullable;
            }
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictObjectKeyAndItemReadWriteProperty>(), this._unpackOperationTable);
            }
        }
    }
}
