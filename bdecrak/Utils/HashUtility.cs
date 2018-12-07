using System.Collections.Generic;

namespace bdecrak.Utils {
    public static class HashUtility {
        public static Dictionary<string, string> GetBdeHashDictionary(this string hash) {
            var h = hash.Split('$');
            return new Dictionary<string, string> {
                {"tag", h[1]},
                {"authMethod", h[2]},
                {"saltSize", h[3]},
                {"salt", h[4]},
                {"iterations", h[5]},
                {"nonceSize", h[6]},
                {"vmkSize", h[7]},
                {"nonce", h[8]},
                {"mac", h[9].Substring(0, 32)},
                {"vmk", h[9].Substring(32)}
            };

        }
    }
}