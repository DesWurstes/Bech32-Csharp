# Bech32 Encode/Decode C#

This project allows you to convert between SegWit Bech32 addresses and raw bytes.

Sister project of [SharpCashAddr](https://github.com/cashaddress/SharpCashAddr) which can do the same thing for Bitcoin Cash CashAddr.

```
public static string EncodeBech32(byte witnessVersion, byte[] witnessProgram, bool isP2PKH, bool mainnet);
public static byte[] DecodeBech32(string addr, out byte witnessVersion, out byte isP2PKH, out bool mainnet);
```
