using System;

namespace bdecrak.Utils {
    public static class BruteUtility {
        public static int BruteRecoveryPassword() {
            var key = KeyGenUtility.GenerateRecoveryKey();
            Console.WriteLine(key);

            return 0;
        }

        public static int BruteUserPassword() {
            throw new NotImplementedException();
        }
    }
}