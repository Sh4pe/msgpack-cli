﻿#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2017 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;
using System.IO;
#if !MSTEST
using NUnit.Framework;
#else
using TestFixtureAttribute = Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestClassAttribute;
using TestAttribute = Microsoft.VisualStudio.TestPlatform.UnitTestFramework.TestMethodAttribute;
using TimeoutAttribute = NUnit.Framework.TimeoutAttribute;
using Assert = NUnit.Framework.Assert;
using Is = NUnit.Framework.Is;
#endif

namespace MsgPack
{
	[TestFixture]
	[Timeout( 1000 )]
	public class UnpackerFactoryTest
	{
		[Test]
		public void TestCreate_Stream_StreamIsNull()
		{
			Assert.Throws<ArgumentNullException>( () => { using ( Unpacker.Create( default( Stream ) ) ) { } } );
		}

		[Test]
		public void TestCreate_Stream_Boolean_StreamIsNull()
		{
			Assert.Throws<ArgumentNullException>( () => { using ( Unpacker.Create( default( Stream ), true ) ) { } } );
		}

		[Test]
		public void TestCreate_OwnsStreamisFalse_NotDisposeStream()
		{
			using ( var stream = new MemoryStream() )
			{
				using ( var unpacker = Unpacker.Create( stream, false ) )
				{
					Assert.That( unpacker, Is.InstanceOf<DefaultStreamUnpacker>() );
					Assert.That( ( unpacker as DefaultStreamUnpacker ).Core, Is.InstanceOf<MessagePackUnpacker<StreamUnpackerReader>>() );
					var core = ( unpacker as DefaultStreamUnpacker ).Core as MessagePackUnpacker<StreamUnpackerReader>;
					Assert.That( core.Reader.DebugOwnsStream, Is.False );
				}

				// Should not throw ObjectDisposedException.
				stream.WriteByte( 1 );
			}
		}

		[Test]
		public void TestCreate_Stream_PackerUnpackerStreamOptions_StreamIsNull()
		{
			Assert.Throws<ArgumentNullException>( () => { using ( Unpacker.Create( default( Stream ), default( PackerUnpackerStreamOptions ) ) ) { } } );
		}

		[Test]
		public void TestCreate_Stream_PackerUnpackerStreamOptions_UnpackerOptions_StreamIsNull()
		{
			Assert.Throws<ArgumentNullException>( () => { using ( Unpacker.Create( default( Stream ), default( PackerUnpackerStreamOptions ), default( UnpackerOptions ) ) ) { } } );
		}

		[Test]
		public void TestCreate_StreamOptionIsNull()
		{
			PackerUnpackerStreamOptions.AlwaysWrap = true;
			try
			{
				using ( var stream = new MemoryStream() )
				using ( var unpacker = Unpacker.Create( stream, default( PackerUnpackerStreamOptions ), default( UnpackerOptions ) ) )
				{
					Assert.That( unpacker, Is.InstanceOf<DefaultStreamUnpacker>() );
					Assert.That( ( unpacker as DefaultStreamUnpacker ).Core, Is.InstanceOf<MessagePackUnpacker<StreamUnpackerReader>>() );
					var core = ( unpacker as DefaultStreamUnpacker ).Core as MessagePackUnpacker<StreamUnpackerReader>;
					Assert.That( core.Reader.DebugOwnsStream, Is.False );
					Assert.That( core.Reader.DebugSource, Is.SameAs( stream ) );
				}
			}
			finally
			{
				PackerUnpackerStreamOptions.AlwaysWrap = false;
			}
		}

		[Test]
		public void TestCreate_WithBuffering()
		{
			PackerUnpackerStreamOptions.AlwaysWrap = true;
			try
			{
				using ( var stream = new MemoryStream() )
				using ( var unpacker = Unpacker.Create( stream, new PackerUnpackerStreamOptions { OwnsStream = false, WithBuffering = true, BufferSize = 123 }, default( UnpackerOptions ) ) )
				{
					Assert.That( unpacker, Is.InstanceOf<DefaultStreamUnpacker>() );
					Assert.That( ( unpacker as DefaultStreamUnpacker ).Core, Is.InstanceOf<MessagePackUnpacker<StreamUnpackerReader>>() );
					var core = ( unpacker as DefaultStreamUnpacker ).Core as MessagePackUnpacker<StreamUnpackerReader>;
					Assert.That( core.Reader.DebugOwnsStream, Is.False );
					Assert.That( core.Reader.DebugSource, Is.Not.SameAs( stream ) );
					Assert.That( core.Reader.DebugSource, Is.InstanceOf<BufferedStream>() );
				}
			}
			finally
			{
				PackerUnpackerStreamOptions.AlwaysWrap = false;
			}
		}

