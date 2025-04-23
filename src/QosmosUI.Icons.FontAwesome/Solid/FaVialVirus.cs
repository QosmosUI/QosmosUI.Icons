// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FontAwesome.Solid;

public class FaVialVirus : ComponentBase
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
		builder.AddAttribute(14, "d", "M32 32C14.3 32 0 46.3 0 64S14.3 96 32 96l0 288c0 53 43 96 96 96c28.6 0 54.2-12.5 71.8-32.3c.1-14.2 5.6-28.3 16.4-39.1c.2-.2 .1-.6-.2-.6c-30.9 0-56-25.1-56-56s25.1-56 56-56c.3 0 .4-.4 .2-.6c-21.9-21.9-21.9-57.3 0-79.2c2.4-2.4 5-4.6 7.8-6.5L224 96c17.7 0 32-14.3 32-32s-14.3-32-32-32l-64 0L96 32 32 32zM96 192l0-96 64 0 0 96-64 0zM216 376c28.8 0 43.2 34.8 22.9 55.2c-9.4 9.4-9.4 24.6 0 33.9s24.6 9.4 33.9 0c20.4-20.4 55.2-5.9 55.2 22.9c0 13.3 10.7 24 24 24s24-10.7 24-24c0-28.8 34.8-43.2 55.2-22.9c9.4 9.4 24.6 9.4 33.9 0s9.4-24.6 0-33.9C444.8 410.8 459.2 376 488 376c13.3 0 24-10.7 24-24s-10.7-24-24-24c-28.8 0-43.2-34.8-22.9-55.2c9.4-9.4 9.4-24.6 0-33.9s-24.6-9.4-33.9 0C410.8 259.2 376 244.8 376 216c0-13.3-10.7-24-24-24s-24 10.7-24 24c0 28.8-34.8 43.2-55.2 22.9c-9.4-9.4-24.6-9.4-33.9 0s-9.4 24.6 0 33.9c20.4 20.4 5.9 55.2-22.9 55.2c-13.3 0-24 10.7-24 24s10.7 24 24 24zm104-88a32 32 0 1 1 0 64 32 32 0 1 1 0-64zm40 96a24 24 0 1 1 48 0 24 24 0 1 1 -48 0z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
