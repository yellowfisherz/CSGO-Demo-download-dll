using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace libShareCodeToURL
{
    class Sharecodetransform
    {
        const string DICTIONARY = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefhijkmnopqrstuvwxyz23456789";
        const string SHARECODE_PATTERN = "^CSGO(-?[\\w]{5}){5}$";
        public struct ShareCodeStruct
        {
            public UInt64 MatchId;
            public UInt64 OutcomeId;
            public UInt32 TokenId;
        }
        public static ShareCodeStruct Decode(string shareCode)
        {
            Regex r = new Regex(SHARECODE_PATTERN);

            BigInteger big = BigInteger.Zero;
            foreach (char c in shareCode.ToCharArray().Reverse())
            {
                big = BigInteger.Multiply(big, DICTIONARY.Length) + DICTIONARY.IndexOf(c);
            }

            byte[] matchIdBytes = new byte[sizeof(UInt64)];
            byte[] outcomeIdBytes = new byte[sizeof(UInt64)];
            byte[] tvPortIdBytes = new byte[sizeof(UInt32)];

            byte[] all = big.ToByteArray().ToArray();
            // sometimes the number isn't unsigned, add a 00 byte at the end of the array to make sure it is
            if (all.Length != 2 * sizeof(UInt64) + sizeof(UInt16))
                all = all.Concat(new byte[] { 0 }).ToArray();
            all = all.Reverse().ToArray();
            Array.Copy(all, 0, matchIdBytes, 0, sizeof(UInt64));
            Array.Copy(all, sizeof(UInt64), outcomeIdBytes, 0, sizeof(UInt64));
            Array.Copy(all, 2 * sizeof(UInt64), tvPortIdBytes, 0, sizeof(UInt16));

            ShareCodeStruct s = new ShareCodeStruct
            {
                MatchId = BitConverter.ToUInt64(matchIdBytes, 0),
                OutcomeId = BitConverter.ToUInt64(outcomeIdBytes, 0),
                TokenId = BitConverter.ToUInt32(tvPortIdBytes, 0),
            };

            return s;
        }
        public class ShareCodePatternException : Exception
        {
            public ShareCodePatternException() : base("Invalid share code")
            {
            }
        }
    }
}
