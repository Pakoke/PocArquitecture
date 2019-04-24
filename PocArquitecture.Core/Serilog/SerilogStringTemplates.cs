namespace PocArquitecture.Core.Serilog
{
    public static class SerilogStringTemplates
    {
        public static string MiddlewareMessageTemplate = "HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000} ms";

        public static string ValidationStaffMessageTemplate = "TypeValidator {Type} Dni {dni} message validator {message}";
    }
}
