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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteFieldSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField> {
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.FileSystemEntry> _serializer0;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField>> _packOperationTable;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteFieldSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> typeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            typeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            typeMap0.Add("0", typeof(MsgPack.Serialization.FileEntry));
            typeMap0.Add("1", typeof(MsgPack.Serialization.DirectoryEntry));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), typeMap0);
            this._serializer0 = context.GetSerializer<MsgPack.Serialization.FileSystemEntry>(schema0);
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField>>(1);
            packOperationTable["Polymorphic"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField>(this.PackValueOfPolymorphic);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField, int>(this.UnpackValueOfPolymorphic);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField, int>>(1);
            unpackOperationTable["Polymorphic"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField, int>(this.UnpackValueOfPolymorphic);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Polymorphic"};
        }
        
        private void PackValueOfPolymorphic(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField objectTree) {
            this._serializer0.PackTo(packer, objectTree.Polymorphic);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField objectTree) {
            MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
        }
        
        private void UnpackValueOfPolymorphic(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField unpackingContext, int indexOfItem) {
            MsgPack.Serialization.FileSystemEntry nullable = default(MsgPack.Serialization.FileSystemEntry);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "Polymorphic", unpacker);
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
                unpackingContext.Polymorphic = nullable;
            }
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PolymorphicReadWriteField>(), this._unpackOperationTable);
            }
        }
    }
}
