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
    public class MsgPack_Serialization_AddOnlyCollection_1_System_DateTime_Serializer : MsgPack.Serialization.CollectionSerializers.EnumerableMessagePackSerializer<MsgPack.Serialization.AddOnlyCollection<System.DateTime>, System.DateTime> {
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.AddOnlyCollection<System.DateTime>, int> _unpackTo;
        
        public MsgPack_Serialization_AddOnlyCollection_1_System_DateTime_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, MsgPack_Serialization_AddOnlyCollection_1_System_DateTime_Serializer.RestoreSchema()) {
            this._unpackTo = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.AddOnlyCollection<System.DateTime>, int>(this.UnpackToCore);
        }
        
        protected override void AddItem(MsgPack.Serialization.AddOnlyCollection<System.DateTime> collection, System.DateTime item) {
            collection.Add(item);
        }
        
        protected override MsgPack.Serialization.AddOnlyCollection<System.DateTime> CreateInstance(int initialCapacity) {
            MsgPack.Serialization.AddOnlyCollection<System.DateTime> collection = default(MsgPack.Serialization.AddOnlyCollection<System.DateTime>);
            collection = new MsgPack.Serialization.AddOnlyCollection<System.DateTime>();
            return collection;
        }
        
        protected internal override MsgPack.Serialization.AddOnlyCollection<System.DateTime> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowIsNotArrayHeader(unpacker);
            }
            int itemsCount = default(int);
            itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            return MsgPack.Serialization.UnpackHelpers.UnpackCollection<MsgPack.Serialization.AddOnlyCollection<System.DateTime>>(unpacker, itemsCount, this.CreateInstance(itemsCount), this._unpackTo, null);
        }
        
        private static MsgPack.Serialization.PolymorphismSchema RestoreSchema() {
            MsgPack.Serialization.PolymorphismSchema schema = default(MsgPack.Serialization.PolymorphismSchema);
            schema = null;
            return schema;
        }
    }
}
