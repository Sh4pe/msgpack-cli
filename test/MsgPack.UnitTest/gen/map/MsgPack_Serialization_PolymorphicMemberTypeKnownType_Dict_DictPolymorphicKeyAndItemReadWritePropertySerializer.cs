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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWritePropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>> _serializer0;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty>> _packOperationTable;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWritePropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema keysSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> keysSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            keysSchemaTypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            keysSchemaTypeMap0.Add("0", typeof(MsgPack.Serialization.FileEntry));
            keysSchemaTypeMap0.Add("1", typeof(MsgPack.Serialization.DirectoryEntry));
            keysSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), keysSchemaTypeMap0);
            MsgPack.Serialization.PolymorphismSchema valuesSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> valuesSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            valuesSchemaTypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            valuesSchemaTypeMap0.Add("0", typeof(MsgPack.Serialization.FileEntry));
            valuesSchemaTypeMap0.Add("1", typeof(MsgPack.Serialization.DirectoryEntry));
            valuesSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), valuesSchemaTypeMap0);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>), keysSchema0, valuesSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>>(schema0);
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty>>(1);
            packOperationTable["DictPolymorphicKeyAndItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty>(this.PackValueOfDictPolymorphicKeyAndItem);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty, int>(this.UnpackValueOfDictPolymorphicKeyAndItem);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty, int>>(1);
            unpackOperationTable["DictPolymorphicKeyAndItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty, int>(this.UnpackValueOfDictPolymorphicKeyAndItem);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "DictPolymorphicKeyAndItem"};
        }
        
        private void PackValueOfDictPolymorphicKeyAndItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictPolymorphicKeyAndItem);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty objectTree) {
            MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
        }
        
        private void UnpackValueOfDictPolymorphicKeyAndItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty unpackingContext, int indexOfItem) {
            System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> nullable = default(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "DictPolymorphicKeyAndItem", unpacker);
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
                unpackingContext.DictPolymorphicKeyAndItem = nullable;
            }
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicKeyAndItemReadWriteProperty>(), this._unpackOperationTable);
            }
        }
    }
}
