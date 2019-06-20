﻿using CommandLine;
using Microsoft.Templates.Cli.Commands.Contracts;

namespace Microsoft.Templates.Cli.Commands
{
    [Verb("getfeatures", HelpText = "Get features by core.")]
    public class GetFeaturesCommand : ICommand
    {
        [Option('p', "project-type", Required = true, HelpText = "Project type")]
        public string ProjectType { get; set; }

        [Option('f', "frontend-framework", Required = false, HelpText = "Frontend framework")]
        public string FrontendFramework { get; set; }

        [Option('b', "backend-framework", Required = false, HelpText = "Backend framework")]
        public string BackendFramework { get; set; }
    }
}
