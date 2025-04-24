// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiWashingMachine : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M73 41v78h110V41H73zm128 0v78h238V41H201zm199 23a16 16 0 0 1 16 16 16 16 0 0 1-16 16 16 16 0 0 1-16-16 16 16 0 0 1 16-16zm-176 7h48v18h-48V71zm80 0h48v18h-48V71zM73 137v350h366V137H73zm183 30c82.7 0 150 67.3 150 150s-67.3 150-150 150-150-67.3-150-150 67.3-150 150-150zm0 18c-73 0-132 59-132 132s59 132 132 132c48.5 0 90.8-26 113.7-64.9L339.6 360a94.02 94.02 0 0 1-83.6 51 94.02 94.02 0 0 1-94-94 94.02 94.02 0 0 1 94-94 94.02 94.02 0 0 1 85.7 55.3l30.4-24.3c-22.3-41.1-65.9-69-116.1-69zm-6.9 62c-50.1 1.1-76.9 51-62 93.9-.7-37.8 30.1-78 62-93.9zm130.6 23.9l-32 25.6A94.02 94.02 0 0 1 350 317a94.02 94.02 0 0 1-3.5 25.5l31.4 25.2C384.4 352.1 388 335 388 317c0-16.2-2.9-31.8-8.3-46.1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
