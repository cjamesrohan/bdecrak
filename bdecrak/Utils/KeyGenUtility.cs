using System;
using System.Collections.Generic;
using System.IO;

namespace bdecrak.Utils {
    public static class KeyGenUtility {
        public static int CreateRecoveryKeyList(int fileCount, int keysPerFile) {
            var directory = "./Dictionary";
            Directory.CreateDirectory(directory);

            Console.WriteLine($@"
Running with this configuration:
### Create {fileCount} word lists
### Recovery Passwords per word list: {keysPerFile}
### Created in directory: {directory}
            ");

            for (var i = 0; i < fileCount; i++) {
                var filename = $"bdecrak_wlrp_{i}.txt";
                var filepath = $"{directory}/{filename}";

                Console.WriteLine($"Putting {keysPerFile} passwords in file {filename}");

                var keys = new List<string>();
                for (var j = 0; j < keysPerFile; j++) {
                    keys.Add(GenerateRecoveryKey());
                }

                File.AppendAllLines(filepath, keys);
            }

            return 0;
        }

        public static int CreateUserPasswordList() {
            throw new NotImplementedException();
        }

        public static string GenerateRecoveryKey() {
            var groups = new List<string>();
            for (var i = 0; i < 8; i++) {
                var random = new Random();
                var group = random.Next(65536) * 11;
                groups.Add(group.ToString("000000"));
            }

            return string.Join("-", groups);
        }
    }
}