using System;
using Xunit;
using static Bech32_Csharp.Converter;

namespace Bech32_Csharp_tests
{
	public static class Test
	{
		[Fact]
		public static void conversionToCashAddr()
		{
			byte[] a = DecodeBech32("bc1qcash96s5jqppzsp8hy8swkggf7f6agex98an7h", out _, out _, out _);
			string b = EncodeBech32(0, a, true, true);
			Assert.Equal("bc1qcash96s5jqppzsp8hy8swkggf7f6agex98an7h", b);

		}
		/*[Fact]
		public static void conversionToOldAddr()
		{
		}*/
	}
}
