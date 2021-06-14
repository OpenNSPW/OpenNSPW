using System;

namespace OpenNspw.Interop
{
	public sealed class DATA
	{
		public const int Length = 0xF1000;

		private readonly Memory<byte> _data;

		public DATA(Memory<byte> data)
		{
			if (data.Length != Length)
				throw new ArgumentException(message: null, paramName: nameof(data));

			_data = data;

			max_unit = 100;

			for (var i = 0; i < slct_unit.Length; i++)
				slct_unit[i] = new _SLCT_UNIT(_data.Slice(0x89AE0 + _SLCT_UNIT.Length * i, _SLCT_UNIT.Length));

			for (var i = 0; i < new_pp.Length; i++)
				new_pp[i] = new NEW_PP(_data.Slice(0x63AC0 + NEW_PP.Length * i, NEW_PP.Length));

			for (var i = 0; i < sprt.Length; i++)
				sprt[i] = new SPRT(_data.Slice(0x8A200 + SPRT.Length * i, SPRT.Length));

			sprt[0].wd = 699;
			sprt[0].ht = 384;
			sprt[0].base_x = 0;
			sprt[0].base_y = 3940;

			sprt[1].wd = 80;
			sprt[1].ht = 80;
			sprt[1].base_x = 0;
			sprt[1].base_y = 1759;
			sprt[1].os_of_x = 8;
			sprt[1].cx = 40;
			sprt[1].cy = 40;

			sprt[2].wd = 80;
			sprt[2].ht = 80;
			sprt[2].base_x = 0;
			sprt[2].base_y = 4550;
			sprt[2].os_of_x = 8;
			sprt[2].cx = 40;
			sprt[2].cy = 40;

			sprt[6].wd = 40;
			sprt[6].ht = 40;
			sprt[6].base_x = 0;
			sprt[6].base_y = 3520;
			sprt[6].os_of_x = 12;
			sprt[6].cx = 20;
			sprt[6].cy = 20;

			sprt[5].wd = 80;
			sprt[5].ht = 80;
			sprt[5].base_x = 0;
			sprt[5].base_y = 3000;
			sprt[5].os_of_x = 6;
			sprt[5].cx = 40;
			sprt[5].cy = 40;

			sprt[3].x = 768;
			sprt[3].y = 0;
			sprt[3].wd = 120;
			sprt[3].ht = 438;
			sprt[3].base_x = 0;
			sprt[3].base_y = 0;
			sprt[3].os_of_x = 6;
			sprt[3].cx = 0;
			sprt[3].cy = 0;

			sprt[4].wd = 120;
			sprt[4].ht = 438;
			sprt[4].base_x = 0;
			sprt[4].base_y = 878;
			sprt[4].os_of_x = 6;
			sprt[4].cx = 0;
			sprt[4].cy = 0;

			sprt[9].wd = 198;
			sprt[9].ht = 120;
			sprt[9].base_x = 361;
			sprt[9].base_y = 3250;
			sprt[9].os_of_x = 1;
			sprt[9].cx = 0;
			sprt[9].cy = 0;

			sprt[7].wd = 140;
			sprt[7].ht = 20;
			sprt[7].base_x = 0;
			sprt[7].base_y = 3250;
			sprt[7].os_of_x = 1;
			sprt[7].cx = 0;
			sprt[7].cy = 0;

			sprt[10].wd = 255;
			sprt[10].ht = 199;
			sprt[10].base_x = 0;
			sprt[10].base_y = 4340;
			sprt[10].os_of_x = 1;
			sprt[10].cx = 0;
			sprt[10].cy = 0;

			for (var i = 0; i < unit.Length; i++)
				unit[i] = new UNIT(_data.Slice(0x916A0 + UNIT.Length * i, UNIT.Length));
		}

		public int time_limit
		{
			get => BitConverter.ToInt32(_data[0x43A48..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x43A48..]);
		}

		public short max_unit
		{
			get => BitConverter.ToInt16(_data[0x43A90..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x43A90..]);
		}

		public int outcome
		{
			get => BitConverter.ToInt32(_data[0x83B44..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x83B44..]);
		}

		public short cpu_side
		{
			get => BitConverter.ToInt16(_data[0x83B4C..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x83B4C..]);
		}

		public double cmbt_x
		{
			get => BitConverter.ToDouble(_data[0x89AB0..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x89AB0..]);
		}

		public double cmbt_y
		{
			get => BitConverter.ToDouble(_data[0x89AB8..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x89AB8..]);
		}

		public int FrameCount
		{
			get => BitConverter.ToInt32(_data[0x89AD0..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x89AD0..]);
		}

		public sealed class _SLCT_UNIT
		{
			public const int Length = sizeof(short) * 256;

			private readonly Memory<byte> _data;

			public _SLCT_UNIT(Memory<byte> data)
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

		public _SLCT_UNIT[] slct_unit { get; } = new _SLCT_UNIT[2];

		public int cc_count
		{
			get => BitConverter.ToInt32(_data[0x89EE4..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x89EE4..]);
		}

		public short your_side
		{
			get => BitConverter.ToInt16(_data[0x89FB0..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x89FB0..]);
		}

		public short scenario
		{
			get => BitConverter.ToInt16(_data[0x8A1E8..].Span);
			set => BitConverter.GetBytes(value).CopyTo(_data[0x8A1E8..]);
		}

		public NEW_PP[] new_pp { get; } = new NEW_PP[2];

		public SPRT[] sprt { get; } = new SPRT[25];

		public UNIT[] unit { get; } = new UNIT[101];
	}
}
