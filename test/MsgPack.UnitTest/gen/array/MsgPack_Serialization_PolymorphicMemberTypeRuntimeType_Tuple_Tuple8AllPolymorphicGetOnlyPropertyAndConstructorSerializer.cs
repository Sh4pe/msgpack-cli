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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor>> _packOperationList;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema[] tupleItemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema[]);
            tupleItemsSchema0 = new MsgPack.Serialization.PolymorphismSchema[8];
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[0] = tupleItemSchema0;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema1 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema1 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[1] = tupleItemSchema1;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema2 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema2 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[2] = tupleItemSchema2;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema3 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema3 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[3] = tupleItemSchema3;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema4 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema4 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[4] = tupleItemSchema4;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema5 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema5 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[5] = tupleItemSchema5;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema6 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema6 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[6] = tupleItemSchema6;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema7 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema7 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[7] = tupleItemSchema7;
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicTuple(typeof(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>>), tupleItemsSchema0);
            this._serializer0 = context.GetSerializer<System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor>(this.PackValueOfTuple8AllPolymorphic);
            this._packOperationList = packOperationList;
            System.Action<MsgPack.Unpacker, UnpackingContext, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfTuple8AllPolymorphic);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>>(1);
            unpackOperationTable["Tuple8AllPolymorphic"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfTuple8AllPolymorphic);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Tuple8AllPolymorphic"};
        }
        
        private void PackValueOfTuple8AllPolymorphic(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Tuple8AllPolymorphic);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor objectTree) {
            MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
        }
        
        private MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor(unpackingContext.Tuple8AllPolymorphic);
            return result;
        }
        
        private void UnpackValueOfTuple8AllPolymorphic(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem) {
            System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>> nullable = default(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "Tuple8AllPolymorphic", unpacker);
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
                unpackingContext.Tuple8AllPolymorphic = nullable;
            }
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>> ctorArg0 = default(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>>);
            ctorArg0 = null;
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor>(this.CreateInstanceFromContext), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple8AllPolymorphicGetOnlyPropertyAndConstructor>(this.CreateInstanceFromContext), this._unpackOperationTable);
            }
        }
        
        public class UnpackingContext {
            
            public System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>> Tuple8AllPolymorphic;
            
            public UnpackingContext(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, System.Tuple<MsgPack.Serialization.FileSystemEntry>> Tuple8AllPolymorphic) {
                this.Tuple8AllPolymorphic = Tuple8AllPolymorphic;
            }
        }
    }
}
