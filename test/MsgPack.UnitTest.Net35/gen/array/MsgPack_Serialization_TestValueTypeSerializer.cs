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
    public class MsgPack_Serialization_TestValueTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.TestValueType> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<int, int>> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<int[]> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer2;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>> _packOperationList;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_TestValueTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Collections.Generic.Dictionary<int, int>>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<int[]>(schema1);
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer2 = context.GetSerializer<string>(schema2);
            System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>[3];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfDictionaryField);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfInt32ArrayField);
            packOperationList[2] = new System.Action<MsgPack.Packer, MsgPack.Serialization.TestValueType>(this.PackValueOfStringField);
            this._packOperationList = packOperationList;
            System.Action<MsgPack.Unpacker, UnpackingContext, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int>[3];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfDictionaryField);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfInt32ArrayField);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfStringField);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>>(3);
            unpackOperationTable["DictionaryField"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfDictionaryField);
            unpackOperationTable["Int32ArrayField"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfInt32ArrayField);
            unpackOperationTable["StringField"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfStringField);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "DictionaryField",
                    "Int32ArrayField",
                    "StringField"};
        }
        
        private void PackValueOfDictionaryField(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictionaryField);
        }
        
        private void PackValueOfInt32ArrayField(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree) {
            this._serializer1.PackTo(packer, objectTree.Int32ArrayField);
        }
        
        private void PackValueOfStringField(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree) {
            this._serializer2.PackTo(packer, objectTree.StringField);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.TestValueType objectTree) {
            MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
        }
        
        private MsgPack.Serialization.TestValueType CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.TestValueType result = default(MsgPack.Serialization.TestValueType);
            result.DictionaryField = unpackingContext.DictionaryField;
            result.Int32ArrayField = unpackingContext.Int32ArrayField;
            result.StringField = unpackingContext.StringField;
            return result;
        }
        
        private void UnpackValueOfDictionaryField(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem) {
            System.Collections.Generic.Dictionary<int, int> nullable = default(System.Collections.Generic.Dictionary<int, int>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "DictionaryField", unpacker);
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
                unpackingContext.DictionaryField = nullable;
            }
        }
        
        private void UnpackValueOfInt32ArrayField(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem) {
            int[] nullable0 = default(int[]);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "Int32ArrayField", unpacker);
            }
            if (((unpacker.IsArrayHeader == false) 
                        && (unpacker.IsMapHeader == false))) {
                nullable0 = this._serializer1.UnpackFrom(unpacker);
            }
            else {
                MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                disposable0 = unpacker.ReadSubtree();
                try {
                    nullable0 = this._serializer1.UnpackFrom(disposable0);
                }
                finally {
                    if (((disposable0 == null) 
                                == false)) {
                        disposable0.Dispose();
                    }
                }
            }
            if (((nullable0 == null) 
                        == false)) {
                unpackingContext.Int32ArrayField = nullable0;
            }
        }
        
        private void UnpackValueOfStringField(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem) {
            string nullable1 = default(string);
            nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.TestValueType), "StringField");
            if (((nullable1 == null) 
                        == false)) {
                unpackingContext.StringField = nullable1;
            }
        }
        
        protected internal override MsgPack.Serialization.TestValueType UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            System.Collections.Generic.Dictionary<int, int> ctorArg0 = default(System.Collections.Generic.Dictionary<int, int>);
            ctorArg0 = default(System.Collections.Generic.Dictionary<int, int>);
            int[] ctorArg1 = default(int[]);
            ctorArg1 = default(int[]);
            string ctorArg2 = default(string);
            ctorArg2 = default(string);
            unpackingContext = new UnpackingContext(ctorArg0, ctorArg1, ctorArg2);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, new System.Func<UnpackingContext, MsgPack.Serialization.TestValueType>(this.CreateInstanceFromContext), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, new System.Func<UnpackingContext, MsgPack.Serialization.TestValueType>(this.CreateInstanceFromContext), this._unpackOperationTable);
            }
        }
        
        public class UnpackingContext {
            
            public System.Collections.Generic.Dictionary<int, int> DictionaryField;
            
            public int[] Int32ArrayField;
            
            public string StringField;
            
            public UnpackingContext(System.Collections.Generic.Dictionary<int, int> DictionaryField, int[] Int32ArrayField, string StringField) {
                this.DictionaryField = DictionaryField;
                this.Int32ArrayField = Int32ArrayField;
                this.StringField = StringField;
            }
        }
    }
}
