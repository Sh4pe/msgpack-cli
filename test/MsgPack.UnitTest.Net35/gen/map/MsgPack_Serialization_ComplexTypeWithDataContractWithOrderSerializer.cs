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
    public class MsgPack_Serialization_ComplexTypeWithDataContractWithOrderSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Uri> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<byte[]> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer2;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>> _serializer3;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>> _packOperationTable;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.DateTime>> _serializer4;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_ComplexTypeWithDataContractWithOrderSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Uri>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<byte[]>(schema1);
            this._serializer2 = context.GetSerializer<System.DateTime>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer3 = context.GetSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>>(schema2);
            this._serializer4 = context.GetSerializer<System.Nullable<System.DateTime>>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>>(4);
            packOperationTable["Source"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfSource);
            packOperationTable["Data"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfData);
            packOperationTable["TimeStamp"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfTimeStamp);
            packOperationTable["History"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(this.PackValueOfHistory);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>[4];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>(this.UnpackValueOfSource);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>(this.UnpackValueOfData);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>(this.UnpackValueOfTimeStamp);
            unpackOperationList[3] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>(this.UnpackValueOfHistory);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>>(4);
            unpackOperationTable["Source"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>(this.UnpackValueOfSource);
            unpackOperationTable["Data"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>(this.UnpackValueOfData);
            unpackOperationTable["TimeStamp"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>(this.UnpackValueOfTimeStamp);
            unpackOperationTable["History"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder, int>(this.UnpackValueOfHistory);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Source",
                    "Data",
                    "TimeStamp",
                    "History"};
        }
        
        private void PackValueOfSource(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree) {
            this._serializer0.PackTo(packer, objectTree.Source);
        }
        
        private void PackValueOfData(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree) {
            this._serializer1.PackTo(packer, objectTree.Data);
        }
        
        private void PackValueOfTimeStamp(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree) {
            this._serializer2.PackTo(packer, objectTree.TimeStamp);
        }
        
        private void PackValueOfHistory(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree) {
            this._serializer3.PackTo(packer, objectTree.History);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder objectTree) {
            MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
        }
        
        private void UnpackValueOfSource(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, int indexOfItem) {
            System.Uri nullable = default(System.Uri);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "Source", unpacker);
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
                unpackingContext.Source = nullable;
            }
        }
        
        private void UnpackValueOfData(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, int indexOfItem) {
            byte[] nullable0 = default(byte[]);
            nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithDataContractWithOrder), "Data");
            if (((nullable0 == null) 
                        == false)) {
                unpackingContext.Data = nullable0;
            }
        }
        
        private void UnpackValueOfTimeStamp(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, int indexOfItem) {
            System.Nullable<System.DateTime> nullable1 = default(System.Nullable<System.DateTime>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "TimeStamp", unpacker);
            }
            if (((unpacker.IsArrayHeader == false) 
                        && (unpacker.IsMapHeader == false))) {
                nullable1 = this._serializer4.UnpackFrom(unpacker);
            }
            else {
                MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                disposable0 = unpacker.ReadSubtree();
                try {
                    nullable1 = this._serializer4.UnpackFrom(disposable0);
                }
                finally {
                    if (((disposable0 == null) 
                                == false)) {
                        disposable0.Dispose();
                    }
                }
            }
            if (nullable1.HasValue) {
                unpackingContext.TimeStamp = nullable1.Value;
            }
        }
        
        private void UnpackValueOfHistory(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithDataContractWithOrder unpackingContext, int indexOfItem) {
            System.Collections.Generic.Dictionary<System.DateTime, string> nullable2 = default(System.Collections.Generic.Dictionary<System.DateTime, string>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "History", unpacker);
            }
            if (((unpacker.IsArrayHeader == false) 
                        && (unpacker.IsMapHeader == false))) {
                nullable2 = this._serializer3.UnpackFrom(unpacker);
            }
            else {
                MsgPack.Unpacker disposable1 = default(MsgPack.Unpacker);
                disposable1 = unpacker.ReadSubtree();
                try {
                    nullable2 = this._serializer3.UnpackFrom(disposable1);
                }
                finally {
                    if (((disposable1 == null) 
                                == false)) {
                        disposable1.Dispose();
                    }
                }
            }
            if (((nullable2 == null) 
                        == false)) {
                System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator = nullable2.GetEnumerator();
                System.Collections.Generic.KeyValuePair<System.DateTime, string> current;
                try {
                    for (
                    ; enumerator.MoveNext(); 
                    ) {
                        current = enumerator.Current;
                        unpackingContext.History.Add(current.Key, current.Value);
                    }
                }
                finally {
                    enumerator.Dispose();
                }
            }
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeWithDataContractWithOrder UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeWithDataContractWithOrder result = default(MsgPack.Serialization.ComplexTypeWithDataContractWithOrder);
            result = new MsgPack.Serialization.ComplexTypeWithDataContractWithOrder();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithDataContractWithOrder>(), this._unpackOperationTable);
            }
        }
    }
}
