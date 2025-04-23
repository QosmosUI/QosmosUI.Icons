// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiBluetooth : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Bluetooth");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M18.649,15.938,11.829,12l6.82-3.94a.984.984,0,0,0,.5-.87.968.968,0,0,0-.5-.861L12.029,2.5a.989.989,0,0,0-1,0,1,1,0,0,0-.5.87v7.769q-2.1-1.23-4.22-2.44c-.24-.139-.47-.279-.71-.409a.5.5,0,0,0-.51.86L10.039,12c-1.41.81-2.83,1.62-4.23,2.44-.24.129-.48.27-.72.41a.5.5,0,0,0,.51.86c1.65-.951,3.28-1.891,4.93-2.85v7.769a.993.993,0,0,0,.5.871.969.969,0,0,0,1,0l6.62-3.82a1.007,1.007,0,0,0,0-1.74Zm-7.12-12.57,6.62,3.82-6.62,3.83Zm0,17.259V12.988l6.62,3.82Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
