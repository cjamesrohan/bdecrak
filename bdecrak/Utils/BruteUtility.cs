using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace bdecrak.Utils {
    public static class BruteUtility {
        public static int BruteRecoveryPassword() {
            var key = KeyGenUtility.GenerateRecoveryKey();

            var cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine($"manage-bde -unlock E: -recoverypassword {key}");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
//            Console.WriteLine(key);
//
//            var p = Constants.RP_HASH.Split('$');
//            var h = HashUtility.GetBdeHashDictionary(p);
//
//            var encryptedVmk = h["vmk"];
//            var nonce = h["nonce"];
//            var encryptedMac = h["mac"];
//
//            foreach (var i in h) {
//                Console.WriteLine($"{i.Key} [{i.Value.Length}] => {i.Value}");
//            }





            return 0;
        }

        public static int BruteUserPassword() {
            throw new NotImplementedException();
        }
    }
}