// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiDts : ComponentBase
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
		builder.AddAttribute(15, "d", "m23.556 14.346-1.194-1.173a.841.841 0 0 1 .604-1.445h.59a.346.346 0 0 0 .349-.343v-.636H18.97a1.492 1.492 0 0 0-1.507 1.477v.003c0 .396.16.775.444 1.05l1.201 1.18a.841.841 0 0 1-.604 1.446h-1.849a1.306 1.306 0 0 1-1.317-1.294v-2.876h1.135a.346.346 0 0 0 .35-.343v-.636h-1.485V7.587l-3.866 1.66v1.494h-1.87V7.123h-2.87a.986.986 0 0 0-.997.98v2.638H3.67C1.514 10.741 0 11.893 0 13.81c0 1.71 1.776 3.068 3.676 3.068h4.615a1.306 1.306 0 0 0 1.318-1.294v-3.855h1.863v2.503c0 1.423.874 2.646 2.65 2.646h8.371A1.492 1.492 0 0 0 24 15.4v-.003a1.444 1.444 0 0 0-.444-1.051zM5.729 15.683a.217.217 0 0 1-.219.214h-.13c-1.34 0-1.835-.908-1.85-2.088.015-1.216.525-2.088 1.85-2.088h.349v3.962z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