		[Test]
		public void TestCreate_Stream_DefaultValidationLevel()
		{
			using ( var stream = new MemoryStream() )
			using ( var unpacker = Unpacker.Create( stream, PackerUnpackerStreamOptions.None, default( UnpackerOptions ) ) )
			{
				Assert.That( unpacker, Is.InstanceOf<CollectionValidatingStreamUnpacker>() );
			}
		}

		[Test]
		public void TestCreate_Stream_CollectionValidationLevel()
		{
			using ( var stream = new MemoryStream() )
			using ( var unpacker = Unpacker.Create( stream, PackerUnpackerStreamOptions.None, new UnpackerOptions { ValidationLevel = UnpackerValidationLevel.Collection } ) )
			{
				Assert.That( unpacker, Is.InstanceOf<CollectionValidatingStreamUnpacker>() );
			}
		}

		[Test]
		public void TestCreate_Stream_NoneValidationLevel()
		{
			using ( var stream = new MemoryStream() )
			using ( var unpacker = Unpacker.Create( stream, PackerUnpackerStreamOptions.None, new UnpackerOptions { ValidationLevel = UnpackerValidationLevel.None } ) )
			{
				Assert.That( unpacker, Is.InstanceOf<FastStreamUnpacker>() );
			}
		}

		private static void AssertSource( ByteArrayUnpacker unpacker, byte[] array, int expectedOffset, int expectedCount )
		{
			Assert.That( unpacker, Is.InstanceOf<DefaultByteArrayUnpacker>() );
			Assert.That( ( unpacker as DefaultByteArrayUnpacker ).Core, Is.InstanceOf<MessagePackUnpacker<ByteArrayUnpackerReader>>() );
			var core = ( unpacker as DefaultByteArrayUnpacker ).Core as MessagePackUnpacker<ByteArrayUnpackerReader>;
			Assert.That( core.Reader.DebugSource.Array, Is.SameAs( array ) );
			Assert.That( core.Reader.DebugSource.Offset, Is.EqualTo( expectedOffset ) );
			Assert.That( core.Reader.DebugSource.Count, Is.EqualTo( expectedCount ) );
		}

		[Test]
		public void TestCreate_ByteArray_EntireArray()
		{
			var array = Guid.NewGuid().ToByteArray();

			using ( var unpacker = Unpacker.Create( array ) )
			{
				AssertSource( unpacker, array, 0, array.Length );
			}
		}

		[Test]
		public void TestCreate_ByteArray_ArrayIsNull()
		{
			Assert.Throws<ArgumentNullException>( () => { using ( Unpacker.Create( default( byte[] ) ) ) { } } );
		}

		[Test]
		public void TestCreate_ByteArray_ArrayIsEmpty()
		{
			var array = new byte[ 0 ];

			using ( var unpacker = Unpacker.Create( array ) )
			{
				AssertSource( unpacker, array, 0, array.Length );
			}
		}

		[Test]
		public void TestCreate_ByteArray_Int32_Offset()
		{
			var array = Guid.NewGuid().ToByteArray();
			var offset = 1;

			using ( var unpacker = Unpacker.Create( array, offset ) )
			{
				AssertSource( unpacker, array, offset, array.Length - offset );
			}
		}

		[Test]
		public void TestCreate_ByteArray_Int32_Empty()
		{
			var array = new byte[ 0 ];

			using ( var unpacker = Unpacker.Create( array, 0 ) )
			{
				AssertSource( unpacker, array, 0, array.Length );
			}
		}

		[Test]
		public void TestCreate_ByteArray_Int32_ArrayIsNull()
		{
			Assert.Throws<ArgumentNullException>( () => { using ( Unpacker.Create( default( byte[] ), 0 ) ) { } } );
		}

		[Test]
		public void TestCreate_ByteArray_Int32_NegativeOffset()
		{
			Assert.Throws<ArgumentOutOfRangeException>( () => { using ( Unpacker.Create( new byte[ 0 ], -1 ) ) { } } );
		}

		[Test]
		public void TestCreate_ByteArray_Int32_TooLargeOffset()
		{
			Assert.Throws<ArgumentException>( () => { using ( Unpacker.Create( new byte[ 1 ], 2 ) ) { } } );
		}

