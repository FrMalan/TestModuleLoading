using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Stratos.Workbench.Module.OutVest
{
    public class ExampleJsInterop
    {
        public static ValueTask<string> Prompt(IJSRuntime jsRuntime, string message)
        {
            // Implemented in exampleJsInterop.js
            return jsRuntime.InvokeAsync<string>("exampleJsFunctions.showPrompt", message);
        }
    }
}
