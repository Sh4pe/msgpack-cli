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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<string, string>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>> _packOperationList;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty_set_DictPolymorphicItself0;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicDictionary(typeof(System.Collections.Generic.IDictionary<string, string>), null, null);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<string, string>>(schema0);
            this._methodBasePolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty_set_DictPolymorphicItself0 = typeof(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty).GetMethod("set_DictPolymorphicItself", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)), null, new System.Type[] {
                        typeof(System.Collections.Generic.IDictionary<string, string>)}, null);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>(this.PackValueOfDictPolymorphicItself);
            this._packOperationList = packOperationList;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int>(this.UnpackValueOfDictPolymorphicItself);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int>>(1);
            unpackOperationTable["DictPolymorphicItself"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty, int>(this.UnpackValueOfDictPolymorphicItself);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "DictPolymorphicItself"};
        }
        
        private void PackValueOfDictPolymorphicItself(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictPolymorphicItself);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty objectTree) {
            MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
        }
        
        private void UnpackValueOfDictPolymorphicItself(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty unpackingContext, int indexOfItem) {
            System.Collections.Generic.IDictionary<string, string> nullable = default(System.Collections.Generic.IDictionary<string, string>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "DictPolymorphicItself", unpacker);
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
                if ((unpackingContext.DictPolymorphicItself == null)) {
                    this._methodBasePolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty_set_DictPolymorphicItself0.Invoke(unpackingContext, new object[] {
                                nullable});
                }
                else {
                    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> enumerator = nullable.GetEnumerator();
                    System.Collections.Generic.KeyValuePair<string, string> current;
                    try {
                        for (
                        ; enumerator.MoveNext(); 
                        ) {
                            current = enumerator.Current;
                            unpackingContext.DictPolymorphicItself.Add(current.Key, current.Value);
                        }
                    }
                    finally {
                        enumerator.Dispose();
                    }
                }
            }
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicItselfPrivateSetterCollectionProperty>(), this._unpackOperationTable);
            }
        }
    }
}
