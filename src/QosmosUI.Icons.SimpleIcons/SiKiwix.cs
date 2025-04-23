// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiKiwix : ComponentBase
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
		builder.AddAttribute(15, "d", "M23.968 15.033c-.185-.811-1.527-3.15-4.27-5.224a27.047 27.047 0 0 0-1.33-.95c.548-2.346-2.303-5.177-5.084-3.844C11.287 3.136 9.06 2.37 7.012 2.401c-5.422.076-9.605 5.725-5.106 11.117l.01.009c.068.082.14.165.211.247.292.35.486.66.65 1.206l1.343 4.397h-.475a.794.794 0 0 0-.794.794h1.801L7.68 21.6a.79.79 0 0 0-.377-1.054l-.793-.374H8.79a.794.794 0 0 0-.793-.794H5.929a.822.822 0 0 1-.786-.581L4.08 15.305c-.266-.918.343-1.517.915-1.589.522-.064.785.272 1.03 1.088l.945 3.098h-.475a.794.794 0 0 0-.793.793h1.8l3.027 1.431a.79.79 0 0 0-.376-1.054l-.794-.375h1.674a4 4 0 0 0 6.278.805 4 4 0 0 0 0-5.654 4 4 0 0 0-6.632 4.056H8.784a.822.822 0 0 1-.787-.582l-1.569-5.157.268-.142c3.724-1.563 7.707 1.228 10.479-1.454l.018-.017c.343-.312.686-.631 1.7.004 1.092.684 3.501 2.47 4.593 5.522.002 0 .665-.236.482-1.045zm-7.662-6.764a.769.769 0 1 0-1.275.595 1.2 1.2 0 1 1 1.275-.595z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
