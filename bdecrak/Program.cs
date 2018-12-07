using System;
using bdecrak.Utils;
using Microsoft.Extensions.CommandLineUtils;

namespace bdecrak {
    class Program {
        static void Main(string[] args) {
            var app = new CommandLineApplication {
                Name = "bdecrak",
                Description = ".NET Core console app with argument parsing."
            };
            app.GetHelp();

            app.Command("brute", (brute) => {
                brute.Description = "Brute ";
                brute.GetHelp();

                brute.Command("rp", (rp) => {
                    rp.Description = "Recovery password mode";
                    rp.GetHelp();

                    rp.OnExecute(() => BruteUtility.BruteRecoveryPassword());
                });

//                brute.Command("up", (up) => {
//                    up.Description = "User password mode";
//                    up.GetHelp();
//
//                    up.OnExecute(() => BruteUtility.BruteUserPassword());
//                });

                brute.OnExecute(() => 0);
            });

            app.Command("keygen", (keygen) => {
                keygen.Description = "Create a list of randomly generated user passwords or recovery passwords.";
                keygen.GetHelp();

                keygen.Command("rp", (rp) => {
                    rp.Description = "Generate a list of recovery passwords.";
                    rp.GetHelp();

                    var fileOption = rp.Option("-f|--files", "Number of files to create. (default 100)", CommandOptionType.SingleValue);
                    var keyOption = rp.Option("-k|--keys", "Number of keys to generate per file. (default 1000000)", CommandOptionType.SingleValue);

                    rp.OnExecute(() => {
                        var files = 100;
                        var keysPerFile = 1000000;

                        if (fileOption.HasValue()) {
                            files = Convert.ToInt32(fileOption.Value());
                        }

                        if (keyOption.HasValue()) {
                            keysPerFile = Convert.ToInt32(keyOption.Value());
                        }

                        return KeyGenUtility.CreateRecoveryKeyList(files, keysPerFile);
                    });
                });

//                keygen.Command("up", (rp) => {
//                    rp.Description = "Generate a list of user passwords.";
//                    rp.GetHelp();
//
//                    rp.OnExecute(() => KeyGenUtility.CreateUserPasswordList());
//                });

                keygen.OnExecute(() => 0);
            });

            try {
                app.Execute(args);
            } catch {
                app.ShowHint();
            }
        }
    }
}