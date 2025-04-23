// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiMortarBoard : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M20.5 7.9s-5.8-2.9-6.9-3.5-1.7-.7-3 0c-1.3.6-6.7 3.3-6.7 3.3-.8.4-1.5 1.2-1.5 2s.2 1.2.2 1.2-.1.3-.3 1.5c-.3 1.2-.3 2.7-.3 3.3 0 1.5 1.3 2.6 2.2 2.7.9.1 1.6-.1 1.6-.1 1.4 1.3 3.7 2.1 6.4 2.1 4.4 0 7.8-2.2 7.8-5 0-1.1-.4-2.7-.4-2.7l1.1-.6c.9-.5 1.3-1.4 1.3-2.3-.1-.8-.6-1.5-1.5-1.9zm-8.2 10.4c-3.2 0-5.8-1.3-5.8-3l.5-2.8 4.2 2.1c.6.3 1.5.3 2.2 0l4.3-2.1.4 2.8c0 1.6-2.5 3-5.8 3zm7.3-8.1l-6.6 3.4c-.4.2-1 .2-1.4 0l-5.7-2.9c-.2.5-.3 1.2-.3 2 0 1.4.2 2.4.2 2.9s-.3.8-.7.8h-.1c-.4 0-.8-.3-.8-.8s0-1.6.3-3.1c.2-.9.4-1.7.6-2.2l-.2-.1c-.4-.2-.4-.5 0-.7l6.7-3.4c.4-.2.9-.2 1.3 0s6.7 3.4 6.7 3.4c.4.2.4.5 0 .7z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
