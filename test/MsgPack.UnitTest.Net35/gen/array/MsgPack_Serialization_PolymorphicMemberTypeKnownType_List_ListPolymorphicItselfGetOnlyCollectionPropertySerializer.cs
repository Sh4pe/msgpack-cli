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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<string>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty>> _packOperationList;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> typeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            typeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            typeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            typeMap0.Add("1", typeof(System.Collections.Generic.List<string>));
            typeMap0.Add("0", typeof(System.Collections.ObjectModel.Collection<string>));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicCollection(typeof(System.Collections.Generic.IList<string>), typeMap0, null);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<string>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty>(this.PackValueOfListPolymorphicItself);
            this._packOperationList = packOperationList;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty, int>(this.UnpackValueOfListPolymorphicItself);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty, int>>(1);
            unpackOperationTable["ListPolymorphicItself"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty, int>(this.UnpackValueOfListPolymorphicItself);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "ListPolymorphicItself"};
        }
        
        private void PackValueOfListPolymorphicItself(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty objectTree) {
            this._serializer0.PackTo(packer, objectTree.ListPolymorphicItself);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty objectTree) {
            MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
        }
        
        private void UnpackValueOfListPolymorphicItself(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty unpackingContext, int indexOfItem) {
            System.Collections.Generic.IList<string> nullable = default(System.Collections.Generic.IList<string>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "ListPolymorphicItself", unpacker);
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
                System.Collections.Generic.IEnumerator<string> enumerator = nullable.GetEnumerator();
                string current;
                try {
                    for (
                    ; enumerator.MoveNext(); 
                    ) {
                        current = enumerator.Current;
                        unpackingContext.ListPolymorphicItself.Add(current);
                    }
                }
                finally {
                    enumerator.Dispose();
                }
            }
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfGetOnlyCollectionProperty>(), this._unpackOperationTable);
            }
        }
    }
}
