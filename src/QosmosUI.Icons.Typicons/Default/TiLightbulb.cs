// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiLightbulb : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M12.5 5.5c-.276 0-.5.224-.5.5s.224.5.5.5c1.083 0 1.964.881 1.964 1.964 0 .276.224.5.5.5s.5-.224.5-.5c0-1.634-1.33-2.964-2.964-2.964zM12.5 1c-4.136 0-7.5 3.364-7.5 7.5 0 1.486.44 2.922 1.274 4.165l.08.135c1.825 2.606 2.146 3.43 2.146 4.2v3c0 .552.448 1 1 1h2c0 .26.11.52.29.71.19.18.45.29.71.29.26 0 .52-.11.71-.29.18-.19.29-.45.29-.71h2c.552 0 1-.448 1-1v-3c0-.782.319-1.61 2.132-4.199.895-1.275 1.368-2.762 1.368-4.301 0-4.136-3.364-7.5-7.5-7.5zm2 18h-4v-1h4v1zm2.495-7.347c-1.466 2.093-2.143 3.289-2.385 4.347h-1.11v-2c0-.552-.448-1-1-1s-1 .448-1 1v2h-1.113c-.24-1.03-.898-2.2-2.306-4.22l-.077-.129c-.657-.934-1.004-2.024-1.004-3.151 0-3.033 2.467-5.5 5.5-5.5s5.5 2.467 5.5 5.5c0 1.126-.347 2.216-1.005 3.153z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
