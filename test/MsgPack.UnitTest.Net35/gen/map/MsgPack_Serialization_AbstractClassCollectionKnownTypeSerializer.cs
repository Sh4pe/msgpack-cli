﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8670
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_AbstractClassCollectionKnownTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.AbstractClassCollectionKnownType> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.ObjectModel.KeyedCollection<string, string>> _serializer0;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassCollectionKnownType>> _packOperationTable;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassCollectionKnownType, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassCollectionKnownType, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_AbstractClassCollectionKnownTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> typeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            typeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(1);
            typeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(1);
            typeMap0.Add("1", typeof(MsgPack.Serialization.EchoKeyedCollection<string, string>));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicCollection(typeof(System.Collections.ObjectModel.KeyedCollection<string, string>), typeMap0, null);
            this._serializer0 = context.GetSerializer<System.Collections.ObjectModel.KeyedCollection<string, string>>(schema0);
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassCollectionKnownType>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassCollectionKnownType>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassCollectionKnownType>>(1);
            packOperationTable["Value"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.AbstractClassCollectionKnownType>(this.PackValueOfValue);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassCollectionKnownType, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassCollectionKnownType, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassCollectionKnownType, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassCollectionKnownType, int>(this.UnpackValueOfValue);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassCollectionKnownType, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassCollectionKnownType, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassCollectionKnownType, int>>(1);
            unpackOperationTable["Value"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.AbstractClassCollectionKnownType, int>(this.UnpackValueOfValue);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Value"};
        }
        
        private void PackValueOfValue(MsgPack.Packer packer, MsgPack.Serialization.AbstractClassCollectionKnownType objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.AbstractClassCollectionKnownType objectTree) {
            MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
        }
        
        private void UnpackValueOfValue(MsgPack.Unpacker unpacker, MsgPack.Serialization.AbstractClassCollectionKnownType unpackingContext, int indexOfItem) {
            System.Collections.ObjectModel.KeyedCollection<string, string> nullable = default(System.Collections.ObjectModel.KeyedCollection<string, string>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "Value", unpacker);
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
                unpackingContext.Value = nullable;
            }
        }
        
        protected internal override MsgPack.Serialization.AbstractClassCollectionKnownType UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.AbstractClassCollectionKnownType result = default(MsgPack.Serialization.AbstractClassCollectionKnownType);
            result = new MsgPack.Serialization.AbstractClassCollectionKnownType();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.AbstractClassCollectionKnownType>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.AbstractClassCollectionKnownType>(), this._unpackOperationTable);
            }
        }
    }
}
