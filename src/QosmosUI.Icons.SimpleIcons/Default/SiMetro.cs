// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiMetro : ComponentBase
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
		builder.AddAttribute(15, "d", "M12 0c-.655 0-1.31.143-1.807.43l-7.31 4.22c-.99.574-1.806 1.98-1.806 3.129v8.442c0 1.14.813 2.555 1.805 3.128l7.311 4.221c.994.573 2.619.573 3.612 0l7.311-4.22c.994-.574 1.807-1.982 1.807-3.129V7.779c0-1.14-.813-2.555-1.807-3.128L13.806.43C13.308.143 12.653 0 11.998 0zm.005 2.606c.29 0 .577.073.834.209l4.718 2.724-1.76 1.067L12 4.414 8.21 6.602 6.448 5.534l4.71-2.72c.26-.137.551-.21.847-.208zm7.577 4.237a.905.905 0 0 1 .909.9c-.001 2.472 0 5.432-.008 8.313a1.761 1.761 0 0 1-.84 1.46l-6.8 3.927a1.694 1.694 0 0 1-.843.215 1.7 1.7 0 0 1-.844-.215l-6.802-3.927a1.763 1.763 0 0 1-.842-1.46V7.75a.905.905 0 0 1 1.376-.765C7.188 8.381 9.626 9.835 12 11.3c2.375-1.443 4.757-2.897 7.115-4.322a.895.895 0 0 1 .467-.135zM5.32 9.355v6.632L12 19.844l6.682-3.857V9.355l-6.213 3.773a.899.899 0 0 1-.937 0Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
