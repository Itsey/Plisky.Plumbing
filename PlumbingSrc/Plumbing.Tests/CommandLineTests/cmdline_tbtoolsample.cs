﻿#if false
namespace Plisky.Test {
    using Plisky.Helpers;

    [CommandLineArguments]
    public class TFSBuildToolArgs {

        [CommandLineArg("tfs")]
        public string tfs;

        [CommandLineArg("teamProject")]
        public string teamProject;

        [CommandLineArg("buildDefinition")]
        public string buildDefinition;

        [CommandLineArg("agent")]
        [CommandLineArg("agenturi")]
        public string agentUri;
    }
}
#endif