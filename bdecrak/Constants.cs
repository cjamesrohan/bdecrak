namespace bdecrak {
    public static class Constants {
        public const string RP_HASH = "$bitlocker$2$16$122ca272e1417849662d3bdcfc54f501$1048576$12$30c8d1f194e6d00104000000$60$c5199e7697d573a6884c83e92315a2491316cc203f29e260705f2e1751ccffeec3aa2c1d68080216be1cfbfa9ad8f7340dcf1c51075f7561839e331a";
        public const string UP_HASH = "$bitlocker$0$16$8eba8c52eba52c4cd0717fbf22bfffe3$1048576$12$30c8d1f194e6d00106000000$60$78d31d04d06c980f7ef3a1a2616d6bdfe60532268038ada36bc94534e4b580d54f908eb318d04155e13742c92b1001186560de4160b179ad8a491d87";

        public const int AUTHENTICATOR_LENGTH = 16;
        public const int AES_CTX_LENGTH = 256;
        public const int FALSE = 0;
        public const int TRUE = 1;
        public const int SALT_SIZE = 16;
        public const int MAC_SIZE = 16;
        public const int NONCE_SIZE = 12;
        public const int IV_SIZE = 16;

        public const int VMK_SIZE = 60;
        public const int VMK_HEADER_SIZE = 12;
        public const int VMK_BODY_SIZE = 32;
        public const int VMK_FULL_SIZE = 44;

        public const int RECOVERY_KEY_SIZE_CHAR = 56;
        public const int RECOVERY_PASS_BLOCKS = 8;
        public const int MODE_USER_PASS = 1;
        public const int MODE_RECV_PASS = 2;

        public const int PSW_CHAR_SIZE = 64;
        public const int PSW_INT_SIZE = 32; //16
        public const int FIRST_LENGTH = 27;
        public const int SECOND_LENGTH = 55;

        public const int BLOCK_UNIT = 32;
        public const int HASH_SIZE_STRING = 32;
        public const int DICT_BUFSIZE = (50 * 1024 * 1024);
        public const int MAX_PLEN = 32;

        public const int HASH_SIZE = 8;
        public const int ROUND_SHA_NUM = 64;
        public const int SINGLE_BLOCK_SHA_SIZE = 64;
        public const int SINGLE_BLOCK_W_SIZE = 64;
        public const int PADDING_SIZE = 40;
        public const int ITERATION_NUMBER = 0x100000;
        public const int WORD_SIZE = 4;
        public const int INPUT_SIZE = 2048;
        public const int FIXED_PART_INPUT_CHAIN_HASH = 88;
        public const int MIN_INPUT_PASSWORD_LEN = 8;
        public const int MAX_INPUT_PASSWORD_LEN = 27;

        public const string HASH_TAG = "$bitlocker$";
        public const int HASH_TAG_LEN = 10; //(sizeof(HASH_TAG) - 1)
        public const int INPUT_HASH_SIZE = 210;

        public const int ATTACK_DEFAULT_THREADS = 1024;

        public const int BIT_SUCCESS = 0;
        public const int BIT_FAILURE = 1;

        public const int MAX_SOURCE_SIZE = (0x100000);

        public const int LOCAL_THREAD = 768;
        public const int MAX_NUM_PLATFORMS = 10;
        public const int MAX_DEVICE_NAME_SIZE = 2048;
    }
}