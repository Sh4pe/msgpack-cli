﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_WithAbstractStringCollectionSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.WithAbstractStringCollection> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<string>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractStringCollection>> _packOperationList;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractStringCollection, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractStringCollection, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_WithAbstractStringCollectionSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<string>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractStringCollection>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractStringCollection>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractStringCollection>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractStringCollection>(this.PackValueOfCollection);
            this._packOperationList = packOperationList;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractStringCollection, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractStringCollection, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractStringCollection, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractStringCollection, int>(this.UnpackValueOfCollection);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractStringCollection, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractStringCollection, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractStringCollection, int>>(1);
            unpackOperationTable["Collection"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractStringCollection, int>(this.UnpackValueOfCollection);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Collection"};
        }
        
        private void PackValueOfCollection(MsgPack.Packer packer, MsgPack.Serialization.WithAbstractStringCollection objectTree) {
            this._serializer0.PackTo(packer, objectTree.Collection);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.WithAbstractStringCollection objectTree) {
            MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
        }
        
        private void UnpackValueOfCollection(MsgPack.Unpacker unpacker, MsgPack.Serialization.WithAbstractStringCollection unpackingContext, int indexOfItem) {
            System.Collections.Generic.IList<string> nullable = default(System.Collections.Generic.IList<string>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "Collection", unpacker);
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
                unpackingContext.Collection = nullable;
            }
        }
        
        protected internal override MsgPack.Serialization.WithAbstractStringCollection UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.WithAbstractStringCollection result = default(MsgPack.Serialization.WithAbstractStringCollection);
            result = new MsgPack.Serialization.WithAbstractStringCollection();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.WithAbstractStringCollection>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.WithAbstractStringCollection>(), this._unpackOperationTable);
            }
        }
    }
}