		[Test]
		public void TestCreate_ByteArray_Int32_Int32_OffsetAndCount()
		{
			var array = Guid.NewGuid().ToByteArray();
			var offset = 1;
			var count = 2;

			using ( var unpacker = Unpacker.Create( array, offset, count ) )
			{
				AssertSource( unpacker, array, offset, count );
			}
		}

		[Test]
		public void TestCreate_ByteArray_Int32_Int32_Empty()
		{
			var array = new byte[ 0 ];

			using ( var unpacker = Unpacker.Create( array, 0, 0 ) )
			{
				AssertSource( unpacker, array, 0, 0 );
			}
		}

		[Test]
		public void TestCreate_ByteArray_Int32_Int32_Bound()
		{
			var array = new byte[ 2 ];

			using ( var unpacker = Unpacker.Create( array, 1, 1 ) )
			{
				AssertSource( unpacker, array, 1, 1 );
			}
		}

		[Test]
		public void TestCreate_ByteArray_Int32_Int32_ArrayIsNull()
		{
			Assert.Throws<ArgumentNullException>( () => { using ( Unpacker.Create( default( byte[] ), 0, 0 ) ) { } } );
		}

		[Test]
		public void TestCreate_ByteArray_Int32_Int32_NegativeOffset()
		{
			Assert.Throws<ArgumentOutOfRangeException>( () => { using ( Unpacker.Create( new byte[ 0 ], -1, 0 ) ) { } } );
		}

		[Test]
		public void TestCreate_ByteArray_Int32_Int32_TooLargeOffset()
		{
			Assert.Throws<ArgumentException>( () => { using ( Unpacker.Create( new byte[ 1 ], 2, 0 ) ) { } } );
		}

		[Test]
		public void TestCreate_ByteArray_Int32_Int32_NegativeCount()
		{
			Assert.Throws<ArgumentOutOfRangeException>( () => { using ( Unpacker.Create( new byte[ 0 ], 0, -1 ) ) { } } );
		}

		[Test]
		public void TestCreate_ByteArray_Int32_Int32_TooLargeCount()
		{
			Assert.Throws<ArgumentException>( () => { using ( Unpacker.Create( new byte[ 1 ], 0, 2 ) ) { } } );
		}

		[Test]
		public void TestCreate_ByteArray_Int32_Int32_TooLargeCombination()
		{
			Assert.Throws<ArgumentException>( () => { using ( Unpacker.Create( new byte[ 1 ], 1, 1 ) ) { } } );
		}

		[Test]
		public void TestCreate_ByteArraySegment_EntireArray()
		{
			var array = new ArraySegment<byte>( Guid.NewGuid().ToByteArray() );

			using ( var unpacker = Unpacker.Create( array ) )
			{
				AssertSource( unpacker, array.Array, array.Offset, array.Count );
			}
		}

		[Test]
		public void TestCreate_ByteArraySegment_ArrayIsNull()
		{
			Assert.Throws<ArgumentException>( () => { using ( Unpacker.Create( default( ArraySegment<byte> ) ) ) { } } );
		}

		[Test]
		public void TestCreate_ByteArraySegment_ArrayIsEmpty()
		{
			var array = new ArraySegment<byte>( new byte[ 0 ] );

			using ( var unpacker = Unpacker.Create( array ) )
			{
				AssertSource( unpacker, array.Array, array.Offset, array.Count );
			}
		}

		[Test]
		public void TestCreate_ByteArraySegment_DefaultValidationLevel()
		{
			var array = new ArraySegment<byte>( Guid.NewGuid().ToByteArray() );

			using ( var unpacker = Unpacker.Create( array, default( UnpackerOptions ) ) )
			{
				Assert.That( unpacker, Is.InstanceOf<CollectionValidatingByteArrayUnpacker>() );
			}
		}

		[Test]
		public void TestCreate_ByteArraySegment_CollectionValidationLevel()
		{
			var array = new ArraySegment<byte>( Guid.NewGuid().ToByteArray() );

			using ( var unpacker = Unpacker.Create( array, new UnpackerOptions { ValidationLevel = UnpackerValidationLevel.Collection } ) )
			{
				Assert.That( unpacker, Is.InstanceOf<CollectionValidatingByteArrayUnpacker>() );
			}
		}

		[Test]
		public void TestCreate_ByteArraySegment_NoneValidationLevel()
		{
			var array = new ArraySegment<byte>( Guid.NewGuid().ToByteArray() );

			using ( var unpacker = Unpacker.Create( array, new UnpackerOptions { ValidationLevel = UnpackerValidationLevel.None } ) )
			{
				Assert.That( unpacker, Is.InstanceOf<FastByteArrayUnpacker>() );
			}
		}
	}
}
