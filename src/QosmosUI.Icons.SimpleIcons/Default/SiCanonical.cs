// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiCanonical : ComponentBase
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
		builder.AddAttribute(15, "d", "M4.427 0v24h15.146V0Zm9.994 10.25a1.568 1.568 0 0 1 1.567 1.568 1.568 1.568 0 0 1-1.567 1.568 1.568 1.568 0 0 1-1.568-1.568 1.568 1.568 0 0 1 1.568-1.568zm-2.157.16c.122 0 .245.005.369.015a2.268 2.268 0 0 0-.476 1.271 3.825 3.825 0 0 0-3.08 1.647 2.243 2.243 0 0 0-1.308-.335 5.159 5.159 0 0 1 4.495-2.599zm4.242 2.296a5.14 5.14 0 0 1 .74 3.905 5.139 5.139 0 0 1-.997 2.113 2.25 2.25 0 0 0-.75-1.167 3.837 3.837 0 0 0 .125-3.818 2.26 2.26 0 0 0 .882-1.033zm-8.616.982a1.568 1.568 0 0 1 1.568 1.568 1.568 1.568 0 0 1-1.568 1.568 1.568 1.568 0 0 1-1.567-1.568 1.568 1.568 0 0 1 1.567-1.568Zm.933 3.618a3.818 3.818 0 0 0 2.604 1.986c.127.027.256.048.385.063.01.476.17.932.459 1.31a5.161 5.161 0 0 1-1.114-.114 5.105 5.105 0 0 1-3.675-3.08 2.26 2.26 0 0 0 1.34-.165zm5.244.427a1.568 1.568 0 0 1 1.568 1.568 1.568 1.568 0 0 1-1.568 1.568A1.568 1.568 0 0 1 12.5 19.3a1.568 1.568 0 0 1 1.568-1.568z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
