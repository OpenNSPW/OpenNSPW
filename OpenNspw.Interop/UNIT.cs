using System;

namespace OpenNspw.Interop
{
	public sealed class UNIT
	{
		public const int Length = 0x598;

		private readonly Memory<byte> _data;

		public UNIT(Memory<byte> data)
		{
			if (data.Length != Length)
				throw new ArgumentException(message: null, paramName: nameof(data));

			_data = data;

			info = new(_data.Slice(0x24, _INFO.Length));

			pp_x = new(_data.Slice(0xc0, _PP.Length));
			pp_y = new(_data.Slice(0x2c0, _PP.Length));

			em_flg = new(_data.Slice(0x4c0, _EM_FLG.Length));

			hp = new(_data.Slice(0x4f8, _HP.Length));
			arm = new(_data.Slice(0x518, _ARM.Length));
			gas = new(_data.Slice(0x538, _GAS.Length));

			rnd_250 = new(_data.Slice(0x560, _RND.Length));
			rnd_225 = new(_data.Slice(0x564, _RND.Length));
			rnd_200 = new(_data.Slice(0x568, _RND.Length));
			rnd_175 = new(_data.Slice(0x56c, _RND.Length));
			rnd_150 = new(_data.Slice(0x570, _RND.Length));
			rnd_125 = new(_data.Slice(0x574, _RND.Length));
			rnd_100 = new(_data.Slice(0x578, _RND.Length));
			rnd_80 = new(_data.Slice(0x57c, _RND.Length));
			rnd_65 = new(_data.Slice(0x580, _RND.Length));
			rnd_50 = new(_data.Slice(0x584, _RND.Length));
			rnd_40 = new(_data.Slice(0x588, _RND.Length));
			rnd_30 = new(_data.Slice(0x58c, _RND.Length));
			rnd_20 = new(_data.Slice(0x590, _RND.Length));
			rnd_10 = new(_data.Slice(0x594, _RND.Length));
		}

		public short used
		{
			get => BitConverter.ToInt16(_data[0x0..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x0..]);
		}

		public double x
		{
			get => BitConverter.ToDouble(_data[0x8..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x8..]);
		}

		public double y
		{
			get => BitConverter.ToDouble(_data[0x10..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x10..]);
		}

		public int ctgry
		{
			get => BitConverter.ToInt32(_data[0x18..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x18..]);
		}

		public int kind
		{
			get => BitConverter.ToInt32(_data[0x1c..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x1c..]);
		}

		public short type
		{
			get => BitConverter.ToInt16(_data[0x20..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x20..]);
		}

		public sealed class _INFO
		{
			public const int Length = sizeof(int) * 16;

			private readonly Memory<byte> _data;

			public _INFO(Memory<byte> data)
			{
				if (data.Length != Length)
					throw new ArgumentException(message: null, paramName: nameof(data));

				_data = data;
			}

			public int this[int index]
			{
				get => BitConverter.ToInt32(_data[(index * sizeof(int))..].Span);
				set => BitConverter.GetBytes(value).CopyTo(_data[(index * sizeof(int))..]);
			}
		}

		public _INFO info { get; }

		public int os_indx_y
		{
			get => BitConverter.ToInt32(_data[0x64..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x64..]);
		}

		public int os_indx_x
		{
			get => BitConverter.ToInt32(_data[0x68..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x68..]);
		}

		public double drctn
		{
			get => BitConverter.ToDouble(_data[0x70..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x70..]);
		}

		public double drctn_add
		{
			get => BitConverter.ToDouble(_data[0x78..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x78..]);
		}

		public double a_drctn_add
		{
			get => BitConverter.ToDouble(_data[0x80..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x80..]);
		}

		public double spd
		{
			get => BitConverter.ToDouble(_data[0x88..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x88..]);
		}

		public double spd_add
		{
			get => BitConverter.ToDouble(_data[0x90..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x90..]);
		}

		public double a_spd_add
		{
			get => BitConverter.ToDouble(_data[0x98..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x98..]);
		}

		public double min_spd
		{
			get => BitConverter.ToDouble(_data[0xa0..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0xa0..]);
		}

		public double max_spd
		{
			get => BitConverter.ToDouble(_data[0xa8..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0xa8..]);
		}

		public bool stop
		{
			get => BitConverter.ToBoolean(_data[0xb0..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0xb0..]);
		}

		public int supply
		{
			get => BitConverter.ToInt32(_data[0xb4..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0xb4..]);
		}

		public bool mark
		{
			get => BitConverter.ToBoolean(_data[0xb8..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0xb8..]);
		}

		public sealed class _PP
		{
			public const int Length = sizeof(double) * 64;

			private readonly Memory<byte> _data;

			public _PP(Memory<byte> data)
			{
				if (data.Length != Length)
					throw new ArgumentException(message: null, paramName: nameof(data));

				_data = data;
			}

