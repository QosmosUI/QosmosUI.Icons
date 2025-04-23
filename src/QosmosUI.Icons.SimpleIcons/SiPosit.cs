// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiPosit : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 .953v6.393l4.852 2.066-3.27 1.447v2.283l3.215 1.432L0 16.615v6.432l11.918-5.256.082-.035.082.035L24 23.047v-6.432l-4.797-2.04 3.215-1.433v-2.283l-3.27-1.447L24 7.346V.953L12 6.25Zm.879 1.352 10.039 4.431-4.96 2.19L.879 6.763Zm22.242 0v4.458l-5.066 2.162-4.973-2.19 10.04-4.431ZM12 7.209l4.945 2.19-4.95 2.107-4.94-2.108zM5.959 9.885l4.926 2.093-.006.002.006.002-4.979 2.12-3.446-1.529v-1.148l3.5-1.541zm12.082 0 3.514 1.54v1.15l-3.448 1.526-1.107.487-4.994 2.21L7 14.589l4.994-2.133L17 14.588l1.094-.487-4.973-2.12zM5.906 15.06l5.012 2.215-.066.03-9.973 4.404v-4.512zm12.201 0 5.014 2.137v4.512l-9.959-4.404-.066-.03z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
