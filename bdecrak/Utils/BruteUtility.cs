using System;
using System.Collections.Generic;

namespace bdecrak.Utils {
    public static class BruteUtility {
        public static int BruteRecoveryPassword() {
//            var key = KeyGenUtility.GenerateRecoveryKey();
//            Console.WriteLine(key);
            var hashdict = Constants.RpHash.GetBdeHashDictionary();

            foreach (var item in hashdict) {
                Console.WriteLine(item);
            }



            return 0;
        }

        public static int BruteUserPassword() {
            throw new NotImplementedException();
        }
    }
}