			public double this[int index]
			{
				get => BitConverter.ToDouble(_data[(index * sizeof(double))..].Span);
				set => BitConverter.GetBytes(value).CopyTo(_data[(index * sizeof(double))..]);
			}
		}

		public _PP pp_x { get; }

		public _PP pp_y { get; }

		public sealed class _EM_FLG
		{
			public const int Length = sizeof(int) * 2;

			private readonly Memory<byte> _data;

			public _EM_FLG(Memory<byte> data)
			{
				if (data.Length != Length)
					throw new ArgumentException(message: null, paramName: nameof(data));

				_data = data;
			}

			public int this[int index]
			{
				get => BitConverter.ToInt32(_data[(index * sizeof(int))..].Span);
				set => BitConverter.GetBytes(value).CopyTo(_data[(index * sizeof(int))..]);
			}
		}

		public _EM_FLG em_flg { get; }

		public double em_x
		{
			get => BitConverter.ToDouble(_data[0x4c8..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x4c8..]);
		}

		public double em_y
		{
			get => BitConverter.ToDouble(_data[0x4d0..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x4d0..]);
		}

		public double to_ldr_drctn
		{
			get => BitConverter.ToDouble(_data[0x4d8..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x4d8..]);
		}

		public double to_ldr_dstc
		{
			get => BitConverter.ToDouble(_data[0x4e0..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x4e0..]);
		}

		public short is_ltl_ldr
		{
			get => BitConverter.ToInt16(_data[0x4e8..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x4e8..]);
		}

		public short ltl_ldr
		{
			get => BitConverter.ToInt16(_data[0x4ea..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x4ea..]);
		}

		public short no
		{
			get => BitConverter.ToInt16(_data[0x4ec..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x4ec..]);
		}

		public short for_ltl_ldr
		{
			get => BitConverter.ToInt16(_data[0x4ee..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x4ee..]);
		}

		public double for_form_spd
		{
			get => BitConverter.ToDouble(_data[0x4f0..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x4f0..]);
		}

		public sealed class _HP
		{
			public const int Length = sizeof(int) * 8;

			private readonly Memory<byte> _data;

			public _HP(Memory<byte> data)
			{
				if (data.Length != Length)
					throw new ArgumentException(message: null, paramName: nameof(data));

				_data = data;
			}

			public int this[int index]
			{
				get => BitConverter.ToInt32(_data[(index * sizeof(int))..].Span);
				set => BitConverter.GetBytes(value).CopyTo(_data[(index * sizeof(int))..]);
			}
		}

		public _HP hp { get; }

		public sealed class _ARM
		{
			public const int Length = sizeof(int) * 8;

			private readonly Memory<byte> _data;

			public _ARM(Memory<byte> data)
			{
				if (data.Length != Length)
					throw new ArgumentException(message: null, paramName: nameof(data));

				_data = data;
			}

			public int this[int index]
			{
				get => BitConverter.ToInt32(_data[(index * sizeof(int))..].Span);
				set => BitConverter.GetBytes(value).CopyTo(_data[(index * sizeof(int))..]);
			}
		}

		public _ARM arm { get; }

		public sealed class _GAS
		{
			public const int Length = sizeof(int) * 8;

			private readonly Memory<byte> _data;

			public _GAS(Memory<byte> data)
			{
				if (data.Length != Length)
					throw new ArgumentException(message: null, paramName: nameof(data));

				_data = data;
			}

			public int this[int index]
			{
				get => BitConverter.ToInt32(_data[(index * sizeof(int))..].Span);
				set => BitConverter.GetBytes(value).CopyTo(_data[(index * sizeof(int))..]);
			}
		}

		public _GAS gas { get; }

		public bool found
		{
			get => BitConverter.ToBoolean(_data[0x558..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x558..]);
		}

		public int tech
		{
			get => BitConverter.ToInt32(_data[0x55c..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x55c..]);
		}

		public sealed class _RND
		{
			public const int Length = sizeof(short) * 2;

			private readonly Memory<byte> _data;

			public _RND(Memory<byte> data)
			{
				if (data.Length != Length)
					throw new ArgumentException(message: null, paramName: nameof(data));

				_data = data;
			}

			public short this[int index]
			{
				get => BitConverter.ToInt16(_data[(index * sizeof(short))..].Span);
				set => BitConverter.GetBytes(value).CopyTo(_data[(index * sizeof(short))..]);
			}
		}

		public _RND rnd_250 { get; }

		public _RND rnd_225 { get; }

		public _RND rnd_200 { get; }

		public _RND rnd_175 { get; }

		public _RND rnd_150 { get; }

		public _RND rnd_125 { get; }

		public _RND rnd_100 { get; }

		public _RND rnd_80 { get; }

		public _RND rnd_65 { get; }

		public _RND rnd_50 { get; }

		public _RND rnd_40 { get; }

		public _RND rnd_30 { get; }

		public _RND rnd_20 { get; }

		public _RND rnd_10 { get; }
	}
}
