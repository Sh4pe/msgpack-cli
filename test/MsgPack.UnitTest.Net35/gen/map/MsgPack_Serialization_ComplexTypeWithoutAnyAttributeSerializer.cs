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
    public class MsgPack_Serialization_ComplexTypeWithoutAnyAttributeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute> {
        
        private MsgPack.Serialization.MessagePackSerializer<byte[]> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Uri> _serializer2;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer3;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>> _packOperationTable;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.DateTime>> _serializer4;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_ComplexTypeWithoutAnyAttributeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<byte[]>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<System.Collections.Generic.Dictionary<System.DateTime, string>>(schema1);
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer2 = context.GetSerializer<System.Uri>(schema2);
            this._serializer3 = context.GetSerializer<System.DateTime>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            this._serializer4 = context.GetSerializer<System.Nullable<System.DateTime>>(MsgPack.Serialization.DateTimeMessagePackSerializerHelpers.DetermineDateTimeConversionMethod(context, MsgPack.Serialization.DateTimeMemberConversionMethod.Default));
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>>(4);
            packOperationTable["Data"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfData);
            packOperationTable["History"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfHistory);
            packOperationTable["Source"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfSource);
            packOperationTable["TimeStamp"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(this.PackValueOfTimeStamp);
            this._packOperationTable = packOperationTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>[4];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>(this.UnpackValueOfData);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>(this.UnpackValueOfHistory);
            unpackOperationList[2] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>(this.UnpackValueOfSource);
            unpackOperationList[3] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>(this.UnpackValueOfTimeStamp);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>>(4);
            unpackOperationTable["Data"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>(this.UnpackValueOfData);
            unpackOperationTable["History"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>(this.UnpackValueOfHistory);
            unpackOperationTable["Source"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>(this.UnpackValueOfSource);
            unpackOperationTable["TimeStamp"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute, int>(this.UnpackValueOfTimeStamp);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Data",
                    "History",
                    "Source",
                    "TimeStamp"};
        }
        
        private void PackValueOfData(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            this._serializer0.PackTo(packer, objectTree.Data);
        }
        
        private void PackValueOfHistory(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            this._serializer1.PackTo(packer, objectTree.History);
        }
        
        private void PackValueOfSource(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            this._serializer2.PackTo(packer, objectTree.Source);
        }
        
        private void PackValueOfTimeStamp(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            this._serializer3.PackTo(packer, objectTree.TimeStamp);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute objectTree) {
            MsgPack.Serialization.PackHelpers.PackToMap(packer, objectTree, this._packOperationTable);
        }
        
        private void UnpackValueOfData(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem) {
            byte[] nullable = default(byte[]);
            nullable = MsgPack.Serialization.UnpackHelpers.UnpackBinaryValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute), "Data");
            if (((nullable == null) 
                        == false)) {
                unpackingContext.Data = nullable;
            }
        }
        
        private void UnpackValueOfHistory(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem) {
            System.Collections.Generic.Dictionary<System.DateTime, string> nullable0 = default(System.Collections.Generic.Dictionary<System.DateTime, string>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "History", unpacker);
            }
            if (((unpacker.IsArrayHeader == false) 
                        && (unpacker.IsMapHeader == false))) {
                nullable0 = this._serializer1.UnpackFrom(unpacker);
            }
            else {
                MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                disposable = unpacker.ReadSubtree();
                try {
                    nullable0 = this._serializer1.UnpackFrom(disposable);
                }
                finally {
                    if (((disposable == null) 
                                == false)) {
                        disposable.Dispose();
                    }
                }
            }
            if (((nullable0 == null) 
                        == false)) {
                System.Collections.Generic.Dictionary<System.DateTime, string>.Enumerator enumerator = nullable0.GetEnumerator();
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
        
        private void UnpackValueOfSource(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem) {
            System.Uri nullable1 = default(System.Uri);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "Source", unpacker);
            }
            if (((unpacker.IsArrayHeader == false) 
                        && (unpacker.IsMapHeader == false))) {
                nullable1 = this._serializer2.UnpackFrom(unpacker);
            }
            else {
                MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                disposable0 = unpacker.ReadSubtree();
                try {
                    nullable1 = this._serializer2.UnpackFrom(disposable0);
                }
                finally {
                    if (((disposable0 == null) 
                                == false)) {
                        disposable0.Dispose();
                    }
                }
            }
            if (((nullable1 == null) 
                        == false)) {
                unpackingContext.Source = nullable1;
            }
        }
        
        private void UnpackValueOfTimeStamp(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithoutAnyAttribute unpackingContext, int indexOfItem) {
            System.Nullable<System.DateTime> nullable2 = default(System.Nullable<System.DateTime>);
            if ((unpacker.Read() == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowMissingItem(indexOfItem, "TimeStamp", unpacker);
            }
            if (((unpacker.IsArrayHeader == false) 
                        && (unpacker.IsMapHeader == false))) {
                nullable2 = this._serializer4.UnpackFrom(unpacker);
            }
            else {
                MsgPack.Unpacker disposable1 = default(MsgPack.Unpacker);
                disposable1 = unpacker.ReadSubtree();
                try {
                    nullable2 = this._serializer4.UnpackFrom(disposable1);
                }
                finally {
                    if (((disposable1 == null) 
                                == false)) {
                        disposable1.Dispose();
                    }
                }
            }
            if (nullable2.HasValue) {
                unpackingContext.TimeStamp = nullable2.Value;
            }
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeWithoutAnyAttribute UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeWithoutAnyAttribute result = default(MsgPack.Serialization.ComplexTypeWithoutAnyAttribute);
            result = new MsgPack.Serialization.ComplexTypeWithoutAnyAttribute();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithoutAnyAttribute>(), this._unpackOperationTable);
            }
        }
    }
}
