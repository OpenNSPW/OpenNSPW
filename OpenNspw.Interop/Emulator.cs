using System;
using System.IO;
using Aigamo.Enzan;
using OpenNspw.Interop.Subroutines;

namespace OpenNspw.Interop
{
	internal sealed class Memory8
	{
		private readonly Memory<byte> _data;
		private readonly Register32 _offset;

		public Memory8(Memory<byte> data, Register32 offset)
		{
			_data = data;
			_offset = offset;
		}

		private Memory<byte> Slice(Register32 address) => _data[(int)(address - _offset).Value..];

		public Register8 this[Register32 address]
		{
			get => new Register8(Slice(address).Span[0]);
			set => _data.Span[Slice(address).Span[0]] = value.Value;
		}
	}

	internal sealed class Memory16
	{
		private readonly Memory<byte> _data;
		private readonly Register32 _offset;

		public Memory16(Memory<byte> data, Register32 offset)
		{
			_data = data;
			_offset = offset;
		}

		private Memory<byte> Slice(Register32 address) => _data[(int)(address - _offset).Value..];

		public Register16 this[Register32 address]
		{
			get => new Register16(BitConverter.ToUInt16(Slice(address).Span));
			set => BitConverter.GetBytes(value.Value).CopyTo(Slice(address));
		}
	}

	internal sealed class Memory32
	{
		private readonly Memory<byte> _data;
		private readonly Register32 _offset;

		public Memory32(Memory<byte> data, Register32 offset)
		{
			_data = data;
			_offset = offset;
		}

		private Memory<byte> Slice(Register32 address) => _data[(int)(address - _offset).Value..];

		public Register32 this[Register32 address]
		{
			get => new Register32(BitConverter.ToUInt32(Slice(address).Span));
			set => BitConverter.GetBytes(value.Value).CopyTo(Slice(address));
		}
	}

	internal sealed class Memory64
	{
		private readonly Memory<byte> _data;
		private readonly Register32 _offset;

		public Memory64(Memory<byte> data, Register32 offset)
		{
			_data = data;
			_offset = offset;
		}

		private Memory<byte> Slice(Register32 address) => _data[(int)(address - _offset).Value..];

		public Register64 this[Register32 address]
		{
			get => new Register64(BitConverter.ToUInt64(Slice(address).Span));
			set => BitConverter.GetBytes(value.Value).CopyTo(Slice(address));
		}
	}

	public sealed class Emulator
	{
		private static readonly Register32 Offset = new Register32(0x400000);

		private readonly byte[] _memory = new byte[DATA.Length];

		internal Cpu Cpu { get; }
		internal Memory8 Memory8 { get; }
		internal Memory16 Memory16 { get; }
		internal Memory32 Memory32 { get; }
		internal Memory64 Memory64 { get; }
		public DATA data { get; }

		public Emulator(Stream stream)
		{
			using var memoryStream = new MemoryStream(_memory);
			stream.CopyTo(memoryStream);

			Cpu = new Cpu(_memory, Offset, Call)
			{
				Esp = new Register32(0x401000)
			};
			Memory8 = new Memory8(_memory, Offset);
			Memory16 = new Memory16(_memory, Offset);
			Memory32 = new Memory32(_memory, Offset);
			Memory64 = new Memory64(_memory, Offset);
			data = new DATA(_memory);
		}

