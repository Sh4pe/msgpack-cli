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
    public class MsgPack_Serialization_PlainClassSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PlainClass> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.List<int>> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer1;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>> _packOperationList;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PlainClassSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Collections.Generic.List<int>>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<int>(schema1);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>[3];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>(this.PackValueOfCollectionReadOnlyProperty);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>(this.PackValueOfPublicField);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PlainClass>(this.PackValueOfPublicProperty);
            this._packOperationList = packOperationList;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>[3];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>(this.UnpackValueOfCollectionReadOnlyProperty);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>(this.UnpackValueOfPublicField);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>(this.UnpackValueOfPublicProperty);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>>(3);
            unpackOperationTable["CollectionReadOnlyProperty"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>(this.UnpackValueOfCollectionReadOnlyProperty);
            unpackOperationTable["PublicField"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>(this.UnpackValueOfPublicField);
            unpackOperationTable["PublicProperty"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PlainClass, int>(this.UnpackValueOfPublicProperty);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "CollectionReadOnlyProperty",
                    "PublicField",
                    "PublicProperty"};
        }
        
        private void PackValueOfCollectionReadOnlyProperty(MsgPack.Packer packer, MsgPack.Serialization.PlainClass objectTree) {
            this._serializer0.PackTo(packer, objectTree.CollectionReadOnlyProperty);
        }
        
        private void PackValueOfPublicField(MsgPack.Packer packer, MsgPack.Serialization.PlainClass objectTree) {
            this._serializer1.PackTo(packer, objectTree.PublicField);
        }
        
        private void PackValueOfPublicProperty(MsgPack.Packer packer, MsgPack.Serialization.PlainClass objectTree) {
            this._serializer1.PackTo(packer, objectTree.PublicProperty);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PlainClass objectTree) {
            MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
        }
        
        private void UnpackValueOfCollectionReadOnlyProperty(MsgPack.Unpacker unpacker, MsgPack.Serialization.PlainClass unpackingContext, int indexOfItem) {
            System.Collections.Generic.List<int> nullable = default(System.Collections.Generic.List<int>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "CollectionReadOnlyProperty", unpacker);
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
                System.Collections.Generic.List<int>.Enumerator enumerator = nullable.GetEnumerator();
                int current;
                try {
                    for (
                    ; enumerator.MoveNext(); 
                    ) {
                        current = enumerator.Current;
                        unpackingContext.CollectionReadOnlyProperty.Add(current);
                    }
                }
                finally {
                    enumerator.Dispose();
                }
            }
        }
        
        private void UnpackValueOfPublicField(MsgPack.Unpacker unpacker, MsgPack.Serialization.PlainClass unpackingContext, int indexOfItem) {
            System.Nullable<int> nullable0 = default(System.Nullable<int>);
            nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.PlainClass), "PublicField");
            if (nullable0.HasValue) {
                unpackingContext.PublicField = nullable0.Value;
            }
        }
        
        private void UnpackValueOfPublicProperty(MsgPack.Unpacker unpacker, MsgPack.Serialization.PlainClass unpackingContext, int indexOfItem) {
            System.Nullable<int> nullable1 = default(System.Nullable<int>);
            nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.PlainClass), "PublicProperty");
            if (nullable1.HasValue) {
                unpackingContext.PublicProperty = nullable1.Value;
            }
        }
        
        protected internal override MsgPack.Serialization.PlainClass UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PlainClass result = default(MsgPack.Serialization.PlainClass);
            result = new MsgPack.Serialization.PlainClass();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PlainClass>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PlainClass>(), this._unpackOperationTable);
            }
        }
    }
}
