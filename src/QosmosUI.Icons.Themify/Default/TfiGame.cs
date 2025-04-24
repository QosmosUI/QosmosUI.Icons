// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Themify.Default;

public class TfiGame : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "17";

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
    public string ViewBox { get; set; } = "0 0 17 17";

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
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M9 3.988v-2.988h-1v2.988c-3.564 0.105-8 1.282-8 2.487v7.041c0 0.827 0.673 1.5 1.5 1.5h1.79l1.996-3.931c0.567 0.104 1.713 0.274 3.173 0.274 1.479 0 2.694-0.174 3.288-0.277l1.908 3.934h1.845c0.827 0 1.5-0.673 1.5-1.5v-7.041c0-1.205-4.437-2.383-8-2.487zM16 13.516c0 0.275-0.225 0.5-0.5 0.5h-1.218l-1.976-4.070-0.386 0.085c-0.015 0.003-1.515 0.329-3.462 0.329-1.941 0-3.315-0.323-3.329-0.327l-0.384-0.093-2.068 4.075h-1.177c-0.275 0-0.5-0.225-0.5-0.5v-6.915c0.502-0.437 3.38-1.518 7-1.611v0.011h1v-0.013c3.619 0.094 6.498 1.175 7 1.612v6.917zM5 7.020h0.998v1h-0.998v1.020h-1v-1.020h-1v-1h1v-1.020h1v1.020zM12.5 9.020c0.827 0 1.5-0.673 1.5-1.5s-0.673-1.5-1.5-1.5-1.5 0.672-1.5 1.5 0.673 1.5 1.5 1.5zM12.5 7.020c0.275 0 0.5 0.225 0.5 0.5s-0.225 0.5-0.5 0.5-0.5-0.225-0.5-0.5 0.225-0.5 0.5-0.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
