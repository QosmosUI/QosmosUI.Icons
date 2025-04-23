// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiFavro : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.586 1.655a6.623 6.623 0 0 0-6.62 6.62v.773a7.503 7.503 0 0 1 3.31 3.269V8.276a3.302 3.302 0 0 1 3.31-3.31A1.66 1.66 0 0 0 13.24 3.31a1.66 1.66 0 0 0-1.656-1.655zm-9.93 7.448A1.66 1.66 0 0 0 0 10.758c0 .91.745 1.655 1.655 1.655a3.302 3.302 0 0 1 3.31 3.31v4.966c0 .91.745 1.655 1.655 1.655a1.66 1.66 0 0 0 1.655-1.655v-4.966a6.623 6.623 0 0 0-6.62-6.621zm15.724 0a6.623 6.623 0 0 0-6.622 6.621 6.623 6.623 0 0 0 6.622 6.621 6.583 6.583 0 0 0 3.462-.979c.262.58.84.98 1.503.98A1.66 1.66 0 0 0 24 20.69v-9.93a1.66 1.66 0 0 0-1.655-1.655c-.676 0-1.241.4-1.503.979a6.574 6.574 0 0 0-3.462-.98zm0 3.311a3.303 3.303 0 0 1 3.31 3.31 3.303 3.303 0 0 1-3.31 3.31 3.302 3.302 0 0 1-3.31-3.31 3.303 3.303 0 0 1 3.31-3.31z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
