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
    public class MsgPack_Serialization_ComplexTypeWithTwoMemberSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeWithTwoMember> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>> _packOperationList;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_ComplexTypeWithTwoMemberSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>[2];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>(this.PackValueOfValue1);
            packOperationList[1] = new System.Action<MsgPack.Packer, MsgPack.Serialization.ComplexTypeWithTwoMember>(this.PackValueOfValue2);
            this._packOperationList = packOperationList;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int>[2];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int>(this.UnpackValueOfValue1);
            unpackOperationList[1] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int>(this.UnpackValueOfValue2);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int>>(2);
            unpackOperationTable["Value1"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int>(this.UnpackValueOfValue1);
            unpackOperationTable["Value2"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember, int>(this.UnpackValueOfValue2);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Value1",
                    "Value2"};
        }
        
        private void PackValueOfValue1(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithTwoMember objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value1);
        }
        
        private void PackValueOfValue2(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithTwoMember objectTree) {
            this._serializer0.PackTo(packer, objectTree.Value2);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeWithTwoMember objectTree) {
            MsgPack.Serialization.PackHelpers.PackToArray(packer, objectTree, this._packOperationList);
        }
        
        private void UnpackValueOfValue1(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember unpackingContext, int indexOfItem) {
            string nullable = default(string);
            nullable = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithTwoMember), "Value1");
            if (((nullable == null) 
                        == false)) {
                unpackingContext.Value1 = nullable;
            }
        }
        
        private void UnpackValueOfValue2(MsgPack.Unpacker unpacker, MsgPack.Serialization.ComplexTypeWithTwoMember unpackingContext, int indexOfItem) {
            string nullable0 = default(string);
            nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeWithTwoMember), "Value2");
            if (((nullable0 == null) 
                        == false)) {
                unpackingContext.Value2 = nullable0;
            }
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeWithTwoMember UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeWithTwoMember result = default(MsgPack.Serialization.ComplexTypeWithTwoMember);
            result = new MsgPack.Serialization.ComplexTypeWithTwoMember();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithTwoMember>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.ComplexTypeWithTwoMember>(), this._unpackOperationTable);
            }
        }
    }
}
