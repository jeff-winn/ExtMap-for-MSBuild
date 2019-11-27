using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;

namespace ExtMap.MSBuild.Tools
{
    public class Emm : ToolTask
    {
        public const string TOOL_NAME = "Emm.exe";

        [Required]
        public string Target { get; set; }
        
        public string AlternateCacheUri { get; set; }

        protected override string ToolName
        {
            get { return TOOL_NAME; }
        }

        protected override string GenerateCommandLineCommands()
        {
            CommandLineBuilder cmb = new CommandLineBuilder();

            cmb.AppendFileNameIfNotNull(this.Target);
            cmb.AppendFileNameIfNotNull(this.AlternateCacheUri);

            return cmb.ToString();
        }

        protected override string GenerateFullPathToTool()
        {
            throw new NotImplementedException();
        }
    }
}