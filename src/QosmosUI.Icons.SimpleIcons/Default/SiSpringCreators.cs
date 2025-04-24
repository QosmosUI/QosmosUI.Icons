// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiSpringCreators : ComponentBase
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
		builder.AddAttribute(15, "d", "M8.563 24c-1.839 0-4.435-.537-7.028-2.87l2.035-2.262c3.636 3.273 7.425 1.98 8.595.888.078-.079.156-.153.234-.23-3.83-.373-6.629-3.086-6.822-3.277-2.933-2.889-3.6-6.808-1.512-8.93s6.015-1.522 8.95 1.357c.257.246 3.116 3.052 3.677 6.605a6.776 6.776 0 002.727-5.426 6.62 6.62 0 00-1.995-4.791c-1.334-1.303-3.222-2.02-5.306-2.02V0c2.88 0 5.519 1.024 7.43 2.882 1.881 1.83 2.917 4.304 2.917 6.973a9.831 9.831 0 01-6.116 9.086c-.416 1.1-1.12 2.117-2.106 3.04-.97.905-2.865 1.908-5.28 2.01-.13.007-.262.009-.4.009zM7.283 9.077c-.425 0-.79.115-1.046.375-.749.762-.275 2.904 1.48 4.633l.008.009c.025.024 2.771 2.687 6.025 2.414v-.005c.015-2.873-2.808-5.597-2.837-5.625l-.02-.019C9.85 9.832 8.37 9.077 7.283 9.077Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
