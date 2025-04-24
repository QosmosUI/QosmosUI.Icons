// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiLibreofficebase : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M17 13h-1v-1h1v1zm0 1h-1v1h1v-1zm0 2h-1v1h1v-1zm-.6-16H15l7 7V0h-5.6zM13 0l9 9v12c0 1.662-1.338 3-3 3H5c-1.662 0-3-1.338-3-3V3c0-1.662 1.338-3 3-3h8zM6 11c0 .552 1.343 1 3 1s3-.448 3-1v-1c0-.552-1.343-1-3-1s-3 .448-3 1v1zm0 2c0 .552 1.343 1 3 1s3-.448 3-1v-1c0 .552-1.343 1-3 1s-3-.448-3-1v1zm0 2c0 .552 1.343 1 3 1s3-.448 3-1v-1c0 .552-1.343 1-3 1s-3-.448-3-1v1zm0 2c0 .552 1.343 1 3 1s3-.448 3-1v-1c0 .552-1.343 1-3 1s-3-.448-3-1v1zm12-6h-5v7h5v-7zm-3 1h-1v1h1v-1zm0 4h-1v1h1v-1zm0-2h-1v1h1v-1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
