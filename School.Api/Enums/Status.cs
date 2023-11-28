using System.ComponentModel;

namespace School.Api.Enums
{
    public enum Status
    {
        [Description("User Disable")]
		Disable = 0,

		[Description("User Enable")]
		Enable = 1
    }
}
