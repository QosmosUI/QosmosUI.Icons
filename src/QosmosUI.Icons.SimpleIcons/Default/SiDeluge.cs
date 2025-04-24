// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiDeluge : ComponentBase
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
		builder.AddAttribute(15, "d", "M18.766 10.341 12.006 0l-6.77 10.342c-1.945 2.97-2.191 6.432-.66 9.264C6.04 22.316 8.885 24 12.001 24c3.113 0 5.957-1.681 7.421-4.388 1.532-2.832 1.287-6.297-.657-9.27zm-10.082 6.9c1.433 2.554 3.608 3.045 6.585 2.102-1.7 1.848-5.188 2.337-7.557-.302-1.63-1.817-1.773-4.351-.642-6.468 1.132-2.117 3.388-2.706 5.012-1.551-3.723.09-4.43 4.38-3.398 6.218zm8.72-6.009c.723 1.107 1.152 2.267 1.314 3.418-3.354 5.763-7.862 4.879-9.062 1.377-.554-1.618 1.19-5.08 4.514-3.725-1.296-2.838-4.238-4.017-6.911-1.809a5.099 5.099 0 0 0-.609.66l5.355-8.179 5.398 8.258z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
