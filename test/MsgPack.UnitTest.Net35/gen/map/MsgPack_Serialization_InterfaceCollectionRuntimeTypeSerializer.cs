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
    public class MsgPack_Serialization_InterfaceCollectionRuntimeTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.InterfaceCollectionRuntimeType> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<string>> _serializer0;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceCollectionRuntimeType>> _packOperationTable;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceCollectionRuntimeType, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceCollectionRuntimeType, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_InterfaceCollectionRuntimeTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicCollection(typeof(System.Collections.Generic.IList<string>), null);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<string>>(schema0);
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceCollectionRuntimeType>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceCollectionRuntimeType>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceCollectionRuntimeType>>(1);
            packOperationTable["Value"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.InterfaceCollectionRuntimeType>(this.PackValueOfValue);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceCollectionRuntimeType, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceCollectionRuntimeType, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceCollectionRuntimeType, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceCollectionRuntimeType, int>(this.UnpackValueOfValue);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceCollectionRuntimeType, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceCollectionRuntimeType, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceCollectionRuntimeType, int>>(1);
            unpackOperationTable["Value"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.InterfaceCollectionRuntimeType, int>(this.UnpackValueOfValue);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Value"};
        }
        
        private void PackValueOfValue(MsgPack.Packer packer, MsgPack.Serialization.InterfaceCollectionRuntimeType objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.InterfaceCollectionRuntimeType objectTree) {
            MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
        }
        
        private void UnpackValueOfValue(MsgPack.Unpacker unpacker, MsgPack.Serialization.InterfaceCollectionRuntimeType unpackingContext, int indexOfItem) {
            System.Collections.Generic.IList<string> nullable = default(System.Collections.Generic.IList<string>);
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
        
        protected internal override MsgPack.Serialization.InterfaceCollectionRuntimeType UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.InterfaceCollectionRuntimeType result = default(MsgPack.Serialization.InterfaceCollectionRuntimeType);
            result = new MsgPack.Serialization.InterfaceCollectionRuntimeType();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.InterfaceCollectionRuntimeType>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.InterfaceCollectionRuntimeType>(), this._unpackOperationTable);
            }
        }
    }
}