		public void Call(Register32 value)
		{
			// HACK
			Cpu.Push(new Register32(uint.MaxValue));

			switch (value.Value)
			{
				case 0x403A70: Sub403A70.Call(this); break;
				case 0x403AE0: Sub403AE0.Call(this); break;
				case 0x404D80: Sub404D80.Call(this); break;
				case 0x404E30: Sub404E30.Call(this); break;
				case 0x414DD0: Sub414DD0.Call(this); break;
				case 0x416F00: Sub416F00.Call(this); break;
				case 0x416F40: Sub416F40.Call(this); break;
				case 0x417930: Sub417930.Call(this); break;
				case 0x417BE0: Sub417BE0.Call(this); break;
				case 0x417C10: Sub417C10.Call(this); break;
				case 0x41C3C0: Sub41C3C0.Call(this); break;
				case 0x41E150: Sub41E150.Call(this); break;
				case 0x41EE20: Sub41EE20.Call(this); break;
				case 0x41F060: Sub41F060.Call(this); break;
				case 0x41F230: Sub41F230.Call(this); break;
				case 0x41F300: Sub41F300.Call(this); break;
				case 0x41F3C0: Sub41F3C0.Call(this); break;
				case 0x41F490: Sub41F490.Call(this); break;
				case 0x41F570: Sub41F570.Call(this); break;
				case 0x41F830: Sub41F830.Call(this); break;
				case 0x41FD60: Sub41FD60.Call(this); break;
				case 0x420260: Sub420260.Call(this); break;
				case 0x4207C0: Sub4207C0.Call(this); break;
				case 0x420DE0: Sub420DE0.Call(this); break;
				case 0x421310: Sub421310.Call(this); break;
				case 0x421830: Sub421830.Call(this); break;
				case 0x421A80: Sub421A80.Call(this); break;
				case 0x421DB0: Sub421DB0.Call(this); break;
				case 0x422820: Sub422820.Call(this); break;
				case 0x422D10: Sub422D10.Call(this); break;
				case 0x422F40: Sub422F40.Call(this); break;
				case 0x423940: Sub423940.Call(this); break;
				case 0x4241B0: Sub4241B0.Call(this); break;
				case 0x424760: Sub424760.Call(this); break;
				case 0x424DD0: Sub424DD0.Call(this); break;
				case 0x425510: Sub425510.Call(this); break;
				case 0x425D60: Sub425D60.Call(this); break;
				case 0x426270: Sub426270.Call(this); break;
				case 0x426DE0: Sub426DE0.Call(this); break;
				case 0x427030: Sub427030.Call(this); break;
				case 0x4278B0: Sub4278B0.Call(this); break;
				case 0x428020: Sub428020.Call(this); break;
				case 0x4287E0: Sub4287E0.Call(this); break;
				case 0x428C60: Sub428C60.Call(this); break;
				case 0x429310: Sub429310.Call(this); break;
				case 0x42A2E0: Sub42A2E0.Call(this); break;
				case 0x42A6C0: Sub42A6C0.Call(this); break;
				case 0x42AA60: Sub42AA60.Call(this); break;
				case 0x42AC90: Sub42AC90.Call(this); break;
				case 0x42AF40: Sub42AF40.Call(this); break;
				case 0x42B3A0: Sub42B3A0.Call(this); break;
				case 0x42B8A0: Sub42B8A0.Call(this); break;
				case 0x42C480: Sub42C480.Call(this); break;
				case 0x42CED0: Sub42CED0.Call(this); break;
				case 0x42D3C0: Sub42D3C0.Call(this); break;
				case 0x42DA80: Sub42DA80.Call(this); break;
				case 0x42ED30: Sub42ED30.Call(this); break;
				case 0x436056: Sub436056.Call(this); break;

				// load_it2
				case 0x432A30:
					break;

				// __ftol
				case 0x4360C4:
					// REVIEW
					Cpu.Push(Cpu.Ebp);
					Cpu.Ebp = Cpu.Esp;
					Cpu.Esp += new Register32(0xFFFFFFF4);
					var tmp = new Register64((ulong)(long)Cpu.Fpu.Stack.Pop().ToDouble());
					Cpu.Eax = tmp.Low;
					Cpu.Edx = tmp.High;
					// leave
					Cpu.Esp = Cpu.Ebp;
					Cpu.Ebp = Cpu.Pop32();
					break;

				default: throw new NotImplementedException($"{nameof(Call)} {value:X}");
			}

			// HACK
			Cpu.Pop32();
		}
	}
}
