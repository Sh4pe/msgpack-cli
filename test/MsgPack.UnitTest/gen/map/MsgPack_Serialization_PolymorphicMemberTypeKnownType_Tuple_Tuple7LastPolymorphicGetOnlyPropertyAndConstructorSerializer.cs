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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Tuple<string, string, string, string, string, string, MsgPack.Serialization.FileSystemEntry>> _serializer0;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor>> _packOperationTable;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema[] tupleItemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema[]);
            tupleItemsSchema0 = new MsgPack.Serialization.PolymorphismSchema[7];
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema0 = null;
            tupleItemsSchema0[0] = tupleItemSchema0;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema1 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema1 = null;
            tupleItemsSchema0[1] = tupleItemSchema1;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema2 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema2 = null;
            tupleItemsSchema0[2] = tupleItemSchema2;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema3 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema3 = null;
            tupleItemsSchema0[3] = tupleItemSchema3;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema4 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema4 = null;
            tupleItemsSchema0[4] = tupleItemSchema4;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema5 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema5 = null;
            tupleItemsSchema0[5] = tupleItemSchema5;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema6 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> tupleItemSchema6TypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            tupleItemSchema6TypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            tupleItemSchema6TypeMap0.Add("0", typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema6TypeMap0.Add("1", typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema6 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema6TypeMap0);
            tupleItemsSchema0[6] = tupleItemSchema6;
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicTuple(typeof(System.Tuple<string, string, string, string, string, string, MsgPack.Serialization.FileSystemEntry>), tupleItemsSchema0);
            this._serializer0 = context.GetSerializer<System.Tuple<string, string, string, string, string, string, MsgPack.Serialization.FileSystemEntry>>(schema0);
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor>>(1);
            packOperationTable["Tuple7LastPolymorphic"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor>(this.PackValueOfTuple7LastPolymorphic);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, UnpackingContext, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfTuple7LastPolymorphic);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int>>(1);
            unpackOperationTable["Tuple7LastPolymorphic"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int>(this.UnpackValueOfTuple7LastPolymorphic);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Tuple7LastPolymorphic"};
        }
        
        private void PackValueOfTuple7LastPolymorphic(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Tuple7LastPolymorphic);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor objectTree) {
            MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
        }
        
        private MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor(unpackingContext.Tuple7LastPolymorphic);
            return result;
        }
        
        private void UnpackValueOfTuple7LastPolymorphic(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem) {
            System.Tuple<string, string, string, string, string, string, MsgPack.Serialization.FileSystemEntry> nullable = default(System.Tuple<string, string, string, string, string, string, MsgPack.Serialization.FileSystemEntry>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "Tuple7LastPolymorphic", unpacker);
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
                unpackingContext.Tuple7LastPolymorphic = nullable;
            }
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            System.Tuple<string, string, string, string, string, string, MsgPack.Serialization.FileSystemEntry> ctorArg0 = default(System.Tuple<string, string, string, string, string, string, MsgPack.Serialization.FileSystemEntry>);
            ctorArg0 = null;
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor>(this.CreateInstanceFromContext), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7LastPolymorphicGetOnlyPropertyAndConstructor>(this.CreateInstanceFromContext), this._unpackOperationTable);
            }
        }
        
        public class UnpackingContext {
            
            public System.Tuple<string, string, string, string, string, string, MsgPack.Serialization.FileSystemEntry> Tuple7LastPolymorphic;
            
            public UnpackingContext(System.Tuple<string, string, string, string, string, string, MsgPack.Serialization.FileSystemEntry> Tuple7LastPolymorphic) {
                this.Tuple7LastPolymorphic = Tuple7LastPolymorphic;
            }
        }
    }
}
