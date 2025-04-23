// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiCooler : ComponentBase
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
		builder.AddAttribute(14, "d", "m71.03 41-11.5 46H452.5L441 41H71.03zM25 105v46h158v-28h146v28h158v-46H25zm176 36v78h110v-78H201zM41 169v276.3L68.82 487H443.2l27.8-41.7V169H329v68H183v-68H41zm196.5 78.1 16.9 30.3h.8l16.9-30.3 15.8 8.8-24.1 43.2v39.8l33.5-19.8 24.4-42.9 15.6 8.8-17.3 30.4.7 1.1 34-.1v18l-48.4.2-34.3 20.3 34.4 20.4 48.5.3-.2 18-33.9-.2-.7 1.1 17.3 30.4-15.6 8.8-24.4-42.9-33.6-19.9v39.8l24.1 43.2-15.8 8.8-16.8-30.2h-1l-16.8 30.2-15.8-8.8 24.1-43.2v-40.2l-33.5 19.8-24.4 42.9-15.6-8.8 17.3-30.4-.7-1.1-34 .1v-18l48.4-.2 33.5-19.9-33.5-19.8-48.3-.2v-18l34.1.1.6-1-17.3-30.5 15.6-8.8 24.5 43 33.3 19.7v-40.3l-24.1-43.2 15.8-8.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
