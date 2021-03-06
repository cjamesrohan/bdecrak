﻿using System.Collections.Generic;

namespace bdecrak.Utils {
    public static class HashUtility {
        public static Dictionary<string, string> GetBdeHashDictionary(string[] h) {
            return new Dictionary<string, string> {
                {"tag", h[1]},
                {"authMethod", h[2]},
                {"saltSize", h[3]},
                {"salt", h[4]},
                {"iterations", h[5]},
                {"nonceSize", h[6]},
                {"nonce", h[7]},
                {"vmkSize", h[8]},
                {"mac", h[9].Substring(0, 32)},
                {"vmk", h[9].Substring(32)}
            };

        }
    }
}