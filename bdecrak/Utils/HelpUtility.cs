using Microsoft.Extensions.CommandLineUtils;

namespace bdecrak.Utils {
    public static class HelpUtility {
        public static void GetHelp(this CommandLineApplication app) {
            app.HelpOption("-?|-h|--help");
        }
    }
}