using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using SiemensIXBlazor.Components.Interops;

namespace SiemensIXBlazor.Components
{
    public partial class Chip
    {
        [Parameter, EditorRequired]
        public string Id { get; set; } = string.Empty;
        [Parameter]
        public string Class { get; set; } = string.Empty;
        [Parameter]
        public string Label { get; set; } = string.Empty;
        [Parameter]
        public bool Active { get; set; } = true;
        [Parameter]
        public string? Background { get; set; }
        [Parameter]
        public bool Closable { get; set; } = false;
        [Parameter]
        public string? Color { get; set; }
        [Parameter]
        public string? Icon { get; set; }
        [Parameter]
        public bool Outline { get; set; } = false;
        [Parameter]
        public string Variant { get; set; } = "primary";
        [Parameter]
        public EventCallback ClosedEvent { get; set; }

        private BaseInterop _interop;

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                _interop = new(JSRuntime);

                await _interop.AddEventListener(this, Id, "close", "Closed");
            }
        }

        [JSInvokable]
        public async void Closed()
        {
            await ClosedEvent.InvokeAsync();
        }
    }
}
