// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiSwr : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 12.187a2.659 2.659 0 0 0 2.648 2.647 2.662 2.662 0 0 0 2.647-2.646v-.376a1.097 1.097 0 0 1 1.092-1.086c.326 0 .636.147.844.399h1.712a2.66 2.66 0 0 0-2.558-1.959 2.664 2.664 0 0 0-2.647 2.647v.374c0 .598-.493 1.09-1.091 1.09a1.096 1.096 0 0 1-1.09-1.09.314.314 0 0 0-.312-.312H.311a.313.313 0 0 0-.311.312Zm10.131 2.647a2.664 2.664 0 0 1-2.555-1.96h1.71a1.088 1.088 0 0 0 1.935-.683v-.379a2.663 2.663 0 0 1 2.648-2.646 2.65 2.65 0 0 1 2.647 2.591l.008.43a1.097 1.097 0 0 0 1.092 1.086c.326 0 .636-.146.843-.399h1.712a2.657 2.657 0 0 1-2.556 1.96 2.66 2.66 0 0 1-2.648-2.646l-.008-.389v-.017a1.096 1.096 0 0 0-1.09-1.059 1.096 1.096 0 0 0-1.09 1.09v.374a2.663 2.663 0 0 1-2.648 2.647Zm10.376-3.708a1.09 1.09 0 0 1 1.936.683v.004c0 .171.14.312.311.312h.935a.313.313 0 0 0 .311-.312 2.663 2.663 0 0 0-2.648-2.647 2.659 2.659 0 0 0-2.557 1.96h1.712Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